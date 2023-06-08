/*
 * Copyright (c) 2023, J.M. Wiley
All rights reserved.

This source code is licensed under the BSD-style license found in the
LICENSE file in the root directory of this source tree. 
*/
using JMWToolkit.MVVM.ViewModels;
using System;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Shapes;

namespace JMWToolkit.MVVM.Dialogs;

/// <summary>
/// Class used to Show a MessageBox dialog that allows formatted text for the caption. This
/// is very similiar to the built in MessageBox class but with the text enhancements for the
/// caption. I will continue to add more features but for now the
/// Caption area allows you to specify &lt;break&gt; in a line when you want a paragraph break.
/// </summary>
public class MessageBoxEx
{
    /// <summary>
    /// Show the dialog and return when the user makes one of the choices.
    /// </summary>
    /// <param name="caption">
    /// The caption to be displayed. This can be a multiline paragraph string
    /// with ;lt;break&gt; in between paragraph.
    /// </param>
    /// <param name="title">The title to be displayed</param>
    /// <param name="buttons">One of the MessageBoxButton values, defaults to MessageBoxButton.OK</param>
    /// <param name="image">
    ///     This is one of the enum values MessageBoxImage.Information, MessageBoxImage.Warning, 
    ///     MessageBoxImage.Error, or MessageBoxImage.Question defaults to MessageBoxImage.Informormation
    /// </param>
    /// <returns></returns>
    public static MessageBoxResult ShowDialog(String caption, string title, MessageBoxButton buttons = MessageBoxButton.OK, MessageBoxImage image = MessageBoxImage.Information)
    {
        var viewModel = new MessageBoxExViewModel(caption, title, buttons, image);
        var dlg = new MessageBoxExWindow(viewModel);
        _ = dlg.ShowDialog();
        return viewModel.MessageBoxResult;
    }
}
