using JMWToolkit.MVVM.Helpers;
using JMWToolkit.MVVM.Interfaces;

namespace JMWToolkit.MVVM.UnitTests;

[TestClass]
public sealed class TaskWatcherTests : IDispatcher
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    public TestContext TestContext { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

    public void BeginInvoke(Delegate method, params object[] args)
    {
        method.DynamicInvoke(args);
    }

    [TestMethod]
    public void TestTaskThatShouldSucceed()
    {
        AsyncLock asyncLock = new(true);

        TestContext.WriteLine("Running a task which will sleep for 2 seconds and then complete successfully.");

        TaskWatcher taskWatcher = new(
            this,
            () =>
            {
                Thread.Sleep(2000);
            });
        taskWatcher.OnCompleted += (e, args) =>
        {
            asyncLock.Release();
        };

        taskWatcher.Start();
        Assert.IsTrue(asyncLock.Wait(TimeSpan.FromSeconds(5)), "Timed out waiting for task to complete.");
        Assert.IsFalse(taskWatcher.IsCanceled);
        Assert.IsFalse(taskWatcher.IsFaulted);
        Assert.IsNull(taskWatcher.Exception);
        Assert.IsTrue(taskWatcher.IsCompleted);
    }

    private class FaultException : Exception
    {

    }

    [TestMethod]
    public void TestTaskThatShouldFault()
    {
        AsyncLock asyncLock = new(true);

        TestContext.WriteLine("Running a task which should throw a FaultException.");

        TaskWatcher taskWatcher = new(
            this,
            () =>
            {
                throw new FaultException();
            });
        taskWatcher.OnCompleted += (e, args) =>
        {
            asyncLock.Release();
        };

        taskWatcher.Start();
        Assert.IsTrue(asyncLock.Wait(TimeSpan.FromSeconds(5)), "Timed out waiting for task to complete.");
        Assert.IsFalse(taskWatcher.IsCanceled);
        Assert.IsTrue(taskWatcher.IsFaulted);
        Assert.IsNotNull(taskWatcher.Exception);
        Assert.IsTrue(taskWatcher.IsCompleted);
    }

    [TestMethod]
    public async Task TestTaskThatShouldBeCanceled()
    {
        AsyncLock asyncLock = new(true);

        TestContext.WriteLine("Running a task which I will cancel after two seconds.");

        CancellationTokenSource cancellationTokenSource = new();
        CancellationToken cancellationToken = cancellationTokenSource.Token;

        TaskWatcher taskWatcher = new(
            this,
            () =>
            {
                // Wait 5 seconds to see if we are canceled.
                cancellationToken.WaitHandle.WaitOne(5000);
                cancellationToken.ThrowIfCancellationRequested();
            }, cancellationToken);
        taskWatcher.OnCompleted += (e, args) =>
        {
            asyncLock.Release();
        };

        taskWatcher.Start();
        await Task.Delay(2000);
        cancellationTokenSource.Cancel();
        Assert.IsTrue(asyncLock.Wait(TimeSpan.FromSeconds(5)), "Timed out waiting for task to complete.");
        Assert.IsTrue(taskWatcher.IsCanceled);
        Assert.IsTrue(taskWatcher.IsFaulted);
        Assert.IsNotNull(taskWatcher.Exception as OperationCanceledException);
        Assert.IsTrue(taskWatcher.IsCompleted);

    }

    [TestMethod]
    public void TestThatTheTaskWatcherCanBeWaitedOn()
    {
        TestContext.WriteLine("Running a task which I will simply wait on.");

        DateTime taskFinishTime = DateTime.MinValue;
        TaskWatcher taskWatcher = new(
            this,
            () =>
            {
                Thread.Sleep(2000);
                taskFinishTime = DateTime.UtcNow;
            });

        taskWatcher.Start();
        taskWatcher.Wait();

        DateTime waitFinishTime = DateTime.UtcNow;
        Assert.IsFalse(taskWatcher.IsCanceled);
        Assert.IsFalse(taskWatcher.IsFaulted);
        Assert.IsNull(taskWatcher.Exception);
        Assert.IsTrue(taskWatcher.IsCompleted);
        Assert.IsTrue(waitFinishTime > taskFinishTime);

    }

    [TestMethod]
    public void TestTaskThatSuccessfullyReturnsAValue()
    {
        AsyncLock asyncLock = new(true);

        TestContext.WriteLine("Running a task which will succeed and return a value.");
        Guid returnValue = Guid.NewGuid();

        TaskWatcher<Guid> taskWatcher = new(
            this,
            () =>
            {
                Thread.Sleep(2000);
                return returnValue;
            });

        taskWatcher.OnCompleted += (e, args) =>
        {
            TaskWatcher<Guid> taskWatcher = args.TaskWatcher;
            Assert.IsTrue(taskWatcher.IsCompleted);
            Assert.AreEqual(returnValue, args.Result);
            asyncLock.Release();
        };

        taskWatcher.Start();
        Assert.IsTrue(asyncLock.Wait(TimeSpan.FromSeconds(5)));
        Assert.IsTrue(taskWatcher.IsCompleted);
        Assert.IsFalse(taskWatcher.IsCanceled);
        Assert.IsFalse(taskWatcher.IsFaulted);
        Assert.IsNull(taskWatcher.Exception);
        Assert.IsTrue(taskWatcher.IsCompleted);
    }

    [TestMethod]
    public void TestTaskWithInputArgsSuccessfullyReturnsAValue()
    {
        AsyncLock asyncLock = new(true);

        TestContext.WriteLine("Running a task which takes input, should succeed and returns a value.");
        Guid returnValue = Guid.NewGuid();
        Guid inputArgs = Guid.NewGuid();

        TaskWatcher<Guid, Guid> taskWatcher = new(
            this,
            (args) =>
            {
                Thread.Sleep(2000);
                Assert.AreEqual(inputArgs, args);
                return returnValue;
            });

        taskWatcher.OnCompleted += (e, args) =>
        {
            TaskWatcher<Guid, Guid> taskWatcher = args.TaskWatcher;
            Assert.IsTrue(taskWatcher.IsCompleted);
            Assert.AreEqual(returnValue, args.Result);
            Assert.AreEqual(inputArgs, args.InputArgs);
            asyncLock.Release();
        };

        taskWatcher.Start(inputArgs);
        Assert.IsTrue(asyncLock.Wait(TimeSpan.FromSeconds(5)));
        Assert.IsTrue(taskWatcher.IsCompleted);
        Assert.IsFalse(taskWatcher.IsCanceled);
        Assert.IsFalse(taskWatcher.IsFaulted);
        Assert.IsNull(taskWatcher.Exception);
        Assert.IsTrue(taskWatcher.IsCompleted);
    }
}
