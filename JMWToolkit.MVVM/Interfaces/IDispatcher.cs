using System;
using System.Windows.Threading;

namespace JMWToolkit.MVVM.Interfaces;

/// <summary>
/// The interface needed to interface properly with the application.
/// </summary>
public interface IDispatcher
{
    /// <summary>
    /// Executes a delegate asynchronously on the main application thread.
    /// </summary>
    /// <param name="method">The delegate method to be executed.</param>
    /// <param name="args">An array of objects to pass as arguments to the given method.</param>
    void BeginInvoke(Delegate method, params Object[] args);

    ///// <summary>
    ///// Executes a delegate asynchronously on the main application thread.
    ///// </summary>
    ///// <param name="method">The delegate method to be executed.</param>
    ///// <param name="priority">The priority, relative to the other pending operations in the Dispatcher event queue, with which the specified method is invoked.</param>
    ///// <param name="args">An array of objects to pass as arguments to the given method.</param>
    //void BeginInvoke(Delegate method, DispatcherPriority priority, params Object[] args);
}
