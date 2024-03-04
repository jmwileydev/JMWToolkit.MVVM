/*
 * Copyright (c) 2023, J.M. Wiley
All rights reserved.

This source code is licensed under the BSD-style license found in the
LICENSE file in the root directory of this source tree. 
*/
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

namespace JMWToolkit.MVVM.ViewModels;

/// <summary>
/// My personal ViewModelBase class. It implements INotifyPropertyChanged like most others.
/// On top of that is adds commands to create RelayCommand's and AsyncRelayCommands. These
/// methods take an optional list of properties that will cause the NotifyCanExecuteChanged
/// method to be called.
/// </summary>
public class ViewModelBase : ObservableObject
{
    private readonly Dictionary<string, List<IRelayCommand>> _propertiesToCommands = new();

    /// <summary>
    /// Override the base OnPropertyChanged so that we can Notify the affected commands
    /// </summary>
    /// <param name="e"></param>
    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e.PropertyName);

        if (e.PropertyName != null && _propertiesToCommands.TryGetValue(e.PropertyName, out List<IRelayCommand>? commands))
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
    /// Helper function to create an AsyncRelayCommand for the ViewModel. The ViewModelBase will call NotifyCanExecuteChanged
    /// when one of the supplied properties changes.
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

    /// <summary>
    /// Helper function to create an AsyncRelayCommand for the ViewModel. The ViewModelBase will call NotifyCanExecuteChanged
    /// when one of the supplied properties changes.
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

    /// <summary>
    /// Helper function to create an RelayCommand for the ViewModel. The ViewModelBase will call NotifyCanExecuteChanged
    /// when one of the supplied properties changes.
    /// </summary>
    /// <param name="execute">Function to be executed when command is clicked.</param>
    /// <param name="canExecute">Function to determine if the command should be enabled.</param>
    /// <param name="properties">List of properties which can cause the result of canExecute to change.</param>
    /// <returns>A new RelayCommand</returns>
    public RelayCommand CreateRelayCommand(Action execute, Func<bool> canExecute, params string[] properties)
    {
        var command = new RelayCommand(execute, canExecute);
        AddPropertiesAndCommands(command, properties);
        return command;
    }

    /// <summary>
    /// Helper function to create an RelayCommand for the ViewModel. The ViewModelBase will call NotifyCanExecuteChanged
    /// when one of the supplied properties changes.
    /// </summary>
    /// <param name="execute">Function to be executed when command is clicked.</param>
    /// <param name="canExecute">Function to determine if the command should be enabled.</param>
    /// <param name="properties">List of properties which can cause the result of canExecute to change.</param>
    /// <returns>A new RelayCommand</returns>
    public RelayCommand<T> CreateRelayCommand<T>(Action<T?> execute, Predicate<T?> canExecute, params string[] properties)
    {
        var command = new RelayCommand<T>(execute, canExecute);
        AddPropertiesAndCommands(command, properties);
        return command;
    }
}



