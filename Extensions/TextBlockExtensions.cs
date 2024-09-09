/*
 * Copyright (c) 2023, J.M. Wiley
All rights reserved.

This source code is licensed under the BSD-style license found in the
LICENSE file in the root directory of this source tree. 
*/
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows;

namespace JMWToolkit.MVVM.Extensions;

/// <summary>
/// The TextBlockExtension is used to replace the InlineCollection on a TextBlock. It should be used in connection with
/// the MultilineTextConverter.cs which will takes a string and produces a List&lt;Inline&gt; to be used in the TextBlock.
/// </summary>
public static class TextBlockExtensions
{
    /// <summary>
    /// Gets the BindableLines property from a control
    /// </summary>
    /// <param name="obj">control on which the property has been set</param>
    /// <returns></returns>
    public static IEnumerable<Inline> GetBindableInlines(DependencyObject obj)
    {
        return (IEnumerable<Inline>)obj.GetValue(BindableInlinesProperty);
    }

    /// <summary>
    /// Sets the BindableLines property on a control
    /// </summary>
    /// <param name="obj">object to set the property on</param>
    /// <param name="value">a collection of InLine objects</param>
    public static void SetBindableInlines(DependencyObject obj, IEnumerable<Inline> value)
    {
        obj.SetValue(BindableInlinesProperty, value);
    }

    /// <summary>
    /// Property for binding a collection of Inline objects to a control
    /// </summary>
    public static readonly DependencyProperty BindableInlinesProperty =
        DependencyProperty.RegisterAttached("BindableInlines", 
            typeof(IEnumerable<Inline>), typeof(TextBlockExtensions), new PropertyMetadata(null, OnBindableInlinesChanged));

    /// <summary>
    /// delegate to be called when the BindableLines property is updated
    /// </summary>
    /// <param name="d">The dependency object which is the target, everything but TextBlock is ignored</param>
    /// <param name="e">The DependencyPropertyChangedEventArgs with the new value</param>
    private static void OnBindableInlinesChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is TextBlock textBlock)
        {
            textBlock.Inlines.Clear();
            textBlock.Inlines.AddRange((System.Collections.IEnumerable)e.NewValue);
        }
    }
}
