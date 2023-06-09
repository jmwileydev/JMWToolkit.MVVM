﻿/*
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

/// <summary>
/// ComboBoxWithAdd - adds an optional button to the bottom of the ComboBox drop down so that the user can choose to
/// add a new item into the list.
/// </summary>
public class ComboBoxWithAdd : ComboBox
{
    /// <summary>
    /// Default constructor for the ComboBoxWithAdd
    /// </summary>
    static ComboBoxWithAdd()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(ComboBoxWithAdd), new FrameworkPropertyMetadata(typeof(ComboBoxWithAdd)));
    }

    /// <summary>
    /// Dependency property so the user can specify an ICommand for the AddNewItemCommand
    /// </summary>
    public static readonly DependencyProperty AddNewItemCommandProperty =
            DependencyProperty.Register(
            "AddNewItemCommand",
            typeof(ICommand),
            typeof(ComboBoxWithAdd));

    /// <summary>
    /// Dependency Property so the user can specify the content of the AddNewItem button
    /// </summary>
    public static readonly DependencyProperty AddNewItemContentProperty =
            DependencyProperty.Register(
            "AddNewItemContent",
            typeof(String),
            typeof(ComboBoxWithAdd));

    /// <summary>
    /// Dependency Property so the user can also pass an additional parameter to the AddNewItemCommand
    /// </summary>
    public static readonly DependencyProperty AddNewItemCommandParameterProperty =
            DependencyProperty.Register(
            "AddNewItemCommandParameter",
            typeof(Object),
            typeof(ComboBoxWithAdd));

    /// <summary>
    /// The command executed with AddNewItem button is clicked
    /// </summary>
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

    /// <summary>
    /// Parameter to be passed to the AddNewItem Command
    /// </summary>
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

    /// <summary>
    /// The content to be displayed in the AddNewItem button
    /// </summary>
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
