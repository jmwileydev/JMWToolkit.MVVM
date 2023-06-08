/*
 * Copyright (c) 2023, J.M. Wiley
All rights reserved.

This source code is licensed under the BSD-style license found in the
LICENSE file in the root directory of this source tree. 
*/
using JMWToolkit.MVVM.ViewModels;
using System;
using System.Windows;

namespace JMWToolkit.MVVM.Dialogs;

public class MessageBoxEx
{
    /// </summary>
    /// <param name="caption">
    /// The caption to be displayed. This can be a multiline paragraph string
    /// with <break> in between paragraph.
    /// </param>
    /// <param name="title">The title to be displayed</param>
    /// <param name="buttons">One of the MessageBoxButton values</param>
    /// <param name="image">
    ///     This is one of the enum values MessageBoxImage.Information,
    ///     MessageBox.Warning, MessageBox.Error, or MessageBox.Question.
    ///     All other values are ignored.
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
