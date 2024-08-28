/*
 * Copyright (c) 2023, J.M. Wiley
All rights reserved.

This source code is licensed under the BSD-style license found in the
LICENSE file in the root directory of this source tree. 
*/
using CommunityToolkit.Mvvm.Input;
using System;
using System.Drawing;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media.Imaging;
using Image = System.Windows.Controls.Image;

namespace JMWToolkit.MVVM.ViewModels;

internal class MessageBoxExViewModel : MoveableWindowViewModel
{
    internal MessageBoxExViewModel(
        String caption,
        string title,
        MessageBoxButton button = MessageBoxButton.OK,
        MessageBoxImage image = MessageBoxImage.Information)
    {
        Title = title;
        if (caption != null)
        {
            Caption = caption;
        }
        MessageBoxButton = button;

        Icon? icon = null;

        switch (image)
        {
            case MessageBoxImage.Information:
                icon = SystemIcons.Information;
                break;

            case MessageBoxImage.Warning:
                icon = SystemIcons.Warning;
                break;

            case MessageBoxImage.Error:
                icon = SystemIcons.Error;
                break;

            case MessageBoxImage.Question:
                icon = SystemIcons.Question;
                break;
        }

        if (icon != null)
        {
            Image.Source = Imaging.CreateBitmapSourceFromHIcon(icon.Handle, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
        }

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

    public Image Image { get; private set; } = new Image();

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
