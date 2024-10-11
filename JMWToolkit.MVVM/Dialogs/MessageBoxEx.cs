/*
 * Copyright (c) 2023, J.M. Wiley
All rights reserved.

This source code is licensed under the BSD-style license found in the
LICENSE file in the root directory of this source tree. 
*/
using JMWToolkit.MVVM.Helpers;
using JMWToolkit.MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace JMWToolkit.MVVM.Dialogs;

/// <summary>
/// Class used to Show a MessageBox dialog that allows formatted text for the caption. This
/// is very similar to the built in MessageBox class but with the text enhancements for the
/// caption. I will continue to add more features but for now the
/// Caption area allows you to specify &lt;break&gt; in a line when you want a paragraph break.
/// </summary>
public static class MessageBoxEx
{
    private static readonly Dictionary<MessageBoxImage, ImageSource?> _messageBoxImages = [];

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
    ///     MessageBoxImage.Error, or MessageBoxImage.Question defaults to MessageBoxImage.Information
    /// </param>
    /// <returns></returns>
    public static MessageBoxResult ShowDialog(String caption, string title, MessageBoxButton buttons = MessageBoxButton.OK, MessageBoxImage image = MessageBoxImage.Information)
    {
        var viewModel = new MessageBoxExViewModel(caption, title, buttons, GetMessageBoxImageSource(image));
        var dlg = new MessageBoxExWindow(viewModel);
        _ = dlg.ShowDialog();
        return viewModel.MessageBoxResult;
    }

    /// <summary>
    /// Gets the ImageSource for the give MessageBoxImage
    /// </summary>
    /// <param name="messageBoxImage">The MessageBoxImage to get the ImageSource for.</param>
    /// <returns></returns>
    public static ImageSource? GetMessageBoxImageSource(MessageBoxImage messageBoxImage)
    {
        if (messageBoxImage == MessageBoxImage.None)
        {
            return null;
        }

        if (!_messageBoxImages.TryGetValue(messageBoxImage, out var imageSource))
        {
            var icon = messageBoxImage switch
            {
                MessageBoxImage.Warning => SystemIcon.IDI_WARNING,
                MessageBoxImage.Error => SystemIcon.IDI_ERROR,
                MessageBoxImage.Question => SystemIcon.IDI_QUESTION,
                _ => SystemIcon.IDI_INFORMATION,
            };

            IntPtr hIcon = NativeHelpers.LoadSystemIcon(icon);
            imageSource = Imaging.CreateBitmapSourceFromHIcon(hIcon, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

            using (var fileStream = new FileStream(@"c:\temp\bitmap.png", FileMode.Create))
            {
                BitmapEncoder encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(imageSource as BitmapSource));
                encoder.Save(fileStream);
            }

            _messageBoxImages.Add(messageBoxImage, imageSource);
        }

        return imageSource;
    }
}
