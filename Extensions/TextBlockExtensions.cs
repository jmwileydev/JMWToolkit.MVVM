using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows;

namespace JMWToolkit.MVVM.Extensions;

/// <summary>
/// The TextBlockExtension is used to replace the InlineCollection on a TextBlock. It should be used in connection with
/// the MultilineTextConverter.cs which will takes a string and produces a List<Inline> to be used in the TextBlock.
/// </summary>
public static class TextBlockExtensions
{
    public static IEnumerable<Inline> GetBindableInlines(DependencyObject obj)
    {
        return (IEnumerable<Inline>)obj.GetValue(BindableInlinesProperty);
    }

    public static void SetBindableInlines(DependencyObject obj, IEnumerable<Inline> value)
    {
        obj.SetValue(BindableInlinesProperty, value);
    }

    public static readonly DependencyProperty BindableInlinesProperty =
        DependencyProperty.RegisterAttached("BindableInlines", 
            typeof(IEnumerable<Inline>), typeof(TextBlockExtensions), new PropertyMetadata(null, OnBindableInlinesChanged));

    private static void OnBindableInlinesChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is TextBlock textBlock)
        {
            textBlock.Inlines.Clear();
            textBlock.Inlines.AddRange((System.Collections.IEnumerable)e.NewValue);
        }
    }
}
