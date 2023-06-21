using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;
using System.Windows;

namespace JMWToolkit.MVVM;

/// TODO - This class is still under construction.

/// <summary>
/// This class can be used to find a service configured by the app.
/// </summary>
public class AppServiceLocator
{
    /// <summary>
    /// Queries the AppHost and returns the configured service
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public T? GetConfiguredService<T>() where T : class
    {
        return AppBase.GetConfiguredService<T>();
    }
}

/// <summary>
/// This is a helper class for locating ViewModel's that are registered with 
/// </summary>
public abstract class AppBase : Application
{
    /// <summary>
    /// If the AppHost has been configured during construction this routine will call StaryAsync.
    /// </summary>
    protected static Task StartAppHost()
    {
        if (AppHost != null)
        {
            return AppHost.StartAsync();
        }

        return Task.CompletedTask;
    }

    /// <summary>
    /// If the AppHost has been configured during construction this will call StopAsync.
    /// </summary>
    protected static Task StopAppHost()
    {
        if (AppHost != null)
        {
            return AppHost.StopAsync();
        }

        return Task.CompletedTask;
    }

    /// <summary>
    /// Get the AppHost for the Application
    /// </summary>
    public static IHost? AppHost { get; private set; }

    /// <summary>
    /// Constructor for the AppBase will call configure services for dependency injection
    /// </summary>
    public AppBase(Action<IServiceCollection> configureDelegate)
    {
            AppHost = Host.CreateDefaultBuilder().ConfigureServices(configureDelegate).Build();
    }

    /// <summary>
    /// Get's a configured service from the AppHost if it was created during construction.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T? GetConfiguredService<T>() where T : class
    {
        if (AppHost != null)
        {
            return AppHost.Services.GetRequiredService<T>();
        }
        else
        {
            return null;
        }
    }
}
