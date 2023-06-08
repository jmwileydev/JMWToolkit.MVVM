# JMWToolkit.MVVM
A toolkit with some common classes used in my WPF MVVM projects

## IconHelper
This class is actually a copy of a class that I found online. It was posted in a blog by Christian Moser. Here
is a link to the article - https://www.wpftutorial.net/RemoveIcon.html. The class is used to remove the icon
from the title bar of a .Net Window. I use it in my MessageBoxEx class which is used to display a custom message
box into which I can multiple lines.

## StringHelper
This class is simply a place to throw some helpers for Strings. I am sure it will grow over time.

**LoadAndFormatResource(string format, params object[] args)** - This routine is used to load a String resource and format it using the
supplied arguments.<br>
*String format - this is the identifier for the string resource to be loaded.
*object[] args - this is the arguments to be substituted into the string

**LoadStringResource(string resourceId)** - This routine simply loads the desired resource and casts it to a string.

## ViewModelBase
This class is a ViewModel base class that implements INotifyPropertyChanged. It also adds routines to create 
*CommunityToolkit.Mvvm.Input.RelayCommand's* and *CommunityToolkit.Mvvm.Input.AsyncRelayCommand's*. The functions take an function to
execute, a predicate for CanExecute and also a list of properties that could cause the CanExecute value to change. When OnPropertyChanged
is called if needed it will call **Command.NotifyCanExecuteChanged** to let the CommandManager know about the possible change.<br>

**RelayCommand CreateRelayCommand(Action execute, Func<bool> canExecute, params string[] properties)**
**RelayCommand<T> CreateRelayCommand<T>(Action<T?> execute, Predicate<T?> canExecute, params string[] properties)**
**AsyncRelayCommand CreateAsyncRelayCommand(Func<Task> execute, Func<bool> canExecute, params string[] properties)**
**AsyncRelayCommand<T> CreateAsyncRelayCommand<T>(Func<T?, Task> execute, Predicate<T?> canExecute, params string[] properties)**

TODO add more comments for the above commands

## ComboBoxEx
A combo box that has an AddNewButton that the user can enable and show.

## MessageBoxEx
This is a message box for displaying some custom messages. I will continue to add more features but for now the
Caption area allows you to specify <break> in a line when you want a paragraph break. For instance if you specify
your string resource as follows:
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
