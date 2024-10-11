/*
 * Copyright (c) 2023, J.M. Wiley
All rights reserved.

This source code is licensed under the BSD-style license found in the
LICENSE file in the root directory of this source tree. 
*/
using JMWToolkit.MVVM.ViewModels;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace JMWToolkit.MVVM.ValueConverters;

[ValueConversion(typeof(object[]), typeof(MessageBoxExeCommandArgs))]
internal class MessageBoxExeCommandArgsConverter : IMultiValueConverter
{
    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
        if (values.Length != 2 ||
            values[0] is not Window ||
            values[1] is not MessageBoxResult)
        {
            return DependencyProperty.UnsetValue;
        }

        return new MessageBoxExeCommandArgs((Window)values[0], (MessageBoxResult)values[1]);
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
