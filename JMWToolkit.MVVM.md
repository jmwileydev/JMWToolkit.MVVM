<a name='assembly'></a>
# JMWToolkit.MVVM

## Contents

- [ComboBoxWithAdd](#T-JMWToolkit-MVVM-Controls-ComboBoxWithAdd 'JMWToolkit.MVVM.Controls.ComboBoxWithAdd')
  - [#ctor()](#M-JMWToolkit-MVVM-Controls-ComboBoxWithAdd-#ctor 'JMWToolkit.MVVM.Controls.ComboBoxWithAdd.#ctor')
  - [AddNewItemCommandParameterProperty](#F-JMWToolkit-MVVM-Controls-ComboBoxWithAdd-AddNewItemCommandParameterProperty 'JMWToolkit.MVVM.Controls.ComboBoxWithAdd.AddNewItemCommandParameterProperty')
  - [AddNewItemCommandProperty](#F-JMWToolkit-MVVM-Controls-ComboBoxWithAdd-AddNewItemCommandProperty 'JMWToolkit.MVVM.Controls.ComboBoxWithAdd.AddNewItemCommandProperty')
  - [AddNewItemContentProperty](#F-JMWToolkit-MVVM-Controls-ComboBoxWithAdd-AddNewItemContentProperty 'JMWToolkit.MVVM.Controls.ComboBoxWithAdd.AddNewItemContentProperty')
  - [AddNewItemCommand](#P-JMWToolkit-MVVM-Controls-ComboBoxWithAdd-AddNewItemCommand 'JMWToolkit.MVVM.Controls.ComboBoxWithAdd.AddNewItemCommand')
  - [AddNewItemCommandParameter](#P-JMWToolkit-MVVM-Controls-ComboBoxWithAdd-AddNewItemCommandParameter 'JMWToolkit.MVVM.Controls.ComboBoxWithAdd.AddNewItemCommandParameter')
  - [AddNewItemContent](#P-JMWToolkit-MVVM-Controls-ComboBoxWithAdd-AddNewItemContent 'JMWToolkit.MVVM.Controls.ComboBoxWithAdd.AddNewItemContent')
- [IconHelper](#T-JMWToolkit-MVVM-Helpers-IconHelper 'JMWToolkit.MVVM.Helpers.IconHelper')
  - [RemoveIcon(window)](#M-JMWToolkit-MVVM-Helpers-IconHelper-RemoveIcon-System-Windows-Window- 'JMWToolkit.MVVM.Helpers.IconHelper.RemoveIcon(System.Windows.Window)')
- [MessageBoxEx](#T-JMWToolkit-MVVM-Dialogs-MessageBoxEx 'JMWToolkit.MVVM.Dialogs.MessageBoxEx')
  - [ShowDialog(caption,title,buttons,image)](#M-JMWToolkit-MVVM-Dialogs-MessageBoxEx-ShowDialog-System-String,System-String,System-Windows-MessageBoxButton,System-Windows-MessageBoxImage- 'JMWToolkit.MVVM.Dialogs.MessageBoxEx.ShowDialog(System.String,System.String,System.Windows.MessageBoxButton,System.Windows.MessageBoxImage)')
- [MessageBoxExViewModel](#T-JMWToolkit-MVVM-ViewModels-MessageBoxExViewModel 'JMWToolkit.MVVM.ViewModels.MessageBoxExViewModel')
  - [OkButtonText](#P-JMWToolkit-MVVM-ViewModels-MessageBoxExViewModel-OkButtonText 'JMWToolkit.MVVM.ViewModels.MessageBoxExViewModel.OkButtonText')
- [MessageBoxExWindow](#T-JMWToolkit-MVVM-Dialogs-MessageBoxExWindow 'JMWToolkit.MVVM.Dialogs.MessageBoxExWindow')
  - [InitializeComponent()](#M-JMWToolkit-MVVM-Dialogs-MessageBoxExWindow-InitializeComponent 'JMWToolkit.MVVM.Dialogs.MessageBoxExWindow.InitializeComponent')
- [MultilineTextConverter](#T-JMWToolkit-MVVM-ValueConverters-MultilineTextConverter 'JMWToolkit.MVVM.ValueConverters.MultilineTextConverter')
  - [Convert(value,targetType,parameter,culture)](#M-JMWToolkit-MVVM-ValueConverters-MultilineTextConverter-Convert-System-Object,System-Type,System-Object,System-Globalization-CultureInfo- 'JMWToolkit.MVVM.ValueConverters.MultilineTextConverter.Convert(System.Object,System.Type,System.Object,System.Globalization.CultureInfo)')
  - [ConvertBack(value,targetType,parameter,culture)](#M-JMWToolkit-MVVM-ValueConverters-MultilineTextConverter-ConvertBack-System-Object,System-Type,System-Object,System-Globalization-CultureInfo- 'JMWToolkit.MVVM.ValueConverters.MultilineTextConverter.ConvertBack(System.Object,System.Type,System.Object,System.Globalization.CultureInfo)')
  - [_spacesAndNewLine()](#M-JMWToolkit-MVVM-ValueConverters-MultilineTextConverter-_spacesAndNewLine 'JMWToolkit.MVVM.ValueConverters.MultilineTextConverter._spacesAndNewLine')
- [StringResourceHelpers](#T-JMWToolkit-MVVM-Helpers-StringResourceHelpers 'JMWToolkit.MVVM.Helpers.StringResourceHelpers')
  - [LoadAndFormatStringResource(format,args)](#M-JMWToolkit-MVVM-Helpers-StringResourceHelpers-LoadAndFormatStringResource-System-String,System-Object[]- 'JMWToolkit.MVVM.Helpers.StringResourceHelpers.LoadAndFormatStringResource(System.String,System.Object[])')
  - [LoadStringResource(resourceId)](#M-JMWToolkit-MVVM-Helpers-StringResourceHelpers-LoadStringResource-System-String- 'JMWToolkit.MVVM.Helpers.StringResourceHelpers.LoadStringResource(System.String)')
- [TextBlockExtensions](#T-JMWToolkit-MVVM-Extensions-TextBlockExtensions 'JMWToolkit.MVVM.Extensions.TextBlockExtensions')
  - [BindableInlinesProperty](#F-JMWToolkit-MVVM-Extensions-TextBlockExtensions-BindableInlinesProperty 'JMWToolkit.MVVM.Extensions.TextBlockExtensions.BindableInlinesProperty')
  - [GetBindableInlines(obj)](#M-JMWToolkit-MVVM-Extensions-TextBlockExtensions-GetBindableInlines-System-Windows-DependencyObject- 'JMWToolkit.MVVM.Extensions.TextBlockExtensions.GetBindableInlines(System.Windows.DependencyObject)')
  - [OnBindableInlinesChanged(d,e)](#M-JMWToolkit-MVVM-Extensions-TextBlockExtensions-OnBindableInlinesChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'JMWToolkit.MVVM.Extensions.TextBlockExtensions.OnBindableInlinesChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [SetBindableInlines(obj,value)](#M-JMWToolkit-MVVM-Extensions-TextBlockExtensions-SetBindableInlines-System-Windows-DependencyObject,System-Collections-Generic-IEnumerable{System-Windows-Documents-Inline}- 'JMWToolkit.MVVM.Extensions.TextBlockExtensions.SetBindableInlines(System.Windows.DependencyObject,System.Collections.Generic.IEnumerable{System.Windows.Documents.Inline})')
- [ViewModelBase](#T-JMWToolkit-MVVM-ViewModels-ViewModelBase 'JMWToolkit.MVVM.ViewModels.ViewModelBase')
  - [CreateAsyncRelayCommand(execute,canExecute,properties)](#M-JMWToolkit-MVVM-ViewModels-ViewModelBase-CreateAsyncRelayCommand-System-Func{System-Threading-Tasks-Task},System-Func{System-Boolean},System-String[]- 'JMWToolkit.MVVM.ViewModels.ViewModelBase.CreateAsyncRelayCommand(System.Func{System.Threading.Tasks.Task},System.Func{System.Boolean},System.String[])')
  - [CreateAsyncRelayCommand\`\`1(execute,canExecute,properties)](#M-JMWToolkit-MVVM-ViewModels-ViewModelBase-CreateAsyncRelayCommand``1-System-Func{``0,System-Threading-Tasks-Task},System-Predicate{``0},System-String[]- 'JMWToolkit.MVVM.ViewModels.ViewModelBase.CreateAsyncRelayCommand``1(System.Func{``0,System.Threading.Tasks.Task},System.Predicate{``0},System.String[])')
  - [CreateRelayCommand(execute,canExecute,properties)](#M-JMWToolkit-MVVM-ViewModels-ViewModelBase-CreateRelayCommand-System-Action,System-Func{System-Boolean},System-String[]- 'JMWToolkit.MVVM.ViewModels.ViewModelBase.CreateRelayCommand(System.Action,System.Func{System.Boolean},System.String[])')
  - [CreateRelayCommand\`\`1(execute,canExecute,properties)](#M-JMWToolkit-MVVM-ViewModels-ViewModelBase-CreateRelayCommand``1-System-Action{``0},System-Predicate{``0},System-String[]- 'JMWToolkit.MVVM.ViewModels.ViewModelBase.CreateRelayCommand``1(System.Action{``0},System.Predicate{``0},System.String[])')
  - [OnPropertyChanged(propertyName)](#M-JMWToolkit-MVVM-ViewModels-ViewModelBase-OnPropertyChanged-System-String- 'JMWToolkit.MVVM.ViewModels.ViewModelBase.OnPropertyChanged(System.String)')

<a name='T-JMWToolkit-MVVM-Controls-ComboBoxWithAdd'></a>
## ComboBoxWithAdd `type`

##### Namespace

JMWToolkit.MVVM.Controls

##### Summary

ComboBoxWithAdd - adds an optional button to the bottom of the ComboBox drop down so that the user can choose to
add a new item into the list.

<a name='M-JMWToolkit-MVVM-Controls-ComboBoxWithAdd-#ctor'></a>
### #ctor() `constructor`

##### Summary

Default constructor for the ComboBoxWithAdd

##### Parameters

This constructor has no parameters.

<a name='F-JMWToolkit-MVVM-Controls-ComboBoxWithAdd-AddNewItemCommandParameterProperty'></a>
### AddNewItemCommandParameterProperty `constants`

##### Summary

Dependency Property so the user can also pass an additional parameter to the AddNewItemCommand

<a name='F-JMWToolkit-MVVM-Controls-ComboBoxWithAdd-AddNewItemCommandProperty'></a>
### AddNewItemCommandProperty `constants`

##### Summary

Dependency property so the user can specify an ICommand for the AddNewItemCommand

<a name='F-JMWToolkit-MVVM-Controls-ComboBoxWithAdd-AddNewItemContentProperty'></a>
### AddNewItemContentProperty `constants`

##### Summary

Dependency Property so the user can specify the content of the AddNewItem button

<a name='P-JMWToolkit-MVVM-Controls-ComboBoxWithAdd-AddNewItemCommand'></a>
### AddNewItemCommand `property`

##### Summary

The command executed with AddNewItem button is clicked

<a name='P-JMWToolkit-MVVM-Controls-ComboBoxWithAdd-AddNewItemCommandParameter'></a>
### AddNewItemCommandParameter `property`

##### Summary

Parameter to be passed to the AddNewItem Command

<a name='P-JMWToolkit-MVVM-Controls-ComboBoxWithAdd-AddNewItemContent'></a>
### AddNewItemContent `property`

##### Summary

The content to be displayed in the AddNewItem button

<a name='T-XamlGeneratedNamespace-GeneratedInternalTypeHelper'></a>
## GeneratedInternalTypeHelper `type`

##### Namespace

XamlGeneratedNamespace

##### Summary

GeneratedInternalTypeHelper

<a name='M-XamlGeneratedNamespace-GeneratedInternalTypeHelper-AddEventHandler-System-Reflection-EventInfo,System-Object,System-Delegate-'></a>
### AddEventHandler() `method`

##### Summary

AddEventHandler

##### Parameters

This method has no parameters.

<a name='M-XamlGeneratedNamespace-GeneratedInternalTypeHelper-CreateDelegate-System-Type,System-Object,System-String-'></a>
### CreateDelegate() `method`

##### Summary

CreateDelegate

##### Parameters

This method has no parameters.

<a name='M-XamlGeneratedNamespace-GeneratedInternalTypeHelper-CreateInstance-System-Type,System-Globalization-CultureInfo-'></a>
### CreateInstance() `method`

##### Summary

CreateInstance

##### Parameters

This method has no parameters.

<a name='M-XamlGeneratedNamespace-GeneratedInternalTypeHelper-GetPropertyValue-System-Reflection-PropertyInfo,System-Object,System-Globalization-CultureInfo-'></a>
### GetPropertyValue() `method`

##### Summary

GetPropertyValue

##### Parameters

This method has no parameters.

<a name='M-XamlGeneratedNamespace-GeneratedInternalTypeHelper-SetPropertyValue-System-Reflection-PropertyInfo,System-Object,System-Object,System-Globalization-CultureInfo-'></a>
### SetPropertyValue() `method`

##### Summary

SetPropertyValue

##### Parameters

This method has no parameters.

<a name='T-JMWToolkit-MVVM-Helpers-IconHelper'></a>
## IconHelper `type`

##### Namespace

JMWToolkit.MVVM.Helpers

##### Summary

The IconHelper is a static class which exposes a single method to remove the icon from
the window decoration. It is used by MessageBoxEx but can be used on any Window.

<a name='M-JMWToolkit-MVVM-Helpers-IconHelper-RemoveIcon-System-Windows-Window-'></a>
### RemoveIcon(window) `method`

##### Summary

Removes the Icon from the Window.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| window | [System.Windows.Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Window 'System.Windows.Window') |  |

<a name='T-JMWToolkit-MVVM-Dialogs-MessageBoxEx'></a>
## MessageBoxEx `type`

##### Namespace

JMWToolkit.MVVM.Dialogs

##### Summary

Class used to Show a MessageBox dialog that allows formatted text for the caption. This
is very similiar to the built in MessageBox class but with the text enhancements for the
caption. I will continue to add more features but for now the
Caption area allows you to specify <break> in a line when you want a paragraph break.

<a name='M-JMWToolkit-MVVM-Dialogs-MessageBoxEx-ShowDialog-System-String,System-String,System-Windows-MessageBoxButton,System-Windows-MessageBoxImage-'></a>
### ShowDialog(caption,title,buttons,image) `method`

##### Summary

Show the dialog and return when the user makes one of the choices.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| caption | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The caption to be displayed. This can be a multiline paragraph string
with ;lt;break> in between paragraph. |
| title | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The title to be displayed |
| buttons | [System.Windows.MessageBoxButton](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.MessageBoxButton 'System.Windows.MessageBoxButton') | One of the MessageBoxButton values, defaults to MessageBoxButton.OK |
| image | [System.Windows.MessageBoxImage](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.MessageBoxImage 'System.Windows.MessageBoxImage') | This is one of the enum values MessageBoxImage.Information, MessageBoxImage.Warning, 
    MessageBoxImage.Error, or MessageBoxImage.Question defaults to MessageBoxImage.Informormation |

<a name='T-JMWToolkit-MVVM-ViewModels-MessageBoxExViewModel'></a>
## MessageBoxExViewModel `type`

##### Namespace

JMWToolkit.MVVM.ViewModels

<a name='P-JMWToolkit-MVVM-ViewModels-MessageBoxExViewModel-OkButtonText'></a>
### OkButtonText `property`

##### Summary

Expose the button labels as Properties on the MessageBoxEx so that a caller can modify them for
localization.

<a name='T-JMWToolkit-MVVM-Dialogs-MessageBoxExWindow'></a>
## MessageBoxExWindow `type`

##### Namespace

JMWToolkit.MVVM.Dialogs

##### Summary

MessageBoxEx - does a better job of formatting the messages when they are long. It automatically
adds in the line breaks where needed.

<a name='M-JMWToolkit-MVVM-Dialogs-MessageBoxExWindow-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-JMWToolkit-MVVM-ValueConverters-MultilineTextConverter'></a>
## MultilineTextConverter `type`

##### Namespace

JMWToolkit.MVVM.ValueConverters

##### Summary

The MultilineTextConverter is used to convert a string with <break> lines in it to multiline
text.
    - A single newline is trimmed from the start of the string
    - Any trailing newline characters are trimmed.
    - Lines are broken at the <break>
    - Trailing whitespace is removed from the last line.

<a name='M-JMWToolkit-MVVM-ValueConverters-MultilineTextConverter-Convert-System-Object,System-Type,System-Object,System-Globalization-CultureInfo-'></a>
### Convert(value,targetType,parameter,culture) `method`

##### Summary

Converts the passed in string to a collection of Inline objects.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | string to be parsed and formatted |
| targetType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | type of the target property |
| parameter | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | converter parameter |
| culture | [System.Globalization.CultureInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Globalization.CultureInfo 'System.Globalization.CultureInfo') | The culture to use in the converter |

<a name='M-JMWToolkit-MVVM-ValueConverters-MultilineTextConverter-ConvertBack-System-Object,System-Type,System-Object,System-Globalization-CultureInfo-'></a>
### ConvertBack(value,targetType,parameter,culture) `method`

##### Summary

This routine is not implemented

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | ignored |
| targetType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | ignored |
| parameter | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | ignored |
| culture | [System.Globalization.CultureInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Globalization.CultureInfo 'System.Globalization.CultureInfo') | ignored |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NotImplementedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotImplementedException 'System.NotImplementedException') |  |

<a name='M-JMWToolkit-MVVM-ValueConverters-MultilineTextConverter-_spacesAndNewLine'></a>
### _spacesAndNewLine() `method`

##### Parameters

This method has no parameters.

##### Remarks

Pattern explanation:

```
○ Match ' ' atomically any number of times.
```

<a name='T-System-Text-RegularExpressions-Generated-_spacesAndNewLine_0-RunnerFactory-Runner'></a>
## Runner `type`

##### Namespace

System.Text.RegularExpressions.Generated._spacesAndNewLine_0.RunnerFactory

##### Summary

Provides the runner that contains the custom logic implementing the specified regular expression.

<a name='M-System-Text-RegularExpressions-Generated-_spacesAndNewLine_0-RunnerFactory-Runner-Scan-System-ReadOnlySpan{System-Char}-'></a>
### Scan(inputSpan) `method`

##### Summary

Scan the `inputSpan` starting from base.runtextstart for the next match.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| inputSpan | [System.ReadOnlySpan{System.Char}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan 'System.ReadOnlySpan{System.Char}') | The text being scanned by the regular expression. |

<a name='M-System-Text-RegularExpressions-Generated-_spacesAndNewLine_0-RunnerFactory-Runner-TryFindNextPossibleStartingPosition-System-ReadOnlySpan{System-Char}-'></a>
### TryFindNextPossibleStartingPosition(inputSpan) `method`

##### Summary

Search `inputSpan` starting from base.runtextpos for the next location a match could possibly start.

##### Returns

true if a possible match was found; false if no more matches are possible.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| inputSpan | [System.ReadOnlySpan{System.Char}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan 'System.ReadOnlySpan{System.Char}') | The text being scanned by the regular expression. |

<a name='M-System-Text-RegularExpressions-Generated-_spacesAndNewLine_0-RunnerFactory-Runner-TryMatchAtCurrentPosition-System-ReadOnlySpan{System-Char}-'></a>
### TryMatchAtCurrentPosition(inputSpan) `method`

##### Summary

Determine whether `inputSpan` at base.runtextpos is a match for the regular expression.

##### Returns

true if the regular expression matches at the current position; otherwise, false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| inputSpan | [System.ReadOnlySpan{System.Char}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan 'System.ReadOnlySpan{System.Char}') | The text being scanned by the regular expression. |

<a name='T-System-Text-RegularExpressions-Generated-_spacesAndNewLine_0-RunnerFactory'></a>
## RunnerFactory `type`

##### Namespace

System.Text.RegularExpressions.Generated._spacesAndNewLine_0

##### Summary

Provides a factory for creating [RegexRunner](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.RegularExpressions.RegexRunner 'System.Text.RegularExpressions.RegexRunner') instances to be used by methods on [Regex](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.RegularExpressions.Regex 'System.Text.RegularExpressions.Regex').

<a name='M-System-Text-RegularExpressions-Generated-_spacesAndNewLine_0-RunnerFactory-CreateInstance'></a>
### CreateInstance() `method`

##### Summary

Creates an instance of a [RegexRunner](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.RegularExpressions.RegexRunner 'System.Text.RegularExpressions.RegexRunner') used by methods on [Regex](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.RegularExpressions.Regex 'System.Text.RegularExpressions.Regex').

##### Parameters

This method has no parameters.

<a name='T-JMWToolkit-MVVM-Helpers-StringResourceHelpers'></a>
## StringResourceHelpers `type`

##### Namespace

JMWToolkit.MVVM.Helpers

##### Summary

Static StringHelpers. I am sure this class will grow over time. For now two simple
routines to load a string resource.

<a name='M-JMWToolkit-MVVM-Helpers-StringResourceHelpers-LoadAndFormatStringResource-System-String,System-Object[]-'></a>
### LoadAndFormatStringResource(format,args) `method`

##### Summary

Loads a string resource and then formats it with the supplied parameters

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Resource Id for the string format |
| args | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | Variable list of arguments for the string format |

<a name='M-JMWToolkit-MVVM-Helpers-StringResourceHelpers-LoadStringResource-System-String-'></a>
### LoadStringResource(resourceId) `method`

##### Summary

Simply loads the string specified by the resourceId

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resourceId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Id of the string to load |

<a name='T-JMWToolkit-MVVM-Extensions-TextBlockExtensions'></a>
## TextBlockExtensions `type`

##### Namespace

JMWToolkit.MVVM.Extensions

##### Summary

The TextBlockExtension is used to replace the InlineCollection on a TextBlock. It should be used in connection with
the MultilineTextConverter.cs which will takes a string and produces a List<Inline> to be used in the TextBlock.

<a name='F-JMWToolkit-MVVM-Extensions-TextBlockExtensions-BindableInlinesProperty'></a>
### BindableInlinesProperty `constants`

##### Summary

Property for binding a collection of Inline objects to a control

<a name='M-JMWToolkit-MVVM-Extensions-TextBlockExtensions-GetBindableInlines-System-Windows-DependencyObject-'></a>
### GetBindableInlines(obj) `method`

##### Summary

Gets the BindableLines property from a control

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | control on which the property has been set |

<a name='M-JMWToolkit-MVVM-Extensions-TextBlockExtensions-OnBindableInlinesChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnBindableInlinesChanged(d,e) `method`

##### Summary

delegate to be called when the BindableLines property is updated

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The dependency object which is the target, everything but TextBlock is ignored |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | The DependencyPropertyChangedEventArgs with the new value |

<a name='M-JMWToolkit-MVVM-Extensions-TextBlockExtensions-SetBindableInlines-System-Windows-DependencyObject,System-Collections-Generic-IEnumerable{System-Windows-Documents-Inline}-'></a>
### SetBindableInlines(obj,value) `method`

##### Summary

Sets the BindableLines property on a control

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | object to set the property on |
| value | [System.Collections.Generic.IEnumerable{System.Windows.Documents.Inline}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Windows.Documents.Inline}') | a collection of InLine objects |

<a name='T-System-Text-RegularExpressions-Generated-Utilities'></a>
## Utilities `type`

##### Namespace

System.Text.RegularExpressions.Generated

##### Summary

Helper methods used by generated [Regex](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.RegularExpressions.Regex 'System.Text.RegularExpressions.Regex')-derived implementations.

<a name='F-System-Text-RegularExpressions-Generated-Utilities-s_defaultTimeout'></a>
### s_defaultTimeout `constants`

##### Summary

Default timeout value set in [AppContext](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.AppContext 'System.AppContext'), or [InfiniteMatchTimeout](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.RegularExpressions.Regex.InfiniteMatchTimeout 'System.Text.RegularExpressions.Regex.InfiniteMatchTimeout') if none was set.

<a name='F-System-Text-RegularExpressions-Generated-Utilities-s_hasTimeout'></a>
### s_hasTimeout `constants`

##### Summary

Whether [s_defaultTimeout](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.RegularExpressions.Generated.Utilities.s_defaultTimeout 'System.Text.RegularExpressions.Generated.Utilities.s_defaultTimeout') is non-infinite.

<a name='T-JMWToolkit-MVVM-ViewModels-ViewModelBase'></a>
## ViewModelBase `type`

##### Namespace

JMWToolkit.MVVM.ViewModels

##### Summary

My personal ViewModelBase class. It implements INotifyPropertyChanged like most others.
On top of that is adds commands to create RelayCommand's and AsyncRelayCommands. These
methods take an optional list of properties that will cause the NotifyCanExecuteChanged
method to be called.

<a name='M-JMWToolkit-MVVM-ViewModels-ViewModelBase-CreateAsyncRelayCommand-System-Func{System-Threading-Tasks-Task},System-Func{System-Boolean},System-String[]-'></a>
### CreateAsyncRelayCommand(execute,canExecute,properties) `method`

##### Summary

Helper function to create an AsyncRelayCommand for the ViewModel. The ViewModelBase will call NotifyCanExecuteChanged
when one of the supplied properties changes.

##### Returns

A new AsyncRelayCommand

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| execute | [System.Func{System.Threading.Tasks.Task}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Threading.Tasks.Task}') | Function to be executed when command is clicked. |
| canExecute | [System.Func{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Boolean}') | Function to determine if the command should be enabled. |
| properties | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | List of properties which can cause the result of canExecute to change. |

<a name='M-JMWToolkit-MVVM-ViewModels-ViewModelBase-CreateAsyncRelayCommand``1-System-Func{``0,System-Threading-Tasks-Task},System-Predicate{``0},System-String[]-'></a>
### CreateAsyncRelayCommand\`\`1(execute,canExecute,properties) `method`

##### Summary

Helper function to create an AsyncRelayCommand for the ViewModel. The ViewModelBase will call NotifyCanExecuteChanged
when one of the supplied properties changes.

##### Returns

A new AsyncRelayCommand

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| execute | [System.Func{\`\`0,System.Threading.Tasks.Task}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Threading.Tasks.Task}') | Function to be executed when command is clicked. |
| canExecute | [System.Predicate{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{``0}') | Function to determine if the command should be enabled. |
| properties | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | List of properties which can cause the result of canExecute to change. |

<a name='M-JMWToolkit-MVVM-ViewModels-ViewModelBase-CreateRelayCommand-System-Action,System-Func{System-Boolean},System-String[]-'></a>
### CreateRelayCommand(execute,canExecute,properties) `method`

##### Summary

Helper function to create an RelayCommand for the ViewModel. The ViewModelBase will call NotifyCanExecuteChanged
when one of the supplied properties changes.

##### Returns

A new RelayCommand

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| execute | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | Function to be executed when command is clicked. |
| canExecute | [System.Func{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Boolean}') | Function to determine if the command should be enabled. |
| properties | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | List of properties which can cause the result of canExecute to change. |

<a name='M-JMWToolkit-MVVM-ViewModels-ViewModelBase-CreateRelayCommand``1-System-Action{``0},System-Predicate{``0},System-String[]-'></a>
### CreateRelayCommand\`\`1(execute,canExecute,properties) `method`

##### Summary

Helper function to create an RelayCommand for the ViewModel. The ViewModelBase will call NotifyCanExecuteChanged
when one of the supplied properties changes.

##### Returns

A new RelayCommand

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| execute | [System.Action{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{``0}') | Function to be executed when command is clicked. |
| canExecute | [System.Predicate{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{``0}') | Function to determine if the command should be enabled. |
| properties | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | List of properties which can cause the result of canExecute to change. |

<a name='M-JMWToolkit-MVVM-ViewModels-ViewModelBase-OnPropertyChanged-System-String-'></a>
### OnPropertyChanged(propertyName) `method`

##### Summary

Methods derived classes should call when a property value is changed to notify clients.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-System-Text-RegularExpressions-Generated-_spacesAndNewLine_0'></a>
## _spacesAndNewLine_0 `type`

##### Namespace

System.Text.RegularExpressions.Generated

##### Summary

Custom [Regex](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.RegularExpressions.Regex 'System.Text.RegularExpressions.Regex')-derived type for the _spacesAndNewLine method.

<a name='M-System-Text-RegularExpressions-Generated-_spacesAndNewLine_0-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes the instance.

##### Parameters

This constructor has no parameters.

<a name='F-System-Text-RegularExpressions-Generated-_spacesAndNewLine_0-Instance'></a>
### Instance `constants`

##### Summary

Cached, thread-safe singleton instance.
