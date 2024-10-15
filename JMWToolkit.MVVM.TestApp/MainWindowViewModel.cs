using CommunityToolkit.Mvvm.Input;
using JMWToolkit.MVVM.Dialogs;
using JMWToolkit.MVVM.Helpers;
using JMWToolkit.MVVM.ViewModels;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace JMWToolkit.MVVM.TestApp;

public record struct MessageBoxImageEntry(MessageBoxImage Image, string Description, ImageSource? ImageSource);

public class MainWindowViewModel : MoveableWindowViewModel
{
    public MainWindowViewModel()
    {
        NormalButtonClickedCommand = CreateRelayCommand(
            () => ClickedButtonMessage = "NormalButtonPressedMessage".LoadFromResource(),
            () => true
        );

        DefaultButtonClickedCommand = CreateRelayCommand(
            () => ClickedButtonMessage = "DefaultButtonPressedMessage".LoadFromResource(),
            () => true
        );

        ClickedButtonMessage = "InitialButtonPressedMessage".LoadFromResource();

        ShowMessageBoxCommand = CreateRelayCommand(
            () =>
            {
                MessageBoxEx.ShowDialog(MessageBoxCaption ?? string.Empty, MessageBoxTitle ?? string.Empty, MessageBoxButton.OK, MessageBoxImageEntry.Image);
            },
            () => true
        );

        ResizeModeChangedCommand = CreateRelayCommand<ResizeMode>(
            (resizeMode) =>
            {
                ResizeMode = resizeMode;
            },
            (resizeMode) => true);

        ResizeModes.Add(System.Windows.ResizeMode.NoResize);
        ResizeModes.Add(System.Windows.ResizeMode.CanMinimize);
        ResizeModes.Add(System.Windows.ResizeMode.CanResize);
        ResizeModes.Add(System.Windows.ResizeMode.CanResizeWithGrip);

        MessageBoxImageEntries.Add(new(MessageBoxImage.None, "MessageBoxImage.None.Description".LoadFromResource(), MessageBoxEx.GetMessageBoxImageSource(System.Windows.MessageBoxImage.None)));
        MessageBoxImageEntries.Add(new(MessageBoxImage.Information, "MessageBoxImage.Information.Description".LoadFromResource(), MessageBoxEx.GetMessageBoxImageSource(System.Windows.MessageBoxImage.Information)));
        MessageBoxImageEntries.Add(new(MessageBoxImage.Warning, "MessageBoxImage.Warning.Description".LoadFromResource(), MessageBoxEx.GetMessageBoxImageSource(System.Windows.MessageBoxImage.Warning)));
        MessageBoxImageEntries.Add(new(MessageBoxImage.Question, "MessageBoxImage.Question.Description".LoadFromResource(), MessageBoxEx.GetMessageBoxImageSource(System.Windows.MessageBoxImage.Question)));
        MessageBoxImageEntries.Add(new(MessageBoxImage.Error, "MessageBoxImage.Error.Description".LoadFromResource(), MessageBoxEx.GetMessageBoxImageSource(System.Windows.MessageBoxImage.Error)));
        MessageBoxImageEntry = MessageBoxImageEntries[1];

        _messageBoxTitle = "SampleMessageBoxTitle".LoadFromResource();
        _messageBoxCaption = "SampleMessageBoxCaption".LoadFromResource();
    }

    public ICommand DefaultButtonClickedCommand { get; }
    public ICommand NormalButtonClickedCommand { get; }
    public ICommand ShowMessageBoxCommand { get; }
    public IRelayCommand<ResizeMode> ResizeModeChangedCommand { get; }

    private string? _clickedButtonMessage;
    public string? ClickedButtonMessage
    {
        get => _clickedButtonMessage;
        set => SetProperty(ref _clickedButtonMessage, value);
    }

    public ObservableCollection<ResizeMode> ResizeModes { get; } = [];

    private ResizeMode _resizeMode = System.Windows.ResizeMode.CanResizeWithGrip;
    public ResizeMode ResizeMode
    {
        get => _resizeMode;
        set => SetProperty(ref _resizeMode, value);
    }

    public ObservableCollection<MessageBoxImageEntry> MessageBoxImageEntries { get; } = [];

    private MessageBoxImageEntry _messageBoxImageEntry;
    public MessageBoxImageEntry MessageBoxImageEntry
    {
        get => _messageBoxImageEntry;
        set => SetProperty(ref _messageBoxImageEntry, value);
    }

    public string? _messageBoxTitle;
    public string? MessageBoxTitle
    {
        get => _messageBoxTitle;
        set => SetProperty(ref _messageBoxTitle, value);
    }

    public string? _messageBoxCaption;
    public string? MessageBoxCaption
    {
        get => _messageBoxCaption;
        set => SetProperty(ref _messageBoxCaption, value);
    }
}
