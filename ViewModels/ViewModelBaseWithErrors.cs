using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Linq;

namespace JMWToolkit.MVVM.ViewModels;

/// <summary>
/// This is an extension of the ViewModelBase class that adds Error notifications.
/// </summary>
public class ViewModelBaseWithErrors : ViewModelBase, INotifyDataErrorInfo
{
    private readonly Dictionary<string, List<string>> _propertyErrors = [];

    /// <summary>
    /// Gets a value that indicates whether the entity has validation errors.
    /// </summary>
    public bool HasErrors => _propertyErrors.Values.Any((l) => l.Count > 0);

    /// <summary>
    /// Occurs when the validation errors have changed for a property or for the entire entity.
    /// </summary>
    public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

#pragma warning disable CS8603 // Old WPF interface declarations do not use Nullable.
    /// <summary>
    /// Gets the validation errors for a specified property or for the entire entity.
    /// </summary>
    /// <param name="propertyName">The name of the property to retrieve validation errors for; or null or Empty, to retrieve entity-level errors.</param>
    /// <returns>The validation errors for the property or entity.</returns>
    public IEnumerable GetErrors(string? propertyName)
    {
        if (!String.IsNullOrEmpty(propertyName) && _propertyErrors.TryGetValue(propertyName, out var errors))
        {
            return errors;
        }

        return null;
    }
#pragma warning restore CS8603 // Possible null reference return.

    /// <summary>
    /// Clears the validation errors for the specified property If no property is specified it clears away all
    /// validation errors.
    /// </summary>
    /// <param name="propertyName"></param>
    protected void ClearErrors([CallerMemberName] string? propertyName = null)
    {
        if (String.IsNullOrEmpty(propertyName))
        {
            // This means clear all errors
            _propertyErrors.Clear();
            OnErrorsChanged();
            return;
        }

        if (_propertyErrors.TryGetValue(propertyName, out var errors))
        {
            errors.Clear();
            OnErrorsChanged();
        }
    }

    /// <summary>
    /// Clears the validation errors for all of the specified properties.
    /// </summary>
    /// <param name="propertyNames"></param>
    protected void ClearErrors(IEnumerable<string> propertyNames)
    {
        foreach (var propertyName in propertyNames)
        {
            ClearErrors(propertyName);
        }
    }

    /// <summary>
    /// Adds an error for the given property name.
    /// </summary>
    /// <param name="propertyName">The property name to add the validation error to.</param>
    /// <param name="error">The error</param>
    protected void AddError(string propertyName, string error)
    {
        ArgumentNullException.ThrowIfNull(propertyName);

        if (!_propertyErrors.TryGetValue(propertyName, out var errors) || errors == null)
        {
            _propertyErrors[propertyName] = [];
        }

        _propertyErrors[propertyName].Add(error);
        OnErrorsChanged(propertyName);
    }

    private void OnErrorsChanged([CallerMemberName] string? propertyName = null)
    {
        ErrorsChanged?.Invoke(this, new(propertyName));
        OnPropertyChanged(nameof(HasErrors));
    }

    /// <summary>
    /// Sets the value for the give property. If the value is changed it clears the existing errors for the property.
    /// </summary>
    /// <typeparam name="T">The type of the property specified.</typeparam>
    /// <param name="field">The field value to be updated with the new value.</param>
    /// <param name="newValue">The new value for the property.</param>
    /// <param name="propertyName">The property name.</param>
    /// <returns>true if the property was updated, false if not.</returns>
    protected virtual bool SetPropertyWithErrors<T>([NotNullIfNotNull(nameof(newValue))] ref T field, T newValue, [CallerMemberName] string? propertyName = null)
    {
        if (SetProperty(ref field, newValue, propertyName))
        {
            ClearErrors(propertyName);
            return true;
        }

        return false;
    }

    /// <summary>
    /// Sets the value for the give property. If the value is changed it clears the existing errors for the property.
    /// </summary>
    /// <typeparam name="TModel">The model class being whose property is being updated.</typeparam>
    /// <typeparam name="T">The type of the field in the class.</typeparam>
    /// <param name="oldValue">The old value to be replaced.</param>
    /// <param name="newValue">The new value.</param>
    /// <param name="model">The actual model to be updated.</param>
    /// <param name="callback">A callback which will be executed if the values are not equal.</param>
    /// <param name="propertyName">The name of the property being updated.</param>
    /// <returns>true if the value is changed, false if not.</returns>
    protected virtual bool SetPropertyWithErrors<TModel, T>(T oldValue, T newValue, TModel model, Action<TModel, T> callback, [CallerMemberName] string? propertyName = null)
        where TModel : class
    {
        if (SetProperty(oldValue, newValue, model, callback, propertyName))
        {
            ClearErrors(propertyName);
            return true;
        }

        return false;
    }
}