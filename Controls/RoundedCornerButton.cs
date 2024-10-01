/*
 * Copyright (c) 2023, J.M. Wiley
All rights reserved.

This source code is licensed under the BSD-style license found in the
LICENSE file in the root directory of this source tree. 
*/
using System.Windows;
using System.Windows.Controls;

namespace JMWToolkit.MVVM.Controls;

/// <summary>
/// This is a button which allows you to specify a rounded corner.
/// </summary>
public class RoundedCornerButton : Button
{
    /// <summary>
    /// The CornerRadius for the button. Default is (0,0,0,0)
    /// </summary>
    public CornerRadius CornerRadius
    {
        get { return (CornerRadius)GetValue(CornerRadiusProperty); }
        set { SetValue(CornerRadiusProperty, value); }
    }

    /// <summary>
    /// The DependencyProperty for the CornerRadius
    /// </summary>
    public static readonly DependencyProperty CornerRadiusProperty =
        DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(RoundedCornerButton), new PropertyMetadata(new CornerRadius(0, 0, 0, 0)));
}
