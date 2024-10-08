﻿/*
 * Copyright (c) 2023, J.M. Wiley
All rights reserved.

This source code is licensed under the BSD-style license found in the
LICENSE file in the root directory of this source tree. 

Original source code was obtained from the following link:https://www.wpftutorial.net/RemoveIcon.html
Thanks to Christian Moser for the code in the article.

*/
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Interop;

namespace JMWToolkit.MVVM.Helpers;

/// <summary>
/// The IconHelper is a static class which exposes a single method to remove the icon from
/// the window decoration. It is used by MessageBoxEx but can be used on any Window.
/// </summary>
internal static partial class IconHelper
{
    [DllImport("user32.dll")]
    static extern int GetWindowLong(IntPtr hwnd, int index);

    [DllImport("user32.dll")]
    static extern int SetWindowLong(IntPtr hwnd, int index, int newStyle);

    [DllImport("user32.dll")]
    static extern bool SetWindowPos(IntPtr hwnd, IntPtr hwndInsertAfter,
               int x, int y, int width, int height, uint flags);

    [DllImport("user32.dll")]
    static extern IntPtr SendMessage(IntPtr hwnd, uint msg,
               IntPtr wParam, IntPtr lParam);

    internal const int GWL_EXSTYLE = -20;
    internal const int WS_EX_DLGMODALFRAME = 0x0001;
    internal const int SWP_NOSIZE = 0x0001;
    internal const int SWP_NOMOVE = 0x0002;
    internal const int SWP_NOZORDER = 0x0004;
    internal const int SWP_FRAMECHANGED = 0x0020;
    internal const uint WM_SETICON = 0x0080;

    /// <summary>
    /// Removes the Icon from the Window.
    /// </summary>
    /// <param name="window"></param>
    public static void RemoveIcon(Window window)
    {
        // Get this window's handle
        IntPtr hwnd = new WindowInteropHelper(window).Handle;

        // Change the extended window style to not show a window icon
        int extendedStyle = GetWindowLong(hwnd, GWL_EXSTYLE);
        _ = SetWindowLong(hwnd, GWL_EXSTYLE, extendedStyle | WS_EX_DLGMODALFRAME);

        // Update the window's non-client area to reflect the changes
        SetWindowPos(hwnd, IntPtr.Zero, 0, 0, 0, 0, SWP_NOMOVE |
              SWP_NOSIZE | SWP_NOZORDER | SWP_FRAMECHANGED);
    }
}
