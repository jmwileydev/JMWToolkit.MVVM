# JMWToolkit.MVVM
A toolkit with some common classes used in my WPF MVVM projects.

[JMWToolkit.MVVM API documentation](JMWToolkit.MVVM.md)

## MessageBoxEx
Save this so I can add it to the XML documentation
```
    <system:String x:Key="DefaultCaption">
    Here is a string that will be the first paragraph. I want to spill onto
a new line so you can see how paragraphs will be indented.&lt;break&gt;
    This second line should be indented to match the indention level of the
first line. All extra spaces "        " in your text should be preserved. Except
those after the last new line.
    </system:String>
```
The caption will look like below
```
    Here is a string that will be the first paragraph. I want to spill onto a new line so you can see how paragraphs will
be indented
    This second line should be indented to match the indention level of the first line. All extra spaces "        " in your
text should be preserved. Except those after the last new line.
```

My plan in the future is to support some more simply formatting values. For instance <bold> would be nice. However
to do that I will probably end up switching to use XmlReader to parse the text. For now I am simply using simple
string operations.
