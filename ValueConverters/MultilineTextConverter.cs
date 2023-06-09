﻿using System.Collections.Generic;
using System.Windows.Documents;
using System.Windows.Data;
using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Xml;
using System.IO;
using System.Windows;
using System.Diagnostics;

namespace JMWToolkit.MVVM.ValueConverters;

/// <summary>
/// The MultiLineTextConverter is a value converter to go from a String value to a
/// collection of Inline objects for rich formatting of the text.
/// </summary>
[ValueConversion(typeof(String), typeof(List<Inline>))]
public partial class MultilineTextConverter : IValueConverter
{
    [GeneratedRegex(@"[ ]*\n[ ]*")]
    private static partial Regex _spacesAndNewLine();

    private static object Convert(String value)
    {
        // Trim off leading and trailing whitespace
        value = value.Trim();

        List<Inline> inlines = new();
        int _inItalics = 0;
        int _inBold = 0;

        try
        {
            var reader = XmlReader.Create(new StringReader(value));
            if (reader.MoveToContent() != XmlNodeType.Element)
            {
                Debug.WriteLine("MultilineTextConverter: Expected an element and not {0}", reader.NodeType);
                return DependencyProperty.UnsetValue;
            }
            else if (reader.Name != "TextBlock")
            {
                Debug.WriteLine("MultilineTextConverter: Expected a <TextBlock> found {0}", reader.Name);
                return DependencyProperty.UnsetValue;
            }

            // Parse the file and display each of the nodes.
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        switch (reader.Name)
                        {
                            case "LineBreak":
                                inlines.Add(new LineBreak());
                                break;

                            case "Bold":
                                _inBold++;
                                break;

                            case "Italic":
                                _inItalics++;
                                break;

                            default:
                                Debug.WriteLine("MultilineTextConverter: Unrecognized Elemement Type {0}", reader.Name);
                                break;

                        }
                        break;
                    case XmlNodeType.Text:
                        // Ok, here is where we add a text run. First thing is to remove
                        // any leading newlines, not spaces.
                        var text = reader.Value.Trim('\n');

                        // Replace all "\n[ ]*" with "\n" since only the first line of a run
                        // gets indented.
                        text = _spacesAndNewLine().Replace(text, " ");

                        Inline inline = new Run(text);

                        if (_inBold > 0)
                        {
                            inline = new Bold(inline);
                        }

                        if (_inItalics > 0)
                        {
                            inline = new Italic(inline);
                        }

                        inlines.Add(inline);
                        break;

                    case XmlNodeType.XmlDeclaration:
                        break;

                    case XmlNodeType.Document:
                        break;

                    case XmlNodeType.EndElement:
                        switch (reader.Name)
                        {
                            case "TextBlock":
                                return inlines;

                            case "LineBreak":
                                break;

                            case "Bold":
                                _inBold--;
                                break;

                            case "Italic":
                                _inItalics--;
                                break;

                            default:
                                Debug.WriteLine("MultilineTextConverter: Unrecognized EndElemement Type {0}", reader.Name);
                                break;

                        }
                        break;
                }
            }
        }
        catch(System.Exception ex)
        {
            Debug.WriteLine("MultilineTextConverter: Exception processing Xml {0}", ex.Message);
            return DependencyProperty.UnsetValue;
        }

        // If I get here then the document was not well formed
        return DependencyProperty.UnsetValue;
    }
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var str = value as String ?? String.Empty;

        if (String.IsNullOrEmpty(str))
        {
            return DependencyProperty.UnsetValue;
        }

        return Convert(str);
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

