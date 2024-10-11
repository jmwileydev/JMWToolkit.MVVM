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
/// Convert a bool value into System.Windows.Visibility. By default if the condition is true Visibility.Visible will
/// be returned. If false the default is collapsed. The caller can pass the VisibilityConverterMode to control the behavior.
/// </summary>
[ValueConversion(typeof(bool), typeof(Visibility))]
public class BooleanToVisibilityConverter : IValueConverter
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
        VisibilityConverterMode mode = VisibilityConverterMode.Collapsed;

        if (value is not bool boolValue)
        {
            return DependencyProperty.UnsetValue;
        }

        if (targetType != typeof(Visibility))
        {
            return DependencyProperty.UnsetValue;
        }

        if (parameter is VisibilityConverterMode userMode)
        {
            mode = userMode;
        }
        Visibility visibility;

        switch(mode)
        {
            default:
                visibility = boolValue ? Visibility.Visible : Visibility.Collapsed;
                break;

            case VisibilityConverterMode.Hidden:
                visibility = boolValue ? Visibility.Visible : Visibility.Hidden;
                break;

            case VisibilityConverterMode.InverseCollapsed:
                visibility = boolValue ? Visibility.Collapsed : Visibility.Visible;
                break;

            case VisibilityConverterMode.InverseHidden:
                visibility = boolValue ? Visibility.Hidden : Visibility.Visible;
                break;
        }

        return visibility;
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
