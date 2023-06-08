/*
 * Copyright (c) 2023, J.M. Wiley
All rights reserved.

This source code is licensed under the BSD-style license found in the
LICENSE file in the root directory of this source tree. 
*/
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace JMWToolkit.MVVM.ViewModels;

/// <summary>
/// My personal ViewModelBase class. It implements INotifyPropertyChanged like most others.
/// On top of that is adds commands to create RelayCommand's and AsyncRelayCommands. These
/// methods take an optional list of properties that will cause the NotifyCanExecuteChanged
/// method to be called.
/// </summary>
public class ViewModelBase : INotifyPropertyChanged
{
    private readonly Dictionary<string, List<IRelayCommand>> _propertiesToCommands = new();

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        if (propertyName != null && _propertiesToCommands.TryGetValue(propertyName, out List<IRelayCommand>? commands))
        {
            foreach (var command in commands)
            {
                command.NotifyCanExecuteChanged();
            }
        }
    }
    private void AddPropertiesAndCommands(IRelayCommand command, string[] properties)
    {
        foreach (var property in properties)
        {
            if (!_propertiesToCommands.ContainsKey(property))
            {
                _propertiesToCommands[property] = new();
            }

            _propertiesToCommands[property].Add(command);
        }
    }

    /// <summary>
    /// Creates an AsyncRelayCommand for the ViewModel. The set of properties is used by the ViewModelBase to
    /// determine when NotifyCanExcecuteChanged shoudl be called.
    /// </summary>
    /// <param name="execute">Function to be executed when command is clicked.</param>
    /// <param name="canExecute">Function to determine if the command should be enabled.</param>
    /// <param name="properties">List of properties which can cause the result of canExecute to change.</param>
    /// <returns>A new AsyncRelayCommand</returns>
    public AsyncRelayCommand CreateAsyncRelayCommand(Func<Task> execute, Func<bool> canExecute, params string[] properties)
    {
        var command = new AsyncRelayCommand(execute, canExecute);
        AddPropertiesAndCommands(command, properties);
        return command;
    }

    public AsyncRelayCommand CreateAsyncRelayCommand(Func<Task> execute, params string[] properties)
    {
        var command = new AsyncRelayCommand(execute);
        AddPropertiesAndCommands(command, properties);
        return command;
    }

    /// <summary>
    /// Creates an AsyncRelayCommand for the ViewModel. The set of properties is used by the ViewModelBase to
    /// determine when NotifyCanExcecuteChanged shoudl be called. This is the generic version for a Task which
    /// returns a type.
    /// </summary>
    /// <param name="execute">Function to be executed when command is clicked.</param>
    /// <param name="canExecute">Function to determine if the command should be enabled.</param>
    /// <param name="properties">List of properties which can cause the result of canExecute to change.</param>
    /// <returns>A new AsyncRelayCommand</returns>
    public AsyncRelayCommand<T> CreateAsyncRelayCommand<T>(Func<T?, Task> execute, Predicate<T?> canExecute, params string[] properties)
    {
        var command = new AsyncRelayCommand<T>(execute, canExecute);
        AddPropertiesAndCommands(command, properties);
        return command;
    }

    public AsyncRelayCommand<T> CreateAsyncRelayCommand<T>(Func<T?, Task> execute, params string[] properties)
    {
        var command = new AsyncRelayCommand<T>(execute);
        AddPropertiesAndCommands(command, properties);
        return command;
    }

    public RelayCommand CreateRelayCommand(Action execute, Func<bool> canExecute, params string[] properties)
    {
        var command = new RelayCommand(execute, canExecute);
        AddPropertiesAndCommands(command, properties);
        return command;
    }

    public RelayCommand CreateRelayCommand(Action execute, params string[] properties)
    {
        var command = new RelayCommand(execute);
        AddPropertiesAndCommands(command, properties);
        return command;
    }

    public RelayCommand<T> CreateRelayCommand<T>(Action<T?> execute, Predicate<T?> canExecute, params string[] properties)
    {
        var command = new RelayCommand<T>(execute, canExecute);
        AddPropertiesAndCommands(command, properties);
        return command;
    }

    public RelayCommand<T> CreateRelayCommand<T>(Action<T?> execute, params string[] properties)
    {
        var command = new RelayCommand<T>(execute);
        AddPropertiesAndCommands(command, properties);
        return command;
    }
}



