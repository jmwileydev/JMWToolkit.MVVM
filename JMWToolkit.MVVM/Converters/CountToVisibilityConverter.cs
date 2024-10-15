/*
 * Copyright (c) 2023, J.M. Wiley
All rights reserved.

This source code is licensed under the BSD-style license found in the
LICENSE file in the root directory of this source tree. 
*/
using System.Windows.Data;
using System;
using System.Globalization;
using System.Windows;

namespace JMWToolkit.MVVM.Converters;

/// <summary>
/// Convert a Int32 into a Visibility value. The caller can pass an optional argument of type CountToVisibilityArguments which
/// can modify the comparison that is done. By default it will check to see if the value == 0.
/// </summary>
[ValueConversion(typeof(Int32), typeof(Visibility))]
public class CountToVisibilityConverter : IValueConverter
{
    /// <summary>
    /// Convert a bool to a visibility value
    /// </summary>
    /// <param name="value">The value to be converted.</param>
    /// <param name="targetType">Must be typeof(Visibility)</param>
    /// <param name="parameter">optional VisibilityConverterMode, default is VisibilityConverterMode.Collapsed</param>
    /// <param name="culture">ignored</param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        CountToVisibilityArguments countToVisibilityArguments = new();

        if (value is not Int32 intValue)
        {
            return DependencyProperty.UnsetValue;
        }

        if (targetType != typeof(Visibility))
        {
            return DependencyProperty.UnsetValue;
        }

        if (parameter is CountToVisibilityArguments arguments)
        {
            countToVisibilityArguments = arguments;
        }

        bool? boolValue = countToVisibilityArguments.Operator switch
        {
            CountToVisibilityOperator.NotEqual => intValue != countToVisibilityArguments.Count,
            CountToVisibilityOperator.LessThan => intValue < countToVisibilityArguments.Count,
            CountToVisibilityOperator.LessThanOrEqual => intValue <= countToVisibilityArguments.Count,
            CountToVisibilityOperator.GreaterThan => intValue > countToVisibilityArguments.Count,
            CountToVisibilityOperator.GreaterThanOrEqual => intValue >= countToVisibilityArguments.Count,
            CountToVisibilityOperator.Equals => intValue == countToVisibilityArguments.Count,
            _ => null
        };

        if (boolValue == null)
        {
            return DependencyProperty.UnsetValue;
        }

        return countToVisibilityArguments.VisibilityConverterMode switch
        {
            VisibilityConverterMode.Hidden => boolValue.Value ? Visibility.Visible : Visibility.Hidden,
            VisibilityConverterMode.InverseCollapsed => boolValue.Value ? Visibility.Collapsed : Visibility.Visible,
            VisibilityConverterMode.InverseHidden => boolValue.Value ? Visibility.Hidden : Visibility.Visible,
            _ => boolValue.Value ? Visibility.Visible : Visibility.Collapsed,
        };
    }

    /// <summary>
    /// Not implemented
    /// </summary>
    /// <param name="value"></param>
    /// <param name="targetType"></param>
    /// <param name="parameter"></param>
    /// <param name="culture"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
