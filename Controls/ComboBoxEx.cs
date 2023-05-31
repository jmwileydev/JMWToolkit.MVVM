/*
 * Copyright (c) 2023, J.M. Wiley
All rights reserved.

This source code is licensed under the BSD-style license found in the
LICENSE file in the root directory of this source tree. 
*/
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace JMWToolkit.MVVM.Controls;

public class ComboBoxEx : ComboBox
{
    public static readonly DependencyProperty AddNewItemCommandProperty =
            DependencyProperty.Register(
            "AddNewItemCommand",
            typeof(ICommand),
            typeof(ComboBoxEx));

    public static readonly DependencyProperty AddNewItemContentProperty =
            DependencyProperty.Register(
            "AddNewItemContent",
            typeof(String),
            typeof(ComboBoxEx));

    public static readonly DependencyProperty AddNewItemCommandParameterProperty =
            DependencyProperty.Register(
            "AddNewItemCommandParameter",
            typeof(Object),
            typeof(ComboBoxEx));

    public ICommand AddNewItemCommand
    {
        get
        {
            return (ICommand)GetValue(AddNewItemCommandProperty);
        }

        set
        {
            SetValue(AddNewItemCommandProperty, value);
        }
    }
        public Object AddNewItemCommandParameter
    {
        get
        {
            return (String)GetValue(AddNewItemCommandParameterProperty);
        }

        set
        {
            SetValue(AddNewItemCommandParameterProperty, value);
        }
    }

    public String AddNewItemContent
    {
        get
        {
            return (String)GetValue(AddNewItemContentProperty);
        }

        set
        {
            SetValue(AddNewItemContentProperty, value);
        }
    }
}
