﻿/*
 * Copyright (c) 2023, J.M. Wiley
All rights reserved.

This source code is licensed under the BSD-style license found in the
LICENSE file in the root directory of this source tree. 
*/
using JMWToolkit.MVVM.Helpers;
using JMWToolkit.MVVM.ViewModels;
using System;
using System.Windows;

namespace JMWToolkit.MVVM.Dialogs;

/// <summary>
/// MessageBoxEx - does a better job of formatting the messages when they are long. It automatically
/// adds in the line breaks where needed.
/// </summary>
internal partial class MessageBoxExWindow : Window
{
    internal MessageBoxExWindow(MessageBoxExViewModel _viewModel)
    {
        InitializeComponent();
        DataContext = _viewModel;
    }

    protected override void OnSourceInitialized(EventArgs e)
    {
        IconHelper.RemoveIcon(this);
    }
}
