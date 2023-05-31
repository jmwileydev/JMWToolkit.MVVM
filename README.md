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
A message box that allows the user to specify text with newlines.

