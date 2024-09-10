/*
 * Copyright (c) 2023, J.M. Wiley
All rights reserved.

This source code is licensed under the BSD-style license found in the
LICENSE file in the root directory of this source tree. 
*/
using CommunityToolkit.Mvvm.Input;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using Image = System.Windows.Controls.Image;

namespace JMWToolkit.MVVM.ViewModels;

internal class MessageBoxExViewModel : MoveableWindowViewModel
{ 
    internal MessageBoxExViewModel(
        String caption,
        string title,
        MessageBoxButton button = MessageBoxButton.OK,
        ImageSource? imageSource = null)
    {
        Title = title;
        if (caption != null)
        {
            Caption = caption;
        }
        MessageBoxButton = button;
        ImageSource = imageSource;

        ButtonClickedCommand = new RelayCommand<MessageBoxExeCommandArgs>(
            (args) =>
            {
                if (args != null)
                {
                    MessageBoxResult = args.Result;
                    args.Window.Close();
                }
            });
    }

    public String Title { get; private set; } = "MessageBoxEx";

    public String Caption { get; private set; } = String.Empty;

    private MessageBoxButton MessageBoxButton { get; set; }

    public ImageSource? ImageSource { get; private set; }

    public bool OkButtonVisible { get => MessageBoxButton == MessageBoxButton.OK || MessageBoxButton == MessageBoxButton.OKCancel; }

    public bool CancelButtonVisible { get => MessageBoxButton == MessageBoxButton.OKCancel || MessageBoxButton == MessageBoxButton.YesNoCancel; }

    public bool YesButtonVisible { get => MessageBoxButton == MessageBoxButton.YesNoCancel || MessageBoxButton == MessageBoxButton.YesNo; }

    public bool NoButtonVisible { get => MessageBoxButton == MessageBoxButton.YesNoCancel || MessageBoxButton == MessageBoxButton.YesNo; }

    public ICommand ButtonClickedCommand { get; private set; }

    public MessageBoxResult MessageBoxResult { get; private set; }

    public String OkButtonText { get; set; } = "Ok";
    public String CancelButtonText { get; set; } = "Cancel";

    public String YesButtonText { get; set; } = "Yes";

    public String NoButtonText { get; set; } = "No";
}
