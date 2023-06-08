using System.Collections.Generic;
using System.Windows.Documents;
using System.Windows.Data;
using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace JMWToolkit.MVVM.ValueConverters;

[ValueConversion(typeof(String), typeof(List<Inline>))]
public partial class MultilineTextConverter : IValueConverter
{
    [GeneratedRegex(@"[ ]*\n")]
    private static partial Regex _spacesAndNewLine();

    public static List<Inline> Convert(String value)
    {
        String text = (String)value;

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
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return Convert((String)value);
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

