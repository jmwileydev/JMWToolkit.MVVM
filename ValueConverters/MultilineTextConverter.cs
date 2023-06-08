using System.Collections.Generic;
using System.Windows.Documents;
using System.Windows.Data;
using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace JMWToolkit.MVVM.ValueConverters;

/// <summary>
/// The MultilineTextConverter is used to convert a string with &lt;break&gt; lines in it to multiline
/// text.
///     - A single newline is trimmed from the start of the string
///     - Any trailing newline characters are trimmed.
///     - Lines are broken at the &lt;break&gt;
///     - Trailing whitespace is removed from the last line.
/// </summary>
[ValueConversion(typeof(String), typeof(List<Inline>))]
public partial class MultilineTextConverter : IValueConverter
{
    [GeneratedRegex(@"[ ]*\n")]
    private static partial Regex _spacesAndNewLine();

    /// <summary>
    /// Converts the passed in string to a collection of Inline objects.
    /// </summary>
    /// <param name="value">string to be parsed and formatted</param>
    /// <param name="targetType">type of the target property</param>
    /// <param name="parameter">converter parameter</param>
    /// <param name="culture">The culture to use in the converter</param>
    /// <returns></returns>
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        String text = ((String)value).TrimStart('\n');

        // Replace all "\n[ ]*" with "\n"
        text = _spacesAndNewLine().Replace(text, " ");

        List<Inline> inlineCollection = new();
        if (text != null)
        {
            // First thing we need to do is remove all of the "\n" which are in the text

            var lines = text.Split("<break>");
            for (int i = 0; i < lines.Length; i++)
            {
                if (i != 0)
                {
                    inlineCollection.Add(new LineBreak());
                }

                var textToAdd = i != lines.Length - 1 ? lines[i] : lines[i].TrimEnd();
                inlineCollection.Add(new Run(textToAdd));
            }
        }

        return inlineCollection;
    }

    /// <summary>
    /// This routine is not implemented
    /// </summary>
    /// <param name="value">ignored</param>
    /// <param name="targetType">ignored</param>
    /// <param name="parameter">ignored</param>
    /// <param name="culture">ignored</param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

