/*
 * Copyright (c) 2023, J.M. Wiley
All rights reserved.

This source code is licensed under the BSD-style license found in the
LICENSE file in the root directory of this source tree. 
*/
using System.Windows;

namespace JMWToolkit.MVVM.ViewModels;

internal record MessageBoxExeCommandArgs
{
    public MessageBoxExeCommandArgs(Window window, MessageBoxResult result)
    {
        Window = window;
        Result = result;
    }

    public Window Window { get; private set; }
    public MessageBoxResult Result { get; private set; }
}
