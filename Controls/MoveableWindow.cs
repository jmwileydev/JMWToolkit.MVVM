using CommunityToolkit.Mvvm.Input;
using JMWToolkit.MVVM.Helpers;
using JMWToolkit.MVVM.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;

namespace JMWToolkit.MVVM.Controls;

/// <summary>
/// Descendent of the System.Windows.Window class which adds a customizable toolbar and events to help the ViewModels.
/// </summary>
public class MoveableWindow : Window
{
    private static IntPtr _currentMonitor;
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
        SetValue(CloseCommandPropertyKey, new RelayCommand(() => Close(), () => Closeable));

        SetValue(MinimizeCommandPropertyKey,  new RelayCommand(() => WindowState = WindowState.Minimized, () => WindowState != WindowState.Minimized && ResizeMode != ResizeMode.NoResize));
        SetValue(MaximizeCommandPropertyKey, new RelayCommand(() => WindowState = WindowState.Maximized, () => WindowState != WindowState.Maximized && (ResizeMode == ResizeMode.CanResize || ResizeMode == ResizeMode.CanResizeWithGrip)));
        SetValue(OverlapCommandPropertyKey, new RelayCommand(() => WindowState = WindowState.Normal, () => WindowState == WindowState.Maximized && (ResizeMode == ResizeMode.CanResize || ResizeMode == ResizeMode.CanResizeWithGrip)));

        _mouseDoubleClickTime = TimeSpan.FromMilliseconds(NativeHelpers.GetDoubleClickTime());
    }

    /// <summary>
    /// Called when the WindowState changes. If overridden should call base.OnStateChanged.
    /// </summary>
    /// <param name="e"></param>
    protected override void OnStateChanged(EventArgs e)
    {
        MaximizeCommand?.NotifyCanExecuteChanged();
        OverlapCommand?.NotifyCanExecuteChanged();
    }

    /// <summary>
    /// Invoked whenever the effective value of any dependency property on this DependencyObject has been updated
    /// </summary>
    /// <param name="e"></param>
    protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e);

        if (e.Property.Name == "ResizeMode")
        {
            MinimizeCommand?.NotifyCanExecuteChanged();
            MaximizeCommand?.NotifyCanExecuteChanged();
            OverlapCommand?.NotifyCanExecuteChanged();
        }
    }

    private void SetMaxHeight()
    {
        var info = new NativeHelpers.MonitorInfo();
        info.MonitorRect.Right = 100;
        info.MonitorRect.Left = 10;

        _ = NativeHelpers.GetMonitorInfo(_currentMonitor, out info);
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
        {"MoveControl", null },
    };

    private void EnumerateNamedVisualChildren(FrameworkElement root)
    {
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

        _moveControl = _neededElements["MoveControl"] as ContentControl;
        if (_moveControl == null)
        {
            throw new InvalidOperationException("MoveControl was not found, invalid MoveableWindowBaseStyle");
        }

        // Register for the events we need on the move control
        _moveControl.MouseMove += MoveControl_MouseMove;
        _moveControl.MouseLeftButtonDown += MoveControl_MouseLeftButtonDown;
        _moveControl.MouseLeftButtonUp += MoveControl_MouseLeftButtonUp;
        _moveControl.MouseDoubleClick += MoveControl_MouseDoubleClick;

        if (DataContext is MoveableWindowViewModel w)
        {
            w.OnLoaded();
        }
    }

    private void ViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        switch(e.PropertyName)
        {
            case "CloseWindow":
                Close();
                break;

            case "Closeable":
                {
                    if (_viewModel != null)
                    {
                        Closeable = _viewModel.Closeable;
                    }

                    CloseCommand?.NotifyCanExecuteChanged();
                }
                break;
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
    internal static readonly DependencyProperty CloseableProperty =
        DependencyProperty.Register("Closeable", typeof(bool), typeof(MoveableWindow), new PropertyMetadata(true));

    /// <summary>
    /// Gets the CloseCommand which is used to close the window.
    /// </summary>
    public IRelayCommand CloseCommand
    {
        get { return (IRelayCommand)GetValue(CloseCommandPropertyKey.DependencyProperty); }
    }

    /// <summary>
    /// CloseCommand dependency property.
    /// </summary>
    public static readonly DependencyPropertyKey CloseCommandPropertyKey =
        DependencyProperty.RegisterReadOnly("CloseCommand", typeof(IRelayCommand), typeof(MoveableWindow), new FrameworkPropertyMetadata());

    /// <summary>
    /// Gets the minimize command which can be used to minimize the window.
    /// </summary>
    public IRelayCommand? MinimizeCommand
    {
        get { return (IRelayCommand)GetValue(MinimizeCommandPropertyKey.DependencyProperty); }
    }

    /// <summary>
    /// Dependency property for the MinimizeCommand
    /// </summary>
    internal static readonly DependencyPropertyKey MinimizeCommandPropertyKey =
        DependencyProperty.RegisterReadOnly("MinimizeCommand", typeof(IRelayCommand), typeof(MoveableWindow), new FrameworkPropertyMetadata());

    /// <summary>
    /// Gets the maximize command which can be used to minimize the window.
    /// </summary>
    public IRelayCommand? MaximizeCommand
    {
        get { return (IRelayCommand)GetValue(MaximizeCommandPropertyKey.DependencyProperty); }
    }

    /// <summary>
    /// Dependency property for the MaximizeCommand.
    /// </summary>
    internal static readonly DependencyPropertyKey MaximizeCommandPropertyKey =
        DependencyProperty.RegisterReadOnly("MaximizeCommand", typeof(IRelayCommand), typeof(MoveableWindow), new FrameworkPropertyMetadata());

    /// <summary>
    /// Gets the overlap command which can be used to restore the window.
    /// </summary>
    public IRelayCommand? OverlapCommand
    {
        get { return (IRelayCommand)GetValue(OverlapCommandPropertyKey.DependencyProperty); }
    }

    /// <summary>
    /// Dependency property for the OverlapCommand.
    /// </summary>
    internal static readonly DependencyPropertyKey OverlapCommandPropertyKey =
        DependencyProperty.RegisterReadOnly("OverlapCommand", typeof(IRelayCommand), typeof(MoveableWindow), new FrameworkPropertyMetadata());
    #endregion
}
