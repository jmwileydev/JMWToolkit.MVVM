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

        List<IRelayCommand>? commands = null;
        if (propertyName != null && _propertiesToCommands.TryGetValue(propertyName, out commands))
        {
            foreach(var command in commands)
            {
                command.NotifyCanExecuteChanged();
            }
        }
    }

    public AsyncRelayCommand CreateAsyncRelayCommand(Func<Task> execute, Func<bool> canExecute, params string[] properties)
    {
        var command = new AsyncRelayCommand(execute, canExecute);
        AddPropertiesAndCommands(command, properties);
        return command;
    }

    public AsyncRelayCommand<T> CreateAsyncRelayCommand<T>(Func<T?, Task> execute, Predicate<T?> canExecute, params string[] properties)
    {
        var command = new AsyncRelayCommand<T>(execute, canExecute);
        AddPropertiesAndCommands(command, properties);
        return command;
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

    public RelayCommand CreateRelayCommand(Action execute, Func<bool> canExecute, params string[] properties)
    {
        var command = new RelayCommand(execute, canExecute);
        AddPropertiesAndCommands(command, properties);
        return command;
    }

    public RelayCommand<T> CreateRelayCommand<T>(Action<T?> execute, Predicate<T?> canExecute, params string[] properties)
    {
        var command = new RelayCommand<T>(execute, canExecute);
        AddPropertiesAndCommands(command, properties);
        return command;
    }
}



