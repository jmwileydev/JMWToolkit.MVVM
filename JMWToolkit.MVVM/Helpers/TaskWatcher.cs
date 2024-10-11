using JMWToolkit.MVVM.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace JMWToolkit.MVVM.Helpers;

/// <summary>
/// Provides data for the TaskWatcher OnCompleted Event.
/// </summary>
/// <param name="taskWatcher"></param>
public class TaskWatcherEventArgs(TaskWatcher taskWatcher) : EventArgs
{
    /// <summary>
    /// Gets the TaskWatcher that has completed.
    /// </summary>
    public TaskWatcher TaskWatcher => taskWatcher;
}

/// <summary>
/// Runs an asynchronous Action and then calls the OnCompleted method on the UX thread when done. It always observes the
/// task so that the application will never see an UnobservedTaskException.
/// </summary>
/// <param name="dispatcher">The IDispatcher interface to be used.</param>
/// <param name="action">The action to run.</param>
/// <param name="cancellationToken">The CancellationToken that will be monitored for a cancellation.</param>
public class TaskWatcher(IDispatcher dispatcher, Action action, CancellationToken? cancellationToken = null)
{
    private readonly CancellationToken? _cancellationToken = cancellationToken;
    private readonly Action _action = action;
    private readonly IDispatcher _dispatcher = dispatcher;
    private readonly Object _monitorObject = new();

    private bool _isCompleted = false;
    /// <summary>
    /// True if the task completed.
    /// </summary>
    public bool IsCompleted
    {
        get => _isCompleted;
        private set => _isCompleted = value;
    }

    /// <summary>
    /// True if the task was cancelled.
    /// </summary>
    public bool IsCanceled => _cancellationToken != null && _cancellationToken.Value.IsCancellationRequested;

    /// <summary>
    /// True if the task thew an exception. If true then Exception will be non-null and contain the exception that was thrown.
    /// </summary>
    public bool IsFaulted => Exception != null;

    private Exception? _exception;
    /// <summary>
    /// Non-null if an exception was thrown during the Action.
    /// </summary>
    public Exception? Exception
    {
        get => _exception;
        set => _exception = value;
    }

    /// <summary>
    /// EventHandler that will be called when the Action completes. It will always be called on the UX thread.
    /// </summary>
    public event EventHandler<TaskWatcherEventArgs>? OnCompleted;

    /// <summary>
    /// Starts the task and returns immediately.
    /// </summary>
    /// <param name="longRunning"></param>
    public void Start(bool longRunning = false)
    {
        TaskCreationOptions creationOptions = longRunning ? TaskCreationOptions.LongRunning : TaskCreationOptions.None;
        Task t = new(() =>
        {
            _cancellationToken?.ThrowIfCancellationRequested();

            try
            {
                _action();
            }
            catch (Exception ex)
            {
                Exception = ex;
            }

            Monitor.Enter(_monitorObject);

            try
            {
                IsCompleted = true;
                Monitor.PulseAll(_monitorObject);
            }
            finally
            { 
                Monitor.Exit(_monitorObject);
            }

            _dispatcher.BeginInvoke(() =>
            {
                OnCompleted?.Invoke(this, new TaskWatcherEventArgs(this));
            });

        },  _cancellationToken ?? new(), creationOptions);

        t.Start();
    }

    /// <summary>
    /// Waits for the background task to complete.
    /// </summary>
    public void Wait()
    {
        Monitor.Enter(_monitorObject);

        try
        {
            while (!IsCompleted)
            {
                Monitor.Wait(_monitorObject);
            }
        }
        finally
        {
            if (Monitor.IsEntered(_monitorObject))
            {
                Monitor.Exit(_monitorObject);
            }
        }
        
    }
}

//public class TaskWatcher<TRet>
//{

//}

//public class TaskWatcher<T1, TRet>
//{

//}

//public class TaskWatcher<T1, TRet>
//{

//}
