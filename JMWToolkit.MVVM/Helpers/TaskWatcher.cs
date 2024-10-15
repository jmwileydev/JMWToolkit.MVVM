using JMWToolkit.MVVM.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace JMWToolkit.MVVM.Helpers;

/// <summary>
/// This is a base class for a TaskWatcher. It has some common members, properties and methods.
/// </summary>
/// <param name="dispatcher"></param>
/// <param name="cancellationToken"></param>
public abstract class TaskWatcherBase(IDispatcher dispatcher, CancellationToken? cancellationToken = null)
{
    /// <summary>
    /// The cancellationToken used to cancel the task.
    /// </summary>
    protected readonly CancellationToken? _cancellationToken = cancellationToken;

    /// <summary>
    /// The Dispatcher interface for the application.
    /// </summary>
    protected readonly IDispatcher _dispatcher = dispatcher;

    /// <summary>
    /// An object used to synchronize access to the member variables and used to when waiting for the task
    /// to complete.
    /// </summary>
    protected readonly Object _monitorObject = new();

    private bool _isCompleted = false;
    /// <summary>
    /// True if the task completed.
    /// </summary>
    public bool IsCompleted
    {
        get => _isCompleted;
        protected set => _isCompleted = value;
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
        protected set => _exception = value;
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
public class TaskWatcher(IDispatcher dispatcher, Action action, CancellationToken? cancellationToken = null) : TaskWatcherBase(dispatcher, cancellationToken)
{
    private readonly Action _action = action;

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
}



/// <summary>
/// Provides data for the TaskWatcher OnCompleted Event.
/// </summary>
/// <param name="taskWatcher">The TaskWatcher the for the given task.</param>
/// <param name="result">The result, if successful, null if not.</param>
public class TaskWatcherEventArgs<TRet>(TaskWatcher<TRet> taskWatcher, TRet? result) : EventArgs
{
    /// <summary>
    /// Gets the TaskWatcher that has completed.
    /// </summary>
    public TaskWatcher<TRet> TaskWatcher => taskWatcher;

    /// <summary>
    /// The Result of the func call if successful.
    /// </summary>
    public TRet? Result => result;
}

/// <summary>
/// Runs an asynchronous Action and then calls the OnCompleted method on the UX thread when done. It always observes the
/// task so that the application will never see an UnobservedTaskException.
/// </summary>
/// <param name="dispatcher">The IDispatcher interface to be used.</param>
/// <param name="func">The function to be run.</param>
/// <param name="cancellationToken">The CancellationToken that will be monitored for a cancellation.</param>
public class TaskWatcher<TRet>(IDispatcher dispatcher, Func<TRet> func, CancellationToken? cancellationToken = null) : TaskWatcherBase(dispatcher, cancellationToken)
{
    private readonly Func<TRet> _func = func;

    /// <summary>
    /// EventHandler that will be called when the Action completes. It will always be called on the UX thread.
    /// </summary>
    public event EventHandler<TaskWatcherEventArgs<TRet>>? OnCompleted;

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

            TRet? result = default;
            try
            {
                result = _func();
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
                OnCompleted?.Invoke(this, new TaskWatcherEventArgs<TRet>(this, result));
            });

        }, _cancellationToken ?? new(), creationOptions);

        t.Start();
    }
}

/// <summary>
/// Provides data for the TaskWatcher OnCompleted Event.
/// </summary>
/// <param name="taskWatcher">The TaskWatcher the for the given task.</param>
/// <param name="inputArgs">The arguments passed to the task function.</param>
/// <param name="result">The result, if successful, null if not.</param>
public class TaskWatcherEventArgs<TIn, TRet>(TaskWatcher<TIn, TRet> taskWatcher, TIn inputArgs, TRet? result) : EventArgs
{
    /// <summary>
    /// Gets the TaskWatcher that has completed.
    /// </summary>
    public TaskWatcher<TIn, TRet> TaskWatcher => taskWatcher;

    /// <summary>
    /// The Result of the func call if successful.
    /// </summary>
    public TRet? Result => result;

    /// <summary>
    /// The input args passed to Start.
    /// </summary>
    public TIn InputArgs => inputArgs;
}

/// <summary>
/// Runs an asynchronous Action and then calls the OnCompleted method on the UX thread when done. It always observes the
/// task so that the application will never see an UnobservedTaskException.
/// </summary>
/// <param name="dispatcher">The IDispatcher interface to be used.</param>
/// <param name="func">The function to be run.</param>
/// <param name="cancellationToken">The CancellationToken that will be monitored for a cancellation.</param>
public class TaskWatcher<TIn, TRet>(IDispatcher dispatcher, Func<TIn, TRet> func, CancellationToken? cancellationToken = null) : TaskWatcherBase(dispatcher, cancellationToken)
{
    private readonly Func<TIn, TRet> _func = func;

    /// <summary>
    /// EventHandler that will be called when the Action completes. It will always be called on the UX thread.
    /// </summary>
    public event EventHandler<TaskWatcherEventArgs<TIn, TRet>>? OnCompleted;

    /// <summary>
    /// Starts the task and returns immediately.
    /// </summary>
    /// <param name="inputArgs">The input arguments to be passed to the called task function.</param>
    /// <param name="longRunning"></param>
    public void Start(TIn inputArgs, bool longRunning = false)
    {
        TaskCreationOptions creationOptions = longRunning ? TaskCreationOptions.LongRunning : TaskCreationOptions.None;
        Task t = new(() =>
        {
            _cancellationToken?.ThrowIfCancellationRequested();

            TRet? result = default;
            try
            {
                result = _func(inputArgs);
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
                OnCompleted?.Invoke(this, new TaskWatcherEventArgs<TIn, TRet>(this, inputArgs, result));
            });

        }, _cancellationToken ?? new(), creationOptions);

        t.Start();
    }
}
