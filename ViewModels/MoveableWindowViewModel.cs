using System;
using System.ComponentModel;

namespace JMWToolkit.MVVM.ViewModels;

/// <summary>
/// This is the ViewModel for the MoveableWindow class
/// </summary>
public class MoveableWindowViewModel : ViewModelBase
{
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
