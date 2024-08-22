using CommunityToolkit.Mvvm.Input;
using JMWToolkit.MVVM.Helpers;
using JMWToolkit.MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;

namespace JMWToolkit.MVVM.Controls;

enum ResizeDirection
{
    Resize_E,
    Resize_N,
    Resize_NE,
    Resize_NW,
    Resize_S,
    Resize_SW,
    Resize_SE,
    Resize_W
}

/// <summary>
/// Descendent of the System.Windows.Window class which adds a customizable toolbar and eventing to help the ViewModels.
/// </summary>
public class MoveableWindow : Window
{
    private static IntPtr _currentMonitor;
    private Border? _mainBorder;
    private ContentControl? _moveControl;
    private bool _isMoving = false;
    private Point _moveStartPoint;
    private DateTime _mouseLeftButtonDownTime = default;
    private readonly TimeSpan _mouseDoubleClickTime;
    private MoveableWindowViewModel? _viewModel = null;


    /// <summary>
    /// Initializes the MoveableWindowClass
    /// </summary>
    public MoveableWindow()
    {
        DataContextChanged += (_, args) =>
        {

            if (DataContext is not MoveableWindowViewModel w)
            {
                throw new InvalidOperationException("The DataContext for a MoveableWindow must MoveableWindow");
            }

            _viewModel = w;

            // Register for the Property Changed events
            w.PropertyChanged += ViewModelPropertyChanged;
        };

        Loaded += MoveableWindow_Loaded;
        LocationChanged += MoveableWindow_LocationChanged;
        CloseCommand = new RelayCommand(() => Close(), () => Closeable);
        MinimizeCommand = new RelayCommand(() => WindowState = WindowState.Minimized, () => WindowState != WindowState.Minimized);
        MaximizeCommand = new RelayCommand(() => WindowState = WindowState.Maximized, () => WindowState != WindowState.Maximized);
        OverlapCommand = new RelayCommand(() => WindowState = WindowState.Normal, () => WindowState == WindowState.Maximized);

        _mouseDoubleClickTime = TimeSpan.FromMilliseconds(NativeHelpers.GetDoubleClickTime());
    }

    /// <summary>
    /// Called when the WindowState changes. If overridden should call base.OnStateChanged.
    /// </summary>
    /// <param name="e"></param>
    protected override void OnStateChanged(EventArgs e)
    {
        (MaximizeCommand as IRelayCommand)?.NotifyCanExecuteChanged();
        (OverlapCommand as IRelayCommand)?.NotifyCanExecuteChanged();
    }

    private void SetMaxHeight()
    {
        var info = new NativeHelpers.MonitorInfo();
        info.MonitorRect.Right = 100;
        info.MonitorRect.Left = 10;

        NativeHelpers.GetMonitorInfo(_currentMonitor, out info);

        if (_mainBorder != null)
        {
            // JMW - We need to account for both the width of the border and the border frame for a non-resizable
            // window. When maximized DWM will position the Window so those are accounted for and off the screen.
            var frameWidth = NativeHelpers.GetSystemMetrics(NativeHelpers.SM_CXBORDER);
            var frameHeight = NativeHelpers.GetSystemMetrics(NativeHelpers.SM_CYBORDER);

            var resizeWidth = NativeHelpers.GetSystemMetrics(NativeHelpers.SM_CXFIXEDFRAME);
            var resizeHeight = NativeHelpers.GetSystemMetrics(NativeHelpers.SM_CYFIXEDFRAME);

            MaxHeight = info.WorkRect.Bottom - info.WorkRect.Top + 2 * resizeHeight + 2 * frameHeight;
            MaxWidth = info.WorkRect.Right - info.WorkRect.Left + 2 * resizeWidth + 2 * frameWidth;
        }
    }

    private void MoveableWindow_LocationChanged(object? sender, EventArgs e)
    {
        var monitor = NativeHelpers.MonitorFromWindow(new WindowInteropHelper(this).EnsureHandle(), NativeHelpers.MONITOR_DEFAULTTONEAREST);
        if (monitor != _currentMonitor)
        {
            // Whenever we switch monitors our maximum width/height need to change based on the new monitor.
            _currentMonitor = monitor;
            SetMaxHeight();

        }
    }

    private readonly Dictionary<string, FrameworkElement?> _neededElements = new()
    {
        {"MainBorder", null },
        {"MoveControl", null },
        {"Resize_NW", null },
        {"Resize_NE", null },
        {"Resize_SE", null },
        {"Resize_SW", null },
        {"Resize_E", null },
        {"Resize_W", null },
        {"Resize_N", null },
        {"Resize_S", null },
    };

