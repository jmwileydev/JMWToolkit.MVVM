using System;
using System.ComponentModel;

namespace JMWToolkit.MVVM.ViewModels;

/// <summary>
/// This is the ViewModel for the MoveableWindow class
/// </summary>
public class MoveableWindowViewModel : ViewModelBase
{
    private bool _resizable = true;
    /// <summary>
    /// Property specifying whether the window should be allowed to resize.
    /// </summary>
    public bool Resizable
    {
        get => _resizable;
        set => SetProperty(ref _resizable, value);
    }

    private bool _closeable = true;
    /// <summary>
    /// Property specifying whether the window should enable the close button.
    /// </summary>
    public bool Closeable
    {
        get => _closeable;
        set => SetProperty(ref _closeable, value);
    }

    /// <summary>
    /// Called when the Window is Loaded. If overridden base OnLoaded should be called.
    /// </summary>
    protected internal virtual void OnLoaded()
    {
    }

    /// <summary>
    /// Called when the Window is attempting to close. If overridden the base OnClosing should be called.
    /// </summary>
    /// <param name="closingEventArgs"></param>
    protected internal virtual void OnClosing(CancelEventArgs closingEventArgs)
    {
    }

    /// <summary>
    /// Called when the Window is closed. If overridden the base OnClosing should be called.
    /// </summary>
    /// <param name="eventArgs"></param>
    protected internal virtual void OnClosed(EventArgs eventArgs)
    {
    }


}
