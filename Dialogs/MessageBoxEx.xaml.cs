/*
 * Copyright (c) 2023, J.M. Wiley
All rights reserved.

This source code is licensed under the BSD-style license found in the
LICENSE file in the root directory of this source tree. 
*/
using JMWToolkit.MVVM.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Interop;
using System.Windows.Media.Imaging;

namespace JMWToolkit.MVVM.Dialogs;

/// <summary>
/// MessageBoxEx - does a better job of formatting the messages when they are long. It automatically
/// adds in the line breaks where needed.
/// </summary>
public partial class MessageBoxEx : Window
{
    private MessageBoxResult _result = MessageBoxResult.None;

    private MessageBoxEx()
    {
        InitializeComponent();
    }

    protected override void OnSourceInitialized(EventArgs e)
    {
        IconHelper.RemoveIcon(this);
    }

    public static MessageBoxResult ShowDialog(String caption, string title, MessageBoxButton buttons = MessageBoxButton.OK, MessageBoxImage image = MessageBoxImage.Information)
    {
        MessageBoxEx messageBoxEx = new();

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
            messageBoxEx._Icon.Source = Imaging.CreateBitmapSourceFromHIcon(icon.Handle, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
        }

        switch (buttons)
        {
            case MessageBoxButton.OK:
                break;

            case MessageBoxButton.OKCancel:
                messageBoxEx._CancelButton.Visibility = Visibility.Visible;
                break;

            case MessageBoxButton.YesNoCancel:
                messageBoxEx._OkButton.Visibility = Visibility.Collapsed;
                messageBoxEx._YesButton.Visibility = Visibility.Visible;
                messageBoxEx._NoButton.Visibility = Visibility.Visible;
                messageBoxEx._CancelButton.Visibility = Visibility.Visible;
                goto case MessageBoxButton.YesNo;

            case MessageBoxButton.YesNo:
                messageBoxEx._OkButton.Visibility = Visibility.Collapsed;
                messageBoxEx._YesButton.Visibility = Visibility.Visible;
                messageBoxEx._NoButton.Visibility = Visibility.Visible;
                messageBoxEx._NoButton.IsCancel = true;
                break;
        }

        messageBoxEx.Title = title;
        messageBoxEx.SetFormatText(caption);

        _ = messageBoxEx.ShowDialog();
        return messageBoxEx._result;
    }

    private void SetFormatText(string text)
    {
        List<Inline> inlineCollection = new();
        if (text != null)
        {
            // We need to break at carriage returns
            var lines = text.Split("\n");
            for (int i = 0; i < lines.Length; i++)
            {
                if (i != 0)
                {
                    inlineCollection.Add(new LineBreak());
                }

                inlineCollection.Add(new Run(lines[i]));
            }

            _Caption.Inlines.Clear();
            foreach (var line in inlineCollection)
            {
                _Caption.Inlines.Add(line);
            }
        }
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        Button button = (Button)sender;

        if (button == _OkButton)
        {
            _result = MessageBoxResult.OK;
        }
        else if (button == _CancelButton)
        {
            _result = MessageBoxResult.Cancel;
        }
        else if (button == _YesButton)
        {
            _result = MessageBoxResult.Yes;
        }
        else if (button == _NoButton)
        {
            _result = MessageBoxResult.No;
        }

        Close();
    }

    public String OkButtonText { get; set; } = "OK";
    public String CancelButtonText { get; set;} = "Cancel";

    public String YesButtonText { get; set; } = "Yes";

    public String NoButtonText { get; set; } = "No";
}