    private void EnumerateNamedVisualChildren(FrameworkElement root)
    {
        Dictionary<string, FrameworkElement> childMap = [];
        Queue<FrameworkElement> visuals = [];
        visuals.Enqueue(root);

        while (visuals.Count > 0)
        {
            var visual = visuals.Dequeue();

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(visual); i++)
            {
                // Retrieve child visual at specified index value.
                Visual childVisual = (Visual)VisualTreeHelper.GetChild(visual, i);

                if (childVisual is FrameworkElement element)
                {
                    if (element.Name.Length > 0 && _neededElements.ContainsKey(element.Name))
                    {
                        _neededElements[element.Name] = element;
                    }

                    visuals.Enqueue((FrameworkElement)childVisual);
                }
            }
        }
    }

    /// <summary>
    /// Overridable method called when the Window is loaded.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <exception cref="InvalidOperationException"></exception>
    protected virtual void MoveableWindow_Loaded(object sender, RoutedEventArgs e)
    {
        EnumerateNamedVisualChildren(this);

        _mainBorder = _neededElements["MainBorder"] as Border;
        if (_mainBorder == null)
        {
            throw new InvalidOperationException("MainBorder was not found, invalid MoveableWindowBaseStyle");
        }

        _mainBorder.SizeChanged += MainBorder_SizeChanged;

        _moveControl = _neededElements["MoveControl"] as ContentControl;
        if (_moveControl == null)
        {
            throw new InvalidOperationException("_moveControl was not found, invalid MoveableWindowBaseStyle");
        }

        // Register for the events we need on the move control
        _moveControl.MouseMove += MoveControl_MouseMove;
        _moveControl.MouseLeftButtonDown += MoveControl_MouseLeftButtonDown;
        _moveControl.MouseLeftButtonUp += MoveControl_MouseLeftButtonUp;
        _moveControl.MouseDoubleClick += MoveControl_MouseDoubleClick;

        // Now also find the resize borders and register for their events also.
        foreach (var (k, v) in _neededElements.Where(kvp => kvp.Key.StartsWith("Resize_", StringComparison.InvariantCultureIgnoreCase)))
        {
            if (v != null)
            {
                v.MouseLeftButtonDown += ResizeBorder_OnMouseLeftButtonDown;
                v.MouseLeftButtonUp += ResizeBorder_OnMouseLeftButtonUp;
                v.MouseMove += ResizeBorder_OnMouseMove;
            }
        }

        var monitor = NativeHelpers.MonitorFromWindow(new WindowInteropHelper(this).EnsureHandle(), NativeHelpers.MONITOR_DEFAULTTONEAREST);
        if (monitor != _currentMonitor)
        {
            _currentMonitor = monitor;
            SetMaxHeight();
        }

        if (DataContext is MoveableWindowViewModel w)
        {
            w.OnLoaded();
        }
    }

    private void ViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == "CloseWindow")
        {
            Close();
        }
    }

    /// <summary>
    /// Calls the OnClosing method of MoveableWindowViewModel
    /// </summary>
    /// <param name="e"></param>
    protected override void OnClosing(CancelEventArgs e)
    {
        _viewModel?.OnClosing(e);
        base.OnClosing(e);
    }

    /// <summary>
    /// Calls the OnClosed method of the MoveableWindowViewModel
    /// </summary>
    /// <param name="e"></param>
    protected override void OnClosed(EventArgs e)
    {
        _viewModel?.OnClosed(e);
        base.OnClosed(e);
    }

    private void MoveControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
    {
        // Ignore the double clicks if the window is not resizable.
        if (Resizable)
        {
            WindowState = WindowState == WindowState.Normal ? WindowState.Maximized : WindowState.Normal;
        }
    }

    private void MoveControl_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        if (_isMoving)
        {
            _isMoving = false;
            _moveControl?.ReleaseMouseCapture();
        }
    }

    private void MoveControl_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        var currentTime = DateTime.Now;

        if (WindowState == WindowState.Normal && (currentTime - _mouseLeftButtonDownTime) > _mouseDoubleClickTime)
        {
            _moveStartPoint = Mouse.GetPosition(_moveControl);

            // If we are clicked in the top few pixels of the Window then show a thin border
            // and change the cursor
            _moveControl?.CaptureMouse();
            _isMoving = true;
        }

        _mouseLeftButtonDownTime = currentTime;
    }

    private void MoveControl_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
    {
        var position = Mouse.GetPosition(_moveControl);

        if (_isMoving && Mouse.LeftButton == MouseButtonState.Pressed)
        {
            Left += (position.X - _moveStartPoint.X);
            Top += (position.Y - _moveStartPoint.Y);
        }
    }

    private void MainBorder_SizeChanged(object sender, SizeChangedEventArgs e)
    {
    }

    #region DependencyProperties
    /// <summary>
    /// This property enables a window to be resizable. Set it to false if you don't want the window to allow
    /// resizing.
    /// </summary>
    public bool Resizable
    {
        get { return (bool)GetValue(ResizableProperty); }
        set { SetValue(ResizableProperty, value); }
    }

    /// <summary>
    /// Resizable DependencyProperty registration.
    /// </summary>
    public static readonly DependencyProperty ResizableProperty =
        DependencyProperty.Register("Resizable", typeof(bool), typeof(MoveableWindow), new PropertyMetadata(true));

    /// <summary>
    /// This property enables a window to be closable. By default a window is closable.
    /// </summary>
    public bool Closeable
    {
        get { return (bool)GetValue(CloseableProperty); }
        set { SetValue(CloseableProperty, value); }
    }

    /// <summary>
    /// The dependency property for Closable.
    /// </summary>
    public static readonly DependencyProperty CloseableProperty =
        DependencyProperty.Register("Closeable", typeof(bool), typeof(MoveableWindow), new PropertyMetadata(true));

    public ICommand? CloseCommand
    {
        get { return (ICommand)GetValue(CloseCommandProperty); }
        set { SetValue(CloseCommandProperty, value); }
    }

    public static readonly DependencyProperty CloseCommandProperty =
        DependencyProperty.Register("CloseCommand", typeof(ICommand), typeof(MoveableWindow), new PropertyMetadata(null));

    public ICommand? MinimizeCommand
    {
        get { return (ICommand)GetValue(MinimizeCommandProperty); }
        set { SetValue(MinimizeCommandProperty, value); }
    }

    public static readonly DependencyProperty MinimizeCommandProperty =
        DependencyProperty.Register("MinimizeCommand", typeof(ICommand), typeof(MoveableWindow), new PropertyMetadata(null));

    public ICommand? MaximizeCommand
    {
        get { return (ICommand)GetValue(MaximizeCommandProperty); }
        set { SetValue(MaximizeCommandProperty, value); }
    }

    public static readonly DependencyProperty MaximizeCommandProperty =
        DependencyProperty.Register("MaximizeCommand", typeof(ICommand), typeof(MoveableWindow), new PropertyMetadata(null));

    public ICommand? OverlapCommand
    {
        get { return (ICommand)GetValue(OverlapCommandProperty); }
        set { SetValue(OverlapCommandProperty, value); }
    }

    public static readonly DependencyProperty OverlapCommandProperty =
        DependencyProperty.Register("OverlapCommand", typeof(ICommand), typeof(MoveableWindow), new PropertyMetadata(null));
    #endregion

    #region WindowResizeRegion
    //
    // TODO - JMW I really want to switch to using all paths and then have a custom path control that exposes a dependency property
    // for the Resize direction. That is fit and finish so I won't worry about it right now.
    //
    private Point? _sizeStartPos = null;
    private Point? _lastMousePos = null; 
    private NativeHelpers.Rect _mainWindowSizeStartRect;
    private ResizeDirection _sizeResizeDirection = ResizeDirection.Resize_E;

    private void ResizeBorder_OnMouseLeftButtonDown(object _, MouseEventArgs? e)
    {
        ArgumentNullException.ThrowIfNull(e);
        var sender = e.Source as FrameworkElement;
        ArgumentNullException.ThrowIfNull(sender);

        _sizeResizeDirection = (ResizeDirection)Enum.Parse(typeof(ResizeDirection), sender.Name);

        IntPtr windowHandle =
           new WindowInteropHelper(this).Handle;
        if (NativeHelpers.GetWindowRect(windowHandle, ref _mainWindowSizeStartRect))
        {
            sender.CaptureMouse();
            _sizeStartPos = sender.PointToScreen(e.GetPosition(sender));
        }

        e.Handled = true;
    }

    private void ResizeBorder_OnMouseLeftButtonUp(object _, MouseEventArgs? e)
    {
        ArgumentNullException.ThrowIfNull(e);
        var sender = e.Source as FrameworkElement;
        ArgumentNullException.ThrowIfNull(sender);
        if (_sizeStartPos != null)
        {
            sender.ReleaseMouseCapture();
            _sizeStartPos = null;
        }

        e.Handled = true;
    }

    private void ResizeBorder_OnMouseMove(object _, MouseEventArgs? e)
    {
        ArgumentNullException.ThrowIfNull(e);

        if (_sizeStartPos != null)
        {
            var sender = e.Source as FrameworkElement;
            ArgumentNullException.ThrowIfNull(sender);

            Point currentPos = sender.PointToScreen(e.GetPosition(sender));
            if (_lastMousePos != null && currentPos != _lastMousePos) { }
            double yDiff = currentPos.Y - _sizeStartPos.Value.Y;
            double xDiff = currentPos.X - _sizeStartPos.Value.X;
            IntPtr windowHandle =
                new WindowInteropHelper(this).Handle;

            NativeHelpers.Rect newRect = _mainWindowSizeStartRect;

            switch (_sizeResizeDirection)
            {
                case ResizeDirection.Resize_N:
                    if (yDiff != 0)
                    {
                        newRect.Top += (int)yDiff;
                        NativeHelpers.SetWindowPos(windowHandle, newRect);
                    }

                    break;

                case ResizeDirection.Resize_S:
                    if (yDiff != 0)
                    {
                        newRect.Bottom += (int)yDiff;
                        NativeHelpers.SetWindowPos(windowHandle, newRect, NativeHelpers.SWP_NOMOVE);
                    }
                    break;

                case ResizeDirection.Resize_W:
                    Debug.WriteLine($"XDiff = {xDiff}, CX = {newRect.Right - newRect.Left + 1}");
                    if (xDiff != 0)
                    {
                        newRect.Left += (int)xDiff;
                        Debug.WriteLine($"NewRect Left = {newRect.Left}, Cx = {newRect.Right - newRect.Left + 1}");
                        NativeHelpers.SetWindowPos(windowHandle, newRect);
                    }
                    break;

                case ResizeDirection.Resize_E:
                    if (xDiff != 0)
                    {
                        newRect.Right += (int)xDiff;
                        NativeHelpers.SetWindowPos(windowHandle, newRect, NativeHelpers.SWP_NOMOVE);
                    }
                    break;

                case ResizeDirection.Resize_NW:
                    if (xDiff == 0)
                    {
                        goto case ResizeDirection.Resize_N;
                    }

                    if (yDiff == 0)
                    {
                        goto case ResizeDirection.Resize_W;
                    }

                    // Otherwise we are moving in both directions. Do a SetWindowPos so we only move once.
                    {
                        newRect.Left += (int)xDiff;
                        newRect.Top += (int)yDiff;
                        NativeHelpers.SetWindowPos(windowHandle, newRect);
                    }
                    break;

                case ResizeDirection.Resize_SW:
                    if (xDiff == 0)
                    {
                        goto case ResizeDirection.Resize_S;
                    }

                    if (yDiff == 0)
                    {
                        goto case ResizeDirection.Resize_W;
                    }

                    {
                        newRect.Left += (int)xDiff;
                        newRect.Bottom += (int)yDiff;
                        NativeHelpers.SetWindowPos(windowHandle, newRect);
                    }

                    break;

                case ResizeDirection.Resize_NE:
                    if (xDiff == 0)
                    {
                        goto case ResizeDirection.Resize_N;
                    }

                    if (yDiff == 0)
                    {
                        goto case ResizeDirection.Resize_E;
                    }

                    {
                        newRect.Right += (int)xDiff;
                        newRect.Top += (int)yDiff;
                        NativeHelpers.SetWindowPos(windowHandle, newRect);
                    }

                    break;

                case ResizeDirection.Resize_SE:
                    if (xDiff == 0)
                    {
                        goto case ResizeDirection.Resize_N;
                    }

                    if (yDiff == 0)
                    {
                        goto case ResizeDirection.Resize_E;
                    }

                    {
                        newRect.Right += (int)xDiff;
                        newRect.Bottom += (int)yDiff;
                        NativeHelpers.SetWindowPos(windowHandle, newRect, NativeHelpers.SWP_NOMOVE);
                    }

                    break;
            }
        }

        e.Handled = true;
    }
    #endregion
}
