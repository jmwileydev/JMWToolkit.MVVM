<a name='assembly'></a>
# JMWToolkit.MVVM

## Contents

- [BooleanToVisibilityConverter](#T-JMWToolkit-MVVM-Converters-BooleanToVisibilityConverter 'JMWToolkit.MVVM.Converters.BooleanToVisibilityConverter')
  - [Convert(value,targetType,parameter,culture)](#M-JMWToolkit-MVVM-Converters-BooleanToVisibilityConverter-Convert-System-Object,System-Type,System-Object,System-Globalization-CultureInfo- 'JMWToolkit.MVVM.Converters.BooleanToVisibilityConverter.Convert(System.Object,System.Type,System.Object,System.Globalization.CultureInfo)')
  - [ConvertBack(value,targetType,parameter,culture)](#M-JMWToolkit-MVVM-Converters-BooleanToVisibilityConverter-ConvertBack-System-Object,System-Type,System-Object,System-Globalization-CultureInfo- 'JMWToolkit.MVVM.Converters.BooleanToVisibilityConverter.ConvertBack(System.Object,System.Type,System.Object,System.Globalization.CultureInfo)')
- [ComboBoxWithAdd](#T-JMWToolkit-MVVM-Controls-ComboBoxWithAdd 'JMWToolkit.MVVM.Controls.ComboBoxWithAdd')
  - [AddNewItemCommandParameterProperty](#F-JMWToolkit-MVVM-Controls-ComboBoxWithAdd-AddNewItemCommandParameterProperty 'JMWToolkit.MVVM.Controls.ComboBoxWithAdd.AddNewItemCommandParameterProperty')
  - [AddNewItemCommandProperty](#F-JMWToolkit-MVVM-Controls-ComboBoxWithAdd-AddNewItemCommandProperty 'JMWToolkit.MVVM.Controls.ComboBoxWithAdd.AddNewItemCommandProperty')
  - [AddNewItemContentProperty](#F-JMWToolkit-MVVM-Controls-ComboBoxWithAdd-AddNewItemContentProperty 'JMWToolkit.MVVM.Controls.ComboBoxWithAdd.AddNewItemContentProperty')
  - [AddNewItemCommand](#P-JMWToolkit-MVVM-Controls-ComboBoxWithAdd-AddNewItemCommand 'JMWToolkit.MVVM.Controls.ComboBoxWithAdd.AddNewItemCommand')
  - [AddNewItemCommandParameter](#P-JMWToolkit-MVVM-Controls-ComboBoxWithAdd-AddNewItemCommandParameter 'JMWToolkit.MVVM.Controls.ComboBoxWithAdd.AddNewItemCommandParameter')
  - [AddNewItemContent](#P-JMWToolkit-MVVM-Controls-ComboBoxWithAdd-AddNewItemContent 'JMWToolkit.MVVM.Controls.ComboBoxWithAdd.AddNewItemContent')
  - [#cctor()](#M-JMWToolkit-MVVM-Controls-ComboBoxWithAdd-#cctor 'JMWToolkit.MVVM.Controls.ComboBoxWithAdd.#cctor')
- [CountToVisibilityArguments](#T-JMWToolkit-MVVM-Converters-CountToVisibilityArguments 'JMWToolkit.MVVM.Converters.CountToVisibilityArguments')
  - [Count](#P-JMWToolkit-MVVM-Converters-CountToVisibilityArguments-Count 'JMWToolkit.MVVM.Converters.CountToVisibilityArguments.Count')
  - [Operator](#P-JMWToolkit-MVVM-Converters-CountToVisibilityArguments-Operator 'JMWToolkit.MVVM.Converters.CountToVisibilityArguments.Operator')
  - [VisibilityConverterMode](#P-JMWToolkit-MVVM-Converters-CountToVisibilityArguments-VisibilityConverterMode 'JMWToolkit.MVVM.Converters.CountToVisibilityArguments.VisibilityConverterMode')
- [CountToVisibilityConverter](#T-JMWToolkit-MVVM-Converters-CountToVisibilityConverter 'JMWToolkit.MVVM.Converters.CountToVisibilityConverter')
  - [Convert(value,targetType,parameter,culture)](#M-JMWToolkit-MVVM-Converters-CountToVisibilityConverter-Convert-System-Object,System-Type,System-Object,System-Globalization-CultureInfo- 'JMWToolkit.MVVM.Converters.CountToVisibilityConverter.Convert(System.Object,System.Type,System.Object,System.Globalization.CultureInfo)')
  - [ConvertBack(value,targetType,parameter,culture)](#M-JMWToolkit-MVVM-Converters-CountToVisibilityConverter-ConvertBack-System-Object,System-Type,System-Object,System-Globalization-CultureInfo- 'JMWToolkit.MVVM.Converters.CountToVisibilityConverter.ConvertBack(System.Object,System.Type,System.Object,System.Globalization.CultureInfo)')
- [CountToVisibilityOperator](#T-JMWToolkit-MVVM-Converters-CountToVisibilityOperator 'JMWToolkit.MVVM.Converters.CountToVisibilityOperator')
  - [Equals](#F-JMWToolkit-MVVM-Converters-CountToVisibilityOperator-Equals 'JMWToolkit.MVVM.Converters.CountToVisibilityOperator.Equals')
  - [GreaterThan](#F-JMWToolkit-MVVM-Converters-CountToVisibilityOperator-GreaterThan 'JMWToolkit.MVVM.Converters.CountToVisibilityOperator.GreaterThan')
  - [GreaterThanOrEqual](#F-JMWToolkit-MVVM-Converters-CountToVisibilityOperator-GreaterThanOrEqual 'JMWToolkit.MVVM.Converters.CountToVisibilityOperator.GreaterThanOrEqual')
  - [LessThan](#F-JMWToolkit-MVVM-Converters-CountToVisibilityOperator-LessThan 'JMWToolkit.MVVM.Converters.CountToVisibilityOperator.LessThan')
  - [LessThanOrEqual](#F-JMWToolkit-MVVM-Converters-CountToVisibilityOperator-LessThanOrEqual 'JMWToolkit.MVVM.Converters.CountToVisibilityOperator.LessThanOrEqual')
  - [NotEqual](#F-JMWToolkit-MVVM-Converters-CountToVisibilityOperator-NotEqual 'JMWToolkit.MVVM.Converters.CountToVisibilityOperator.NotEqual')
- [CustomTextBox](#T-JMWToolkit-MVVM-Controls-CustomTextBox 'JMWToolkit.MVVM.Controls.CustomTextBox')
  - [CornerRadiusProperty](#F-JMWToolkit-MVVM-Controls-CustomTextBox-CornerRadiusProperty 'JMWToolkit.MVVM.Controls.CustomTextBox.CornerRadiusProperty')
  - [PlaceholderTextBrushProperty](#F-JMWToolkit-MVVM-Controls-CustomTextBox-PlaceholderTextBrushProperty 'JMWToolkit.MVVM.Controls.CustomTextBox.PlaceholderTextBrushProperty')
  - [PlaceholderTextProperty](#F-JMWToolkit-MVVM-Controls-CustomTextBox-PlaceholderTextProperty 'JMWToolkit.MVVM.Controls.CustomTextBox.PlaceholderTextProperty')
  - [CornerRadius](#P-JMWToolkit-MVVM-Controls-CustomTextBox-CornerRadius 'JMWToolkit.MVVM.Controls.CustomTextBox.CornerRadius')
  - [PlaceholderText](#P-JMWToolkit-MVVM-Controls-CustomTextBox-PlaceholderText 'JMWToolkit.MVVM.Controls.CustomTextBox.PlaceholderText')
  - [PlaceholderTextBrush](#P-JMWToolkit-MVVM-Controls-CustomTextBox-PlaceholderTextBrush 'JMWToolkit.MVVM.Controls.CustomTextBox.PlaceholderTextBrush')
- [GeneratedInternalTypeHelper](#T-XamlGeneratedNamespace-GeneratedInternalTypeHelper 'XamlGeneratedNamespace.GeneratedInternalTypeHelper')
  - [AddEventHandler()](#M-XamlGeneratedNamespace-GeneratedInternalTypeHelper-AddEventHandler-System-Reflection-EventInfo,System-Object,System-Delegate- 'XamlGeneratedNamespace.GeneratedInternalTypeHelper.AddEventHandler(System.Reflection.EventInfo,System.Object,System.Delegate)')
  - [CreateDelegate()](#M-XamlGeneratedNamespace-GeneratedInternalTypeHelper-CreateDelegate-System-Type,System-Object,System-String- 'XamlGeneratedNamespace.GeneratedInternalTypeHelper.CreateDelegate(System.Type,System.Object,System.String)')
  - [CreateInstance()](#M-XamlGeneratedNamespace-GeneratedInternalTypeHelper-CreateInstance-System-Type,System-Globalization-CultureInfo- 'XamlGeneratedNamespace.GeneratedInternalTypeHelper.CreateInstance(System.Type,System.Globalization.CultureInfo)')
  - [GetPropertyValue()](#M-XamlGeneratedNamespace-GeneratedInternalTypeHelper-GetPropertyValue-System-Reflection-PropertyInfo,System-Object,System-Globalization-CultureInfo- 'XamlGeneratedNamespace.GeneratedInternalTypeHelper.GetPropertyValue(System.Reflection.PropertyInfo,System.Object,System.Globalization.CultureInfo)')
  - [SetPropertyValue()](#M-XamlGeneratedNamespace-GeneratedInternalTypeHelper-SetPropertyValue-System-Reflection-PropertyInfo,System-Object,System-Object,System-Globalization-CultureInfo- 'XamlGeneratedNamespace.GeneratedInternalTypeHelper.SetPropertyValue(System.Reflection.PropertyInfo,System.Object,System.Object,System.Globalization.CultureInfo)')
- [IDispatcher](#T-JMWToolkit-MVVM-Interfaces-IDispatcher 'JMWToolkit.MVVM.Interfaces.IDispatcher')
  - [BeginInvoke(method,args)](#M-JMWToolkit-MVVM-Interfaces-IDispatcher-BeginInvoke-System-Delegate,System-Object[]- 'JMWToolkit.MVVM.Interfaces.IDispatcher.BeginInvoke(System.Delegate,System.Object[])')
- [IconHelper](#T-JMWToolkit-MVVM-Helpers-IconHelper 'JMWToolkit.MVVM.Helpers.IconHelper')
  - [RemoveIcon(window)](#M-JMWToolkit-MVVM-Helpers-IconHelper-RemoveIcon-System-Windows-Window- 'JMWToolkit.MVVM.Helpers.IconHelper.RemoveIcon(System.Windows.Window)')
- [MessageBoxEx](#T-JMWToolkit-MVVM-Dialogs-MessageBoxEx 'JMWToolkit.MVVM.Dialogs.MessageBoxEx')
  - [GetMessageBoxImageSource(messageBoxImage)](#M-JMWToolkit-MVVM-Dialogs-MessageBoxEx-GetMessageBoxImageSource-System-Windows-MessageBoxImage- 'JMWToolkit.MVVM.Dialogs.MessageBoxEx.GetMessageBoxImageSource(System.Windows.MessageBoxImage)')
  - [ShowDialog(caption,title,buttons,image)](#M-JMWToolkit-MVVM-Dialogs-MessageBoxEx-ShowDialog-System-String,System-String,System-Windows-MessageBoxButton,System-Windows-MessageBoxImage- 'JMWToolkit.MVVM.Dialogs.MessageBoxEx.ShowDialog(System.String,System.String,System.Windows.MessageBoxButton,System.Windows.MessageBoxImage)')
- [MessageBoxExWindow](#T-JMWToolkit-MVVM-Dialogs-MessageBoxExWindow 'JMWToolkit.MVVM.Dialogs.MessageBoxExWindow')
  - [InitializeComponent()](#M-JMWToolkit-MVVM-Dialogs-MessageBoxExWindow-InitializeComponent 'JMWToolkit.MVVM.Dialogs.MessageBoxExWindow.InitializeComponent')
- [MoveableWindow](#T-JMWToolkit-MVVM-Controls-MoveableWindow 'JMWToolkit.MVVM.Controls.MoveableWindow')
  - [#ctor()](#M-JMWToolkit-MVVM-Controls-MoveableWindow-#ctor 'JMWToolkit.MVVM.Controls.MoveableWindow.#ctor')
  - [CloseCommandPropertyKey](#F-JMWToolkit-MVVM-Controls-MoveableWindow-CloseCommandPropertyKey 'JMWToolkit.MVVM.Controls.MoveableWindow.CloseCommandPropertyKey')
  - [CloseableProperty](#F-JMWToolkit-MVVM-Controls-MoveableWindow-CloseableProperty 'JMWToolkit.MVVM.Controls.MoveableWindow.CloseableProperty')
  - [MaximizeCommandPropertyKey](#F-JMWToolkit-MVVM-Controls-MoveableWindow-MaximizeCommandPropertyKey 'JMWToolkit.MVVM.Controls.MoveableWindow.MaximizeCommandPropertyKey')
  - [MinimizeCommandPropertyKey](#F-JMWToolkit-MVVM-Controls-MoveableWindow-MinimizeCommandPropertyKey 'JMWToolkit.MVVM.Controls.MoveableWindow.MinimizeCommandPropertyKey')
  - [OverlapCommandPropertyKey](#F-JMWToolkit-MVVM-Controls-MoveableWindow-OverlapCommandPropertyKey 'JMWToolkit.MVVM.Controls.MoveableWindow.OverlapCommandPropertyKey')
  - [ResizableProperty](#F-JMWToolkit-MVVM-Controls-MoveableWindow-ResizableProperty 'JMWToolkit.MVVM.Controls.MoveableWindow.ResizableProperty')
  - [CloseCommand](#P-JMWToolkit-MVVM-Controls-MoveableWindow-CloseCommand 'JMWToolkit.MVVM.Controls.MoveableWindow.CloseCommand')
  - [Closeable](#P-JMWToolkit-MVVM-Controls-MoveableWindow-Closeable 'JMWToolkit.MVVM.Controls.MoveableWindow.Closeable')
  - [MaximizeCommand](#P-JMWToolkit-MVVM-Controls-MoveableWindow-MaximizeCommand 'JMWToolkit.MVVM.Controls.MoveableWindow.MaximizeCommand')
  - [MinimizeCommand](#P-JMWToolkit-MVVM-Controls-MoveableWindow-MinimizeCommand 'JMWToolkit.MVVM.Controls.MoveableWindow.MinimizeCommand')
  - [OverlapCommand](#P-JMWToolkit-MVVM-Controls-MoveableWindow-OverlapCommand 'JMWToolkit.MVVM.Controls.MoveableWindow.OverlapCommand')
  - [Resizable](#P-JMWToolkit-MVVM-Controls-MoveableWindow-Resizable 'JMWToolkit.MVVM.Controls.MoveableWindow.Resizable')
  - [MoveableWindow_Loaded(sender,e)](#M-JMWToolkit-MVVM-Controls-MoveableWindow-MoveableWindow_Loaded-System-Object,System-Windows-RoutedEventArgs- 'JMWToolkit.MVVM.Controls.MoveableWindow.MoveableWindow_Loaded(System.Object,System.Windows.RoutedEventArgs)')
  - [OnClosed(e)](#M-JMWToolkit-MVVM-Controls-MoveableWindow-OnClosed-System-EventArgs- 'JMWToolkit.MVVM.Controls.MoveableWindow.OnClosed(System.EventArgs)')
  - [OnClosing(e)](#M-JMWToolkit-MVVM-Controls-MoveableWindow-OnClosing-System-ComponentModel-CancelEventArgs- 'JMWToolkit.MVVM.Controls.MoveableWindow.OnClosing(System.ComponentModel.CancelEventArgs)')
  - [OnPropertyChanged(e)](#M-JMWToolkit-MVVM-Controls-MoveableWindow-OnPropertyChanged-System-Windows-DependencyPropertyChangedEventArgs- 'JMWToolkit.MVVM.Controls.MoveableWindow.OnPropertyChanged(System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnStateChanged(e)](#M-JMWToolkit-MVVM-Controls-MoveableWindow-OnStateChanged-System-EventArgs- 'JMWToolkit.MVVM.Controls.MoveableWindow.OnStateChanged(System.EventArgs)')
- [MoveableWindowViewModel](#T-JMWToolkit-MVVM-ViewModels-MoveableWindowViewModel 'JMWToolkit.MVVM.ViewModels.MoveableWindowViewModel')
  - [Closeable](#P-JMWToolkit-MVVM-ViewModels-MoveableWindowViewModel-Closeable 'JMWToolkit.MVVM.ViewModels.MoveableWindowViewModel.Closeable')
  - [Resizable](#P-JMWToolkit-MVVM-ViewModels-MoveableWindowViewModel-Resizable 'JMWToolkit.MVVM.ViewModels.MoveableWindowViewModel.Resizable')
  - [OnClosed(eventArgs)](#M-JMWToolkit-MVVM-ViewModels-MoveableWindowViewModel-OnClosed-System-EventArgs- 'JMWToolkit.MVVM.ViewModels.MoveableWindowViewModel.OnClosed(System.EventArgs)')
  - [OnClosing(closingEventArgs)](#M-JMWToolkit-MVVM-ViewModels-MoveableWindowViewModel-OnClosing-System-ComponentModel-CancelEventArgs- 'JMWToolkit.MVVM.ViewModels.MoveableWindowViewModel.OnClosing(System.ComponentModel.CancelEventArgs)')
  - [OnLoaded()](#M-JMWToolkit-MVVM-ViewModels-MoveableWindowViewModel-OnLoaded 'JMWToolkit.MVVM.ViewModels.MoveableWindowViewModel.OnLoaded')
- [MultilineTextConverter](#T-JMWToolkit-MVVM-ValueConverters-MultilineTextConverter 'JMWToolkit.MVVM.ValueConverters.MultilineTextConverter')
  - [Convert(value,targetType,parameter,culture)](#M-JMWToolkit-MVVM-ValueConverters-MultilineTextConverter-Convert-System-Object,System-Type,System-Object,System-Globalization-CultureInfo- 'JMWToolkit.MVVM.ValueConverters.MultilineTextConverter.Convert(System.Object,System.Type,System.Object,System.Globalization.CultureInfo)')
  - [ConvertBack(value,targetType,parameter,culture)](#M-JMWToolkit-MVVM-ValueConverters-MultilineTextConverter-ConvertBack-System-Object,System-Type,System-Object,System-Globalization-CultureInfo- 'JMWToolkit.MVVM.ValueConverters.MultilineTextConverter.ConvertBack(System.Object,System.Type,System.Object,System.Globalization.CultureInfo)')
  - [_spacesAndNewLine()](#M-JMWToolkit-MVVM-ValueConverters-MultilineTextConverter-_spacesAndNewLine 'JMWToolkit.MVVM.ValueConverters.MultilineTextConverter._spacesAndNewLine')
- [NativeHelpers](#T-JMWToolkit-MVVM-Helpers-NativeHelpers 'JMWToolkit.MVVM.Helpers.NativeHelpers')
  - [GetDoubleClickTime()](#M-JMWToolkit-MVVM-Helpers-NativeHelpers-GetDoubleClickTime 'JMWToolkit.MVVM.Helpers.NativeHelpers.GetDoubleClickTime')
- [RoundedCornerButton](#T-JMWToolkit-MVVM-Controls-RoundedCornerButton 'JMWToolkit.MVVM.Controls.RoundedCornerButton')
  - [CornerRadiusProperty](#F-JMWToolkit-MVVM-Controls-RoundedCornerButton-CornerRadiusProperty 'JMWToolkit.MVVM.Controls.RoundedCornerButton.CornerRadiusProperty')
  - [CornerRadius](#P-JMWToolkit-MVVM-Controls-RoundedCornerButton-CornerRadius 'JMWToolkit.MVVM.Controls.RoundedCornerButton.CornerRadius')
- [Runner](#T-System-Text-RegularExpressions-Generated-_spacesAndNewLine_0-RunnerFactory-Runner 'System.Text.RegularExpressions.Generated._spacesAndNewLine_0.RunnerFactory.Runner')
  - [Scan(inputSpan)](#M-System-Text-RegularExpressions-Generated-_spacesAndNewLine_0-RunnerFactory-Runner-Scan-System-ReadOnlySpan{System-Char}- 'System.Text.RegularExpressions.Generated._spacesAndNewLine_0.RunnerFactory.Runner.Scan(System.ReadOnlySpan{System.Char})')
  - [TryFindNextPossibleStartingPosition(inputSpan)](#M-System-Text-RegularExpressions-Generated-_spacesAndNewLine_0-RunnerFactory-Runner-TryFindNextPossibleStartingPosition-System-ReadOnlySpan{System-Char}- 'System.Text.RegularExpressions.Generated._spacesAndNewLine_0.RunnerFactory.Runner.TryFindNextPossibleStartingPosition(System.ReadOnlySpan{System.Char})')
  - [TryMatchAtCurrentPosition(inputSpan)](#M-System-Text-RegularExpressions-Generated-_spacesAndNewLine_0-RunnerFactory-Runner-TryMatchAtCurrentPosition-System-ReadOnlySpan{System-Char}- 'System.Text.RegularExpressions.Generated._spacesAndNewLine_0.RunnerFactory.Runner.TryMatchAtCurrentPosition(System.ReadOnlySpan{System.Char})')
- [RunnerFactory](#T-System-Text-RegularExpressions-Generated-_spacesAndNewLine_0-RunnerFactory 'System.Text.RegularExpressions.Generated._spacesAndNewLine_0.RunnerFactory')
  - [CreateInstance()](#M-System-Text-RegularExpressions-Generated-_spacesAndNewLine_0-RunnerFactory-CreateInstance 'System.Text.RegularExpressions.Generated._spacesAndNewLine_0.RunnerFactory.CreateInstance')
- [StringResourceHelpers](#T-JMWToolkit-MVVM-Helpers-StringResourceHelpers 'JMWToolkit.MVVM.Helpers.StringResourceHelpers')
  - [FormatStringResource(formatId,args)](#M-JMWToolkit-MVVM-Helpers-StringResourceHelpers-FormatStringResource-System-String,System-Object[]- 'JMWToolkit.MVVM.Helpers.StringResourceHelpers.FormatStringResource(System.String,System.Object[])')
  - [LoadFromResource(resourceId)](#M-JMWToolkit-MVVM-Helpers-StringResourceHelpers-LoadFromResource-System-String- 'JMWToolkit.MVVM.Helpers.StringResourceHelpers.LoadFromResource(System.String)')
- [TaskWatcher](#T-JMWToolkit-MVVM-Helpers-TaskWatcher 'JMWToolkit.MVVM.Helpers.TaskWatcher')
  - [#ctor(dispatcher,action,cancellationToken)](#M-JMWToolkit-MVVM-Helpers-TaskWatcher-#ctor-JMWToolkit-MVVM-Interfaces-IDispatcher,System-Action,System-Nullable{System-Threading-CancellationToken}- 'JMWToolkit.MVVM.Helpers.TaskWatcher.#ctor(JMWToolkit.MVVM.Interfaces.IDispatcher,System.Action,System.Nullable{System.Threading.CancellationToken})')
  - [Start(longRunning)](#M-JMWToolkit-MVVM-Helpers-TaskWatcher-Start-System-Boolean- 'JMWToolkit.MVVM.Helpers.TaskWatcher.Start(System.Boolean)')
- [TaskWatcherBase](#T-JMWToolkit-MVVM-Helpers-TaskWatcherBase 'JMWToolkit.MVVM.Helpers.TaskWatcherBase')
  - [#ctor(dispatcher,cancellationToken)](#M-JMWToolkit-MVVM-Helpers-TaskWatcherBase-#ctor-JMWToolkit-MVVM-Interfaces-IDispatcher,System-Nullable{System-Threading-CancellationToken}- 'JMWToolkit.MVVM.Helpers.TaskWatcherBase.#ctor(JMWToolkit.MVVM.Interfaces.IDispatcher,System.Nullable{System.Threading.CancellationToken})')
  - [_cancellationToken](#F-JMWToolkit-MVVM-Helpers-TaskWatcherBase-_cancellationToken 'JMWToolkit.MVVM.Helpers.TaskWatcherBase._cancellationToken')
  - [_dispatcher](#F-JMWToolkit-MVVM-Helpers-TaskWatcherBase-_dispatcher 'JMWToolkit.MVVM.Helpers.TaskWatcherBase._dispatcher')
  - [_monitorObject](#F-JMWToolkit-MVVM-Helpers-TaskWatcherBase-_monitorObject 'JMWToolkit.MVVM.Helpers.TaskWatcherBase._monitorObject')
  - [Exception](#P-JMWToolkit-MVVM-Helpers-TaskWatcherBase-Exception 'JMWToolkit.MVVM.Helpers.TaskWatcherBase.Exception')
  - [IsCanceled](#P-JMWToolkit-MVVM-Helpers-TaskWatcherBase-IsCanceled 'JMWToolkit.MVVM.Helpers.TaskWatcherBase.IsCanceled')
  - [IsCompleted](#P-JMWToolkit-MVVM-Helpers-TaskWatcherBase-IsCompleted 'JMWToolkit.MVVM.Helpers.TaskWatcherBase.IsCompleted')
  - [IsFaulted](#P-JMWToolkit-MVVM-Helpers-TaskWatcherBase-IsFaulted 'JMWToolkit.MVVM.Helpers.TaskWatcherBase.IsFaulted')
  - [Wait()](#M-JMWToolkit-MVVM-Helpers-TaskWatcherBase-Wait 'JMWToolkit.MVVM.Helpers.TaskWatcherBase.Wait')
- [TaskWatcherEventArgs](#T-JMWToolkit-MVVM-Helpers-TaskWatcherEventArgs 'JMWToolkit.MVVM.Helpers.TaskWatcherEventArgs')
  - [#ctor(taskWatcher)](#M-JMWToolkit-MVVM-Helpers-TaskWatcherEventArgs-#ctor-JMWToolkit-MVVM-Helpers-TaskWatcher- 'JMWToolkit.MVVM.Helpers.TaskWatcherEventArgs.#ctor(JMWToolkit.MVVM.Helpers.TaskWatcher)')
  - [TaskWatcher](#P-JMWToolkit-MVVM-Helpers-TaskWatcherEventArgs-TaskWatcher 'JMWToolkit.MVVM.Helpers.TaskWatcherEventArgs.TaskWatcher')
- [TaskWatcherEventArgs\`1](#T-JMWToolkit-MVVM-Helpers-TaskWatcherEventArgs`1 'JMWToolkit.MVVM.Helpers.TaskWatcherEventArgs`1')
  - [#ctor(taskWatcher,result)](#M-JMWToolkit-MVVM-Helpers-TaskWatcherEventArgs`1-#ctor-JMWToolkit-MVVM-Helpers-TaskWatcher{`0},`0- 'JMWToolkit.MVVM.Helpers.TaskWatcherEventArgs`1.#ctor(JMWToolkit.MVVM.Helpers.TaskWatcher{`0},`0)')
  - [Result](#P-JMWToolkit-MVVM-Helpers-TaskWatcherEventArgs`1-Result 'JMWToolkit.MVVM.Helpers.TaskWatcherEventArgs`1.Result')
  - [TaskWatcher](#P-JMWToolkit-MVVM-Helpers-TaskWatcherEventArgs`1-TaskWatcher 'JMWToolkit.MVVM.Helpers.TaskWatcherEventArgs`1.TaskWatcher')
- [TaskWatcherEventArgs\`2](#T-JMWToolkit-MVVM-Helpers-TaskWatcherEventArgs`2 'JMWToolkit.MVVM.Helpers.TaskWatcherEventArgs`2')
  - [#ctor(taskWatcher,inputArgs,result)](#M-JMWToolkit-MVVM-Helpers-TaskWatcherEventArgs`2-#ctor-JMWToolkit-MVVM-Helpers-TaskWatcher{`0,`1},`0,`1- 'JMWToolkit.MVVM.Helpers.TaskWatcherEventArgs`2.#ctor(JMWToolkit.MVVM.Helpers.TaskWatcher{`0,`1},`0,`1)')
  - [InputArgs](#P-JMWToolkit-MVVM-Helpers-TaskWatcherEventArgs`2-InputArgs 'JMWToolkit.MVVM.Helpers.TaskWatcherEventArgs`2.InputArgs')
  - [Result](#P-JMWToolkit-MVVM-Helpers-TaskWatcherEventArgs`2-Result 'JMWToolkit.MVVM.Helpers.TaskWatcherEventArgs`2.Result')
  - [TaskWatcher](#P-JMWToolkit-MVVM-Helpers-TaskWatcherEventArgs`2-TaskWatcher 'JMWToolkit.MVVM.Helpers.TaskWatcherEventArgs`2.TaskWatcher')
- [TaskWatcher\`1](#T-JMWToolkit-MVVM-Helpers-TaskWatcher`1 'JMWToolkit.MVVM.Helpers.TaskWatcher`1')
  - [#ctor(dispatcher,func,cancellationToken)](#M-JMWToolkit-MVVM-Helpers-TaskWatcher`1-#ctor-JMWToolkit-MVVM-Interfaces-IDispatcher,System-Func{`0},System-Nullable{System-Threading-CancellationToken}- 'JMWToolkit.MVVM.Helpers.TaskWatcher`1.#ctor(JMWToolkit.MVVM.Interfaces.IDispatcher,System.Func{`0},System.Nullable{System.Threading.CancellationToken})')
  - [Start(longRunning)](#M-JMWToolkit-MVVM-Helpers-TaskWatcher`1-Start-System-Boolean- 'JMWToolkit.MVVM.Helpers.TaskWatcher`1.Start(System.Boolean)')
- [TaskWatcher\`2](#T-JMWToolkit-MVVM-Helpers-TaskWatcher`2 'JMWToolkit.MVVM.Helpers.TaskWatcher`2')
  - [#ctor(dispatcher,func,cancellationToken)](#M-JMWToolkit-MVVM-Helpers-TaskWatcher`2-#ctor-JMWToolkit-MVVM-Interfaces-IDispatcher,System-Func{`0,`1},System-Nullable{System-Threading-CancellationToken}- 'JMWToolkit.MVVM.Helpers.TaskWatcher`2.#ctor(JMWToolkit.MVVM.Interfaces.IDispatcher,System.Func{`0,`1},System.Nullable{System.Threading.CancellationToken})')
  - [Start(inputArgs,longRunning)](#M-JMWToolkit-MVVM-Helpers-TaskWatcher`2-Start-`0,System-Boolean- 'JMWToolkit.MVVM.Helpers.TaskWatcher`2.Start(`0,System.Boolean)')
- [TextBlockExtensions](#T-JMWToolkit-MVVM-Extensions-TextBlockExtensions 'JMWToolkit.MVVM.Extensions.TextBlockExtensions')
  - [BindableInlinesProperty](#F-JMWToolkit-MVVM-Extensions-TextBlockExtensions-BindableInlinesProperty 'JMWToolkit.MVVM.Extensions.TextBlockExtensions.BindableInlinesProperty')
  - [GetBindableInlines(obj)](#M-JMWToolkit-MVVM-Extensions-TextBlockExtensions-GetBindableInlines-System-Windows-DependencyObject- 'JMWToolkit.MVVM.Extensions.TextBlockExtensions.GetBindableInlines(System.Windows.DependencyObject)')
  - [OnBindableInlinesChanged(d,e)](#M-JMWToolkit-MVVM-Extensions-TextBlockExtensions-OnBindableInlinesChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'JMWToolkit.MVVM.Extensions.TextBlockExtensions.OnBindableInlinesChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [SetBindableInlines(obj,value)](#M-JMWToolkit-MVVM-Extensions-TextBlockExtensions-SetBindableInlines-System-Windows-DependencyObject,System-Collections-Generic-IEnumerable{System-Windows-Documents-Inline}- 'JMWToolkit.MVVM.Extensions.TextBlockExtensions.SetBindableInlines(System.Windows.DependencyObject,System.Collections.Generic.IEnumerable{System.Windows.Documents.Inline})')
- [Utilities](#T-System-Text-RegularExpressions-Generated-Utilities 'System.Text.RegularExpressions.Generated.Utilities')
  - [s_defaultTimeout](#F-System-Text-RegularExpressions-Generated-Utilities-s_defaultTimeout 'System.Text.RegularExpressions.Generated.Utilities.s_defaultTimeout')
  - [s_hasTimeout](#F-System-Text-RegularExpressions-Generated-Utilities-s_hasTimeout 'System.Text.RegularExpressions.Generated.Utilities.s_hasTimeout')
- [ViewModelBase](#T-JMWToolkit-MVVM-ViewModels-ViewModelBase 'JMWToolkit.MVVM.ViewModels.ViewModelBase')
  - [CreateAsyncRelayCommand(execute,canExecute,properties)](#M-JMWToolkit-MVVM-ViewModels-ViewModelBase-CreateAsyncRelayCommand-System-Func{System-Threading-Tasks-Task},System-Func{System-Boolean},System-String[]- 'JMWToolkit.MVVM.ViewModels.ViewModelBase.CreateAsyncRelayCommand(System.Func{System.Threading.Tasks.Task},System.Func{System.Boolean},System.String[])')
  - [CreateAsyncRelayCommand\`\`1(execute,canExecute,properties)](#M-JMWToolkit-MVVM-ViewModels-ViewModelBase-CreateAsyncRelayCommand``1-System-Func{``0,System-Threading-Tasks-Task},System-Predicate{``0},System-String[]- 'JMWToolkit.MVVM.ViewModels.ViewModelBase.CreateAsyncRelayCommand``1(System.Func{``0,System.Threading.Tasks.Task},System.Predicate{``0},System.String[])')
  - [CreateRelayCommand(execute,canExecute,properties)](#M-JMWToolkit-MVVM-ViewModels-ViewModelBase-CreateRelayCommand-System-Action,System-Func{System-Boolean},System-String[]- 'JMWToolkit.MVVM.ViewModels.ViewModelBase.CreateRelayCommand(System.Action,System.Func{System.Boolean},System.String[])')
  - [CreateRelayCommand\`\`1(execute,canExecute,properties)](#M-JMWToolkit-MVVM-ViewModels-ViewModelBase-CreateRelayCommand``1-System-Action{``0},System-Predicate{``0},System-String[]- 'JMWToolkit.MVVM.ViewModels.ViewModelBase.CreateRelayCommand``1(System.Action{``0},System.Predicate{``0},System.String[])')
  - [OnPropertyChanged(e)](#M-JMWToolkit-MVVM-ViewModels-ViewModelBase-OnPropertyChanged-System-ComponentModel-PropertyChangedEventArgs- 'JMWToolkit.MVVM.ViewModels.ViewModelBase.OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs)')
- [ViewModelBaseWithErrors](#T-JMWToolkit-MVVM-ViewModels-ViewModelBaseWithErrors 'JMWToolkit.MVVM.ViewModels.ViewModelBaseWithErrors')
  - [HasErrors](#P-JMWToolkit-MVVM-ViewModels-ViewModelBaseWithErrors-HasErrors 'JMWToolkit.MVVM.ViewModels.ViewModelBaseWithErrors.HasErrors')
  - [AddError(propertyName,error)](#M-JMWToolkit-MVVM-ViewModels-ViewModelBaseWithErrors-AddError-System-String,System-String- 'JMWToolkit.MVVM.ViewModels.ViewModelBaseWithErrors.AddError(System.String,System.String)')
  - [ClearErrors(propertyName)](#M-JMWToolkit-MVVM-ViewModels-ViewModelBaseWithErrors-ClearErrors-System-String- 'JMWToolkit.MVVM.ViewModels.ViewModelBaseWithErrors.ClearErrors(System.String)')
  - [ClearErrors(propertyNames)](#M-JMWToolkit-MVVM-ViewModels-ViewModelBaseWithErrors-ClearErrors-System-Collections-Generic-IEnumerable{System-String}- 'JMWToolkit.MVVM.ViewModels.ViewModelBaseWithErrors.ClearErrors(System.Collections.Generic.IEnumerable{System.String})')
  - [GetErrors(propertyName)](#M-JMWToolkit-MVVM-ViewModels-ViewModelBaseWithErrors-GetErrors-System-String- 'JMWToolkit.MVVM.ViewModels.ViewModelBaseWithErrors.GetErrors(System.String)')
  - [SetPropertyWithErrors\`\`1(field,newValue,propertyName)](#M-JMWToolkit-MVVM-ViewModels-ViewModelBaseWithErrors-SetPropertyWithErrors``1-``0@,``0,System-String- 'JMWToolkit.MVVM.ViewModels.ViewModelBaseWithErrors.SetPropertyWithErrors``1(``0@,``0,System.String)')
  - [SetPropertyWithErrors\`\`2(oldValue,newValue,model,callback,propertyName)](#M-JMWToolkit-MVVM-ViewModels-ViewModelBaseWithErrors-SetPropertyWithErrors``2-``1,``1,``0,System-Action{``0,``1},System-String- 'JMWToolkit.MVVM.ViewModels.ViewModelBaseWithErrors.SetPropertyWithErrors``2(``1,``1,``0,System.Action{``0,``1},System.String)')
- [VisibilityConverterMode](#T-JMWToolkit-MVVM-Converters-VisibilityConverterMode 'JMWToolkit.MVVM.Converters.VisibilityConverterMode')
  - [Collapsed](#F-JMWToolkit-MVVM-Converters-VisibilityConverterMode-Collapsed 'JMWToolkit.MVVM.Converters.VisibilityConverterMode.Collapsed')
  - [Hidden](#F-JMWToolkit-MVVM-Converters-VisibilityConverterMode-Hidden 'JMWToolkit.MVVM.Converters.VisibilityConverterMode.Hidden')
  - [InverseCollapsed](#F-JMWToolkit-MVVM-Converters-VisibilityConverterMode-InverseCollapsed 'JMWToolkit.MVVM.Converters.VisibilityConverterMode.InverseCollapsed')
  - [InverseHidden](#F-JMWToolkit-MVVM-Converters-VisibilityConverterMode-InverseHidden 'JMWToolkit.MVVM.Converters.VisibilityConverterMode.InverseHidden')
- [WindowStateToVisibilityConverter](#T-JMWToolkit-MVVM-Converters-WindowStateToVisibilityConverter 'JMWToolkit.MVVM.Converters.WindowStateToVisibilityConverter')
  - [Convert(value,targetType,parameter,culture)](#M-JMWToolkit-MVVM-Converters-WindowStateToVisibilityConverter-Convert-System-Object,System-Type,System-Object,System-Globalization-CultureInfo- 'JMWToolkit.MVVM.Converters.WindowStateToVisibilityConverter.Convert(System.Object,System.Type,System.Object,System.Globalization.CultureInfo)')
  - [ConvertBack(value,targetType,parameter,culture)](#M-JMWToolkit-MVVM-Converters-WindowStateToVisibilityConverter-ConvertBack-System-Object,System-Type,System-Object,System-Globalization-CultureInfo- 'JMWToolkit.MVVM.Converters.WindowStateToVisibilityConverter.ConvertBack(System.Object,System.Type,System.Object,System.Globalization.CultureInfo)')
- [_spacesAndNewLine_0](#T-System-Text-RegularExpressions-Generated-_spacesAndNewLine_0 'System.Text.RegularExpressions.Generated._spacesAndNewLine_0')
  - [#ctor()](#M-System-Text-RegularExpressions-Generated-_spacesAndNewLine_0-#ctor 'System.Text.RegularExpressions.Generated._spacesAndNewLine_0.#ctor')
  - [Instance](#F-System-Text-RegularExpressions-Generated-_spacesAndNewLine_0-Instance 'System.Text.RegularExpressions.Generated._spacesAndNewLine_0.Instance')

<a name='T-JMWToolkit-MVVM-Converters-BooleanToVisibilityConverter'></a>
## BooleanToVisibilityConverter `type`

##### Namespace

JMWToolkit.MVVM.Converters

##### Summary

Convert a bool value into System.Windows.Visibility. By default if the condition is true Visibility.Visible will
be returned. If false the default is collapsed. The caller can pass the VisibilityConverterMode to control the behavior.

<a name='M-JMWToolkit-MVVM-Converters-BooleanToVisibilityConverter-Convert-System-Object,System-Type,System-Object,System-Globalization-CultureInfo-'></a>
### Convert(value,targetType,parameter,culture) `method`

##### Summary

Convert a bool to a visibility value

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The value to be converted. |
| targetType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Must be typeof(Visibility) |
| parameter | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | optional VisibilityConverterMode, default is VisibilityConverterMode.Collapsed |
| culture | [System.Globalization.CultureInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Globalization.CultureInfo 'System.Globalization.CultureInfo') | ignored |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NotImplementedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotImplementedException 'System.NotImplementedException') |  |

<a name='M-JMWToolkit-MVVM-Converters-BooleanToVisibilityConverter-ConvertBack-System-Object,System-Type,System-Object,System-Globalization-CultureInfo-'></a>
### ConvertBack(value,targetType,parameter,culture) `method`

##### Summary

Not implemented

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| targetType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |
| parameter | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| culture | [System.Globalization.CultureInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Globalization.CultureInfo 'System.Globalization.CultureInfo') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NotImplementedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotImplementedException 'System.NotImplementedException') |  |

<a name='T-JMWToolkit-MVVM-Controls-ComboBoxWithAdd'></a>
## ComboBoxWithAdd `type`

##### Namespace

JMWToolkit.MVVM.Controls

##### Summary

ComboBoxWithAdd - adds an optional button to the bottom of the ComboBox drop down so that the user can choose to
add a new item into the list.

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

<a name='M-JMWToolkit-MVVM-Controls-ComboBoxWithAdd-#cctor'></a>
### #cctor() `method`

##### Summary

Default constructor for the ComboBoxWithAdd

##### Parameters

This method has no parameters.

<a name='T-JMWToolkit-MVVM-Converters-CountToVisibilityArguments'></a>
## CountToVisibilityArguments `type`

##### Namespace

JMWToolkit.MVVM.Converters

##### Summary

The arguments passed to the CountToVisibilityConverter.

<a name='P-JMWToolkit-MVVM-Converters-CountToVisibilityArguments-Count'></a>
### Count `property`

##### Summary

The Count to be compared to the bound value.

<a name='P-JMWToolkit-MVVM-Converters-CountToVisibilityArguments-Operator'></a>
### Operator `property`

##### Summary

The Operator to be applied to the value and the Count.

<a name='P-JMWToolkit-MVVM-Converters-CountToVisibilityArguments-VisibilityConverterMode'></a>
### VisibilityConverterMode `property`

##### Summary

The VisibilityConverterMode, collapsed is the default.

<a name='T-JMWToolkit-MVVM-Converters-CountToVisibilityConverter'></a>
## CountToVisibilityConverter `type`

##### Namespace

JMWToolkit.MVVM.Converters

##### Summary

Convert a Int32 into a Visibility value. The caller can pass an optional argument of type CountToVisibilityArguments which
can modify the comparison that is done. By default it will check to see if the value == 0.

<a name='M-JMWToolkit-MVVM-Converters-CountToVisibilityConverter-Convert-System-Object,System-Type,System-Object,System-Globalization-CultureInfo-'></a>
### Convert(value,targetType,parameter,culture) `method`

##### Summary

Convert a bool to a visibility value

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The value to be converted. |
| targetType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Must be typeof(Visibility) |
| parameter | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | optional VisibilityConverterMode, default is VisibilityConverterMode.Collapsed |
| culture | [System.Globalization.CultureInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Globalization.CultureInfo 'System.Globalization.CultureInfo') | ignored |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NotImplementedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotImplementedException 'System.NotImplementedException') |  |

<a name='M-JMWToolkit-MVVM-Converters-CountToVisibilityConverter-ConvertBack-System-Object,System-Type,System-Object,System-Globalization-CultureInfo-'></a>
### ConvertBack(value,targetType,parameter,culture) `method`

##### Summary

Not implemented

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| targetType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |
| parameter | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| culture | [System.Globalization.CultureInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Globalization.CultureInfo 'System.Globalization.CultureInfo') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NotImplementedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotImplementedException 'System.NotImplementedException') |  |

<a name='T-JMWToolkit-MVVM-Converters-CountToVisibilityOperator'></a>
## CountToVisibilityOperator `type`

##### Namespace

JMWToolkit.MVVM.Converters

##### Summary

An enum which tells which operand to use when doing the comparison.

<a name='F-JMWToolkit-MVVM-Converters-CountToVisibilityOperator-Equals'></a>
### Equals `constants`

##### Summary

The Values are equal.

<a name='F-JMWToolkit-MVVM-Converters-CountToVisibilityOperator-GreaterThan'></a>
### GreaterThan `constants`

##### Summary

The value is greater than the count.

<a name='F-JMWToolkit-MVVM-Converters-CountToVisibilityOperator-GreaterThanOrEqual'></a>
### GreaterThanOrEqual `constants`

##### Summary

The value is greater than or equal to the count.

<a name='F-JMWToolkit-MVVM-Converters-CountToVisibilityOperator-LessThan'></a>
### LessThan `constants`

##### Summary

The value is less than the count.

<a name='F-JMWToolkit-MVVM-Converters-CountToVisibilityOperator-LessThanOrEqual'></a>
### LessThanOrEqual `constants`

##### Summary

The value is less than or equal to the count.

<a name='F-JMWToolkit-MVVM-Converters-CountToVisibilityOperator-NotEqual'></a>
### NotEqual `constants`

##### Summary

The value is not equal to the count.

<a name='T-JMWToolkit-MVVM-Controls-CustomTextBox'></a>
## CustomTextBox `type`

##### Namespace

JMWToolkit.MVVM.Controls

##### Summary

CustomTextBox is a TextBox that allows a corner radius and placeholder text.

<a name='F-JMWToolkit-MVVM-Controls-CustomTextBox-CornerRadiusProperty'></a>
### CornerRadiusProperty `constants`

##### Summary

The DependencyProperty for the CornerRadius.

<a name='F-JMWToolkit-MVVM-Controls-CustomTextBox-PlaceholderTextBrushProperty'></a>
### PlaceholderTextBrushProperty `constants`

##### Summary

The DependencyProperty for the PlaceholderText.

<a name='F-JMWToolkit-MVVM-Controls-CustomTextBox-PlaceholderTextProperty'></a>
### PlaceholderTextProperty `constants`

##### Summary

The DependencyProperty for the PlaceholderText.

<a name='P-JMWToolkit-MVVM-Controls-CustomTextBox-CornerRadius'></a>
### CornerRadius `property`

##### Summary

The CornerRadius for the text box. Default is (0,0,0,0).

<a name='P-JMWToolkit-MVVM-Controls-CustomTextBox-PlaceholderText'></a>
### PlaceholderText `property`

##### Summary

Gets or sets the text that is displayed in the control until the value is changed by a user action or some other operation.

<a name='P-JMWToolkit-MVVM-Controls-CustomTextBox-PlaceholderTextBrush'></a>
### PlaceholderTextBrush `property`

##### Summary

Gets or sets a brush that describes the foreground color of the PlaceholderText

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

<a name='T-JMWToolkit-MVVM-Interfaces-IDispatcher'></a>
## IDispatcher `type`

##### Namespace

JMWToolkit.MVVM.Interfaces

##### Summary

The interface needed to interface properly with the application.

<a name='M-JMWToolkit-MVVM-Interfaces-IDispatcher-BeginInvoke-System-Delegate,System-Object[]-'></a>
### BeginInvoke(method,args) `method`

##### Summary

Executes a delegate asynchronously on the main application thread.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| method | [System.Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') | The delegate method to be executed. |
| args | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | An array of objects to pass as arguments to the given method. |

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
is very similar to the built in MessageBox class but with the text enhancements for the
caption. I will continue to add more features but for now the
Caption area allows you to specify <break> in a line when you want a paragraph break.

<a name='M-JMWToolkit-MVVM-Dialogs-MessageBoxEx-GetMessageBoxImageSource-System-Windows-MessageBoxImage-'></a>
### GetMessageBoxImageSource(messageBoxImage) `method`

##### Summary

Gets the ImageSource for the give MessageBoxImage

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageBoxImage | [System.Windows.MessageBoxImage](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.MessageBoxImage 'System.Windows.MessageBoxImage') | The MessageBoxImage to get the ImageSource for. |

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
    MessageBoxImage.Error, or MessageBoxImage.Question defaults to MessageBoxImage.Information |

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

<a name='T-JMWToolkit-MVVM-Controls-MoveableWindow'></a>
## MoveableWindow `type`

##### Namespace

JMWToolkit.MVVM.Controls

##### Summary

Descendent of the System.Windows.Window class which adds a customizable toolbar and events to help the ViewModels.

<a name='M-JMWToolkit-MVVM-Controls-MoveableWindow-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes the MoveableWindowClass

##### Parameters

This constructor has no parameters.

<a name='F-JMWToolkit-MVVM-Controls-MoveableWindow-CloseCommandPropertyKey'></a>
### CloseCommandPropertyKey `constants`

##### Summary

CloseCommand dependency property.

<a name='F-JMWToolkit-MVVM-Controls-MoveableWindow-CloseableProperty'></a>
### CloseableProperty `constants`

##### Summary

The dependency property for Closable.

<a name='F-JMWToolkit-MVVM-Controls-MoveableWindow-MaximizeCommandPropertyKey'></a>
### MaximizeCommandPropertyKey `constants`

##### Summary

Dependency property for the MaximizeCommand.

<a name='F-JMWToolkit-MVVM-Controls-MoveableWindow-MinimizeCommandPropertyKey'></a>
### MinimizeCommandPropertyKey `constants`

##### Summary

Dependency property for the MinimizeCommand

<a name='F-JMWToolkit-MVVM-Controls-MoveableWindow-OverlapCommandPropertyKey'></a>
### OverlapCommandPropertyKey `constants`

##### Summary

Dependency property for the OverlapCommand.

<a name='F-JMWToolkit-MVVM-Controls-MoveableWindow-ResizableProperty'></a>
### ResizableProperty `constants`

##### Summary

Resizable DependencyProperty registration.

<a name='P-JMWToolkit-MVVM-Controls-MoveableWindow-CloseCommand'></a>
### CloseCommand `property`

##### Summary

Gets the CloseCommand which is used to close the window.

<a name='P-JMWToolkit-MVVM-Controls-MoveableWindow-Closeable'></a>
### Closeable `property`

##### Summary

This property enables a window to be closable. By default a window is closable.

<a name='P-JMWToolkit-MVVM-Controls-MoveableWindow-MaximizeCommand'></a>
### MaximizeCommand `property`

##### Summary

Gets the maximize command which can be used to minimize the window.

<a name='P-JMWToolkit-MVVM-Controls-MoveableWindow-MinimizeCommand'></a>
### MinimizeCommand `property`

##### Summary

Gets the minimize command which can be used to minimize the window.

<a name='P-JMWToolkit-MVVM-Controls-MoveableWindow-OverlapCommand'></a>
### OverlapCommand `property`

##### Summary

Gets the overlap command which can be used to restore the window.

<a name='P-JMWToolkit-MVVM-Controls-MoveableWindow-Resizable'></a>
### Resizable `property`

##### Summary

This property enables a window to be resizable. Set it to false if you don't want the window to allow
resizing.

<a name='M-JMWToolkit-MVVM-Controls-MoveableWindow-MoveableWindow_Loaded-System-Object,System-Windows-RoutedEventArgs-'></a>
### MoveableWindow_Loaded(sender,e) `method`

##### Summary

Overridable method called when the Window is loaded.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') |  |

<a name='M-JMWToolkit-MVVM-Controls-MoveableWindow-OnClosed-System-EventArgs-'></a>
### OnClosed(e) `method`

##### Summary

Calls the OnClosed method of the MoveableWindowViewModel

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') |  |

<a name='M-JMWToolkit-MVVM-Controls-MoveableWindow-OnClosing-System-ComponentModel-CancelEventArgs-'></a>
### OnClosing(e) `method`

##### Summary

Calls the OnClosing method of MoveableWindowViewModel

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.ComponentModel.CancelEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs 'System.ComponentModel.CancelEventArgs') |  |

<a name='M-JMWToolkit-MVVM-Controls-MoveableWindow-OnPropertyChanged-System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnPropertyChanged(e) `method`

##### Summary

Invoked whenever the effective value of any dependency property on this DependencyObject has been updated

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') |  |

<a name='M-JMWToolkit-MVVM-Controls-MoveableWindow-OnStateChanged-System-EventArgs-'></a>
### OnStateChanged(e) `method`

##### Summary

Called when the WindowState changes. If overridden should call base.OnStateChanged.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') |  |

<a name='T-JMWToolkit-MVVM-ViewModels-MoveableWindowViewModel'></a>
## MoveableWindowViewModel `type`

##### Namespace

JMWToolkit.MVVM.ViewModels

##### Summary

This is the ViewModel for the MoveableWindow class

<a name='P-JMWToolkit-MVVM-ViewModels-MoveableWindowViewModel-Closeable'></a>
### Closeable `property`

##### Summary

Property specifying whether the window should enable the close button.

<a name='P-JMWToolkit-MVVM-ViewModels-MoveableWindowViewModel-Resizable'></a>
### Resizable `property`

##### Summary

Property specifying whether the window should be allowed to resize.

<a name='M-JMWToolkit-MVVM-ViewModels-MoveableWindowViewModel-OnClosed-System-EventArgs-'></a>
### OnClosed(eventArgs) `method`

##### Summary

Called when the Window is closed. If overridden the base OnClosing should be called.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| eventArgs | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') |  |

<a name='M-JMWToolkit-MVVM-ViewModels-MoveableWindowViewModel-OnClosing-System-ComponentModel-CancelEventArgs-'></a>
### OnClosing(closingEventArgs) `method`

##### Summary

Called when the Window is attempting to close. If overridden the base OnClosing should be called.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| closingEventArgs | [System.ComponentModel.CancelEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs 'System.ComponentModel.CancelEventArgs') |  |

<a name='M-JMWToolkit-MVVM-ViewModels-MoveableWindowViewModel-OnLoaded'></a>
### OnLoaded() `method`

##### Summary

Called when the Window is Loaded. If overridden base OnLoaded should be called.

##### Parameters

This method has no parameters.

<a name='T-JMWToolkit-MVVM-ValueConverters-MultilineTextConverter'></a>
## MultilineTextConverter `type`

##### Namespace

JMWToolkit.MVVM.ValueConverters

##### Summary

The MultiLineTextConverter is a value converter to go from a String value to a
collection of Inline objects for rich formatting of the text.

<a name='M-JMWToolkit-MVVM-ValueConverters-MultilineTextConverter-Convert-System-Object,System-Type,System-Object,System-Globalization-CultureInfo-'></a>
### Convert(value,targetType,parameter,culture) `method`

##### Summary

This routine is used to convert from a string to an Inline collection. All other types will
fail.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The string to be converted |
| targetType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Should be an IEnumerable of Inline |
| parameter | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | ignored |
| culture | [System.Globalization.CultureInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Globalization.CultureInfo 'System.Globalization.CultureInfo') | ignored |

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

Pattern:

```
[ ]*\\n[ ]*
```

Explanation:

```
○ Match ' ' atomically any number of times.
```

<a name='T-JMWToolkit-MVVM-Helpers-NativeHelpers'></a>
## NativeHelpers `type`

##### Namespace

JMWToolkit.MVVM.Helpers

##### Summary

A set of Win32 helpers

<a name='M-JMWToolkit-MVVM-Helpers-NativeHelpers-GetDoubleClickTime'></a>
### GetDoubleClickTime() `method`

##### Summary

Retrieves the current double-click time for the mouse.

##### Returns

he return value specifies the current double-click time, in milliseconds. The maximum return value is 5000 milliseconds.

##### Parameters

This method has no parameters.

<a name='T-JMWToolkit-MVVM-Controls-RoundedCornerButton'></a>
## RoundedCornerButton `type`

##### Namespace

JMWToolkit.MVVM.Controls

##### Summary

This is a button which allows you to specify a rounded corner.

<a name='F-JMWToolkit-MVVM-Controls-RoundedCornerButton-CornerRadiusProperty'></a>
### CornerRadiusProperty `constants`

##### Summary

The DependencyProperty for the CornerRadius

<a name='P-JMWToolkit-MVVM-Controls-RoundedCornerButton-CornerRadius'></a>
### CornerRadius `property`

##### Summary

The CornerRadius for the button. Default is (0,0,0,0)

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
routines to load a string resource. I am not thrilled about this class using the
Application.Current.FindResource.

<a name='M-JMWToolkit-MVVM-Helpers-StringResourceHelpers-FormatStringResource-System-String,System-Object[]-'></a>
### FormatStringResource(formatId,args) `method`

##### Summary

Loads a string resource and then formats it with the supplied parameters

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| formatId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Resource Id for the string format |
| args | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | Variable list of arguments for the string format |

<a name='M-JMWToolkit-MVVM-Helpers-StringResourceHelpers-LoadFromResource-System-String-'></a>
### LoadFromResource(resourceId) `method`

##### Summary

Simply loads the string specified by the resourceId

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resourceId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Id of the string to load |

<a name='T-JMWToolkit-MVVM-Helpers-TaskWatcher'></a>
## TaskWatcher `type`

##### Namespace

JMWToolkit.MVVM.Helpers

##### Summary

Runs an asynchronous Action and then calls the OnCompleted method on the UX thread when done. It always observes the
task so that the application will never see an UnobservedTaskException.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dispatcher | [T:JMWToolkit.MVVM.Helpers.TaskWatcher](#T-T-JMWToolkit-MVVM-Helpers-TaskWatcher 'T:JMWToolkit.MVVM.Helpers.TaskWatcher') | The IDispatcher interface to be used. |

<a name='M-JMWToolkit-MVVM-Helpers-TaskWatcher-#ctor-JMWToolkit-MVVM-Interfaces-IDispatcher,System-Action,System-Nullable{System-Threading-CancellationToken}-'></a>
### #ctor(dispatcher,action,cancellationToken) `constructor`

##### Summary

Runs an asynchronous Action and then calls the OnCompleted method on the UX thread when done. It always observes the
task so that the application will never see an UnobservedTaskException.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dispatcher | [JMWToolkit.MVVM.Interfaces.IDispatcher](#T-JMWToolkit-MVVM-Interfaces-IDispatcher 'JMWToolkit.MVVM.Interfaces.IDispatcher') | The IDispatcher interface to be used. |
| action | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | The action to run. |
| cancellationToken | [System.Nullable{System.Threading.CancellationToken}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Threading.CancellationToken}') | The CancellationToken that will be monitored for a cancellation. |

<a name='M-JMWToolkit-MVVM-Helpers-TaskWatcher-Start-System-Boolean-'></a>
### Start(longRunning) `method`

##### Summary

Starts the task and returns immediately.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| longRunning | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='T-JMWToolkit-MVVM-Helpers-TaskWatcherBase'></a>
## TaskWatcherBase `type`

##### Namespace

JMWToolkit.MVVM.Helpers

##### Summary

This is a base class for a TaskWatcher. It has some common members, properties and methods.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dispatcher | [T:JMWToolkit.MVVM.Helpers.TaskWatcherBase](#T-T-JMWToolkit-MVVM-Helpers-TaskWatcherBase 'T:JMWToolkit.MVVM.Helpers.TaskWatcherBase') |  |

<a name='M-JMWToolkit-MVVM-Helpers-TaskWatcherBase-#ctor-JMWToolkit-MVVM-Interfaces-IDispatcher,System-Nullable{System-Threading-CancellationToken}-'></a>
### #ctor(dispatcher,cancellationToken) `constructor`

##### Summary

This is a base class for a TaskWatcher. It has some common members, properties and methods.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dispatcher | [JMWToolkit.MVVM.Interfaces.IDispatcher](#T-JMWToolkit-MVVM-Interfaces-IDispatcher 'JMWToolkit.MVVM.Interfaces.IDispatcher') |  |
| cancellationToken | [System.Nullable{System.Threading.CancellationToken}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Threading.CancellationToken}') |  |

<a name='F-JMWToolkit-MVVM-Helpers-TaskWatcherBase-_cancellationToken'></a>
### _cancellationToken `constants`

##### Summary

The cancellationToken used to cancel the task.

<a name='F-JMWToolkit-MVVM-Helpers-TaskWatcherBase-_dispatcher'></a>
### _dispatcher `constants`

##### Summary

The Dispatcher interface for the application.

<a name='F-JMWToolkit-MVVM-Helpers-TaskWatcherBase-_monitorObject'></a>
### _monitorObject `constants`

##### Summary

An object used to synchronize access to the member variables and used to when waiting for the task
to complete.

<a name='P-JMWToolkit-MVVM-Helpers-TaskWatcherBase-Exception'></a>
### Exception `property`

##### Summary

Non-null if an exception was thrown during the Action.

<a name='P-JMWToolkit-MVVM-Helpers-TaskWatcherBase-IsCanceled'></a>
### IsCanceled `property`

##### Summary

True if the task was cancelled.

<a name='P-JMWToolkit-MVVM-Helpers-TaskWatcherBase-IsCompleted'></a>
### IsCompleted `property`

##### Summary

True if the task completed.

<a name='P-JMWToolkit-MVVM-Helpers-TaskWatcherBase-IsFaulted'></a>
### IsFaulted `property`

##### Summary

True if the task thew an exception. If true then Exception will be non-null and contain the exception that was thrown.

<a name='M-JMWToolkit-MVVM-Helpers-TaskWatcherBase-Wait'></a>
### Wait() `method`

##### Summary

Waits for the background task to complete.

##### Parameters

This method has no parameters.

<a name='T-JMWToolkit-MVVM-Helpers-TaskWatcherEventArgs'></a>
## TaskWatcherEventArgs `type`

##### Namespace

JMWToolkit.MVVM.Helpers

##### Summary

Provides data for the TaskWatcher OnCompleted Event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| taskWatcher | [T:JMWToolkit.MVVM.Helpers.TaskWatcherEventArgs](#T-T-JMWToolkit-MVVM-Helpers-TaskWatcherEventArgs 'T:JMWToolkit.MVVM.Helpers.TaskWatcherEventArgs') |  |

<a name='M-JMWToolkit-MVVM-Helpers-TaskWatcherEventArgs-#ctor-JMWToolkit-MVVM-Helpers-TaskWatcher-'></a>
### #ctor(taskWatcher) `constructor`

##### Summary

Provides data for the TaskWatcher OnCompleted Event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| taskWatcher | [JMWToolkit.MVVM.Helpers.TaskWatcher](#T-JMWToolkit-MVVM-Helpers-TaskWatcher 'JMWToolkit.MVVM.Helpers.TaskWatcher') |  |

<a name='P-JMWToolkit-MVVM-Helpers-TaskWatcherEventArgs-TaskWatcher'></a>
### TaskWatcher `property`

##### Summary

Gets the TaskWatcher that has completed.

<a name='T-JMWToolkit-MVVM-Helpers-TaskWatcherEventArgs`1'></a>
## TaskWatcherEventArgs\`1 `type`

##### Namespace

JMWToolkit.MVVM.Helpers

##### Summary

Provides data for the TaskWatcher OnCompleted Event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| taskWatcher | [T:JMWToolkit.MVVM.Helpers.TaskWatcherEventArgs\`1](#T-T-JMWToolkit-MVVM-Helpers-TaskWatcherEventArgs`1 'T:JMWToolkit.MVVM.Helpers.TaskWatcherEventArgs`1') | The TaskWatcher the for the given task. |

<a name='M-JMWToolkit-MVVM-Helpers-TaskWatcherEventArgs`1-#ctor-JMWToolkit-MVVM-Helpers-TaskWatcher{`0},`0-'></a>
### #ctor(taskWatcher,result) `constructor`

##### Summary

Provides data for the TaskWatcher OnCompleted Event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| taskWatcher | [JMWToolkit.MVVM.Helpers.TaskWatcher{\`0}](#T-JMWToolkit-MVVM-Helpers-TaskWatcher{`0} 'JMWToolkit.MVVM.Helpers.TaskWatcher{`0}') | The TaskWatcher the for the given task. |
| result | [\`0](#T-`0 '`0') | The result, if successful, null if not. |

<a name='P-JMWToolkit-MVVM-Helpers-TaskWatcherEventArgs`1-Result'></a>
### Result `property`

##### Summary

The Result of the func call if successful.

<a name='P-JMWToolkit-MVVM-Helpers-TaskWatcherEventArgs`1-TaskWatcher'></a>
### TaskWatcher `property`

##### Summary

Gets the TaskWatcher that has completed.

<a name='T-JMWToolkit-MVVM-Helpers-TaskWatcherEventArgs`2'></a>
## TaskWatcherEventArgs\`2 `type`

##### Namespace

JMWToolkit.MVVM.Helpers

##### Summary

Provides data for the TaskWatcher OnCompleted Event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| taskWatcher | [T:JMWToolkit.MVVM.Helpers.TaskWatcherEventArgs\`2](#T-T-JMWToolkit-MVVM-Helpers-TaskWatcherEventArgs`2 'T:JMWToolkit.MVVM.Helpers.TaskWatcherEventArgs`2') | The TaskWatcher the for the given task. |

<a name='M-JMWToolkit-MVVM-Helpers-TaskWatcherEventArgs`2-#ctor-JMWToolkit-MVVM-Helpers-TaskWatcher{`0,`1},`0,`1-'></a>
### #ctor(taskWatcher,inputArgs,result) `constructor`

##### Summary

Provides data for the TaskWatcher OnCompleted Event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| taskWatcher | [JMWToolkit.MVVM.Helpers.TaskWatcher{\`0,\`1}](#T-JMWToolkit-MVVM-Helpers-TaskWatcher{`0,`1} 'JMWToolkit.MVVM.Helpers.TaskWatcher{`0,`1}') | The TaskWatcher the for the given task. |
| inputArgs | [\`0](#T-`0 '`0') | The arguments passed to the task function. |
| result | [\`1](#T-`1 '`1') | The result, if successful, null if not. |

<a name='P-JMWToolkit-MVVM-Helpers-TaskWatcherEventArgs`2-InputArgs'></a>
### InputArgs `property`

##### Summary

The input args passed to Start.

<a name='P-JMWToolkit-MVVM-Helpers-TaskWatcherEventArgs`2-Result'></a>
### Result `property`

##### Summary

The Result of the func call if successful.

<a name='P-JMWToolkit-MVVM-Helpers-TaskWatcherEventArgs`2-TaskWatcher'></a>
### TaskWatcher `property`

##### Summary

Gets the TaskWatcher that has completed.

<a name='T-JMWToolkit-MVVM-Helpers-TaskWatcher`1'></a>
## TaskWatcher\`1 `type`

##### Namespace

JMWToolkit.MVVM.Helpers

##### Summary

Runs an asynchronous Action and then calls the OnCompleted method on the UX thread when done. It always observes the
task so that the application will never see an UnobservedTaskException.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dispatcher | [T:JMWToolkit.MVVM.Helpers.TaskWatcher\`1](#T-T-JMWToolkit-MVVM-Helpers-TaskWatcher`1 'T:JMWToolkit.MVVM.Helpers.TaskWatcher`1') | The IDispatcher interface to be used. |

<a name='M-JMWToolkit-MVVM-Helpers-TaskWatcher`1-#ctor-JMWToolkit-MVVM-Interfaces-IDispatcher,System-Func{`0},System-Nullable{System-Threading-CancellationToken}-'></a>
### #ctor(dispatcher,func,cancellationToken) `constructor`

##### Summary

Runs an asynchronous Action and then calls the OnCompleted method on the UX thread when done. It always observes the
task so that the application will never see an UnobservedTaskException.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dispatcher | [JMWToolkit.MVVM.Interfaces.IDispatcher](#T-JMWToolkit-MVVM-Interfaces-IDispatcher 'JMWToolkit.MVVM.Interfaces.IDispatcher') | The IDispatcher interface to be used. |
| func | [System.Func{\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`0}') | The function to be run. |
| cancellationToken | [System.Nullable{System.Threading.CancellationToken}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Threading.CancellationToken}') | The CancellationToken that will be monitored for a cancellation. |

<a name='M-JMWToolkit-MVVM-Helpers-TaskWatcher`1-Start-System-Boolean-'></a>
### Start(longRunning) `method`

##### Summary

Starts the task and returns immediately.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| longRunning | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='T-JMWToolkit-MVVM-Helpers-TaskWatcher`2'></a>
## TaskWatcher\`2 `type`

##### Namespace

JMWToolkit.MVVM.Helpers

##### Summary

Runs an asynchronous Action and then calls the OnCompleted method on the UX thread when done. It always observes the
task so that the application will never see an UnobservedTaskException.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dispatcher | [T:JMWToolkit.MVVM.Helpers.TaskWatcher\`2](#T-T-JMWToolkit-MVVM-Helpers-TaskWatcher`2 'T:JMWToolkit.MVVM.Helpers.TaskWatcher`2') | The IDispatcher interface to be used. |

<a name='M-JMWToolkit-MVVM-Helpers-TaskWatcher`2-#ctor-JMWToolkit-MVVM-Interfaces-IDispatcher,System-Func{`0,`1},System-Nullable{System-Threading-CancellationToken}-'></a>
### #ctor(dispatcher,func,cancellationToken) `constructor`

##### Summary

Runs an asynchronous Action and then calls the OnCompleted method on the UX thread when done. It always observes the
task so that the application will never see an UnobservedTaskException.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dispatcher | [JMWToolkit.MVVM.Interfaces.IDispatcher](#T-JMWToolkit-MVVM-Interfaces-IDispatcher 'JMWToolkit.MVVM.Interfaces.IDispatcher') | The IDispatcher interface to be used. |
| func | [System.Func{\`0,\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`0,`1}') | The function to be run. |
| cancellationToken | [System.Nullable{System.Threading.CancellationToken}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Threading.CancellationToken}') | The CancellationToken that will be monitored for a cancellation. |

<a name='M-JMWToolkit-MVVM-Helpers-TaskWatcher`2-Start-`0,System-Boolean-'></a>
### Start(inputArgs,longRunning) `method`

##### Summary

Starts the task and returns immediately.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| inputArgs | [\`0](#T-`0 '`0') | The input arguments to be passed to the called task function. |
| longRunning | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

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

<a name='M-JMWToolkit-MVVM-ViewModels-ViewModelBase-OnPropertyChanged-System-ComponentModel-PropertyChangedEventArgs-'></a>
### OnPropertyChanged(e) `method`

##### Summary

Override the base OnPropertyChanged so that we can Notify the affected commands

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.ComponentModel.PropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.PropertyChangedEventArgs 'System.ComponentModel.PropertyChangedEventArgs') |  |

<a name='T-JMWToolkit-MVVM-ViewModels-ViewModelBaseWithErrors'></a>
## ViewModelBaseWithErrors `type`

##### Namespace

JMWToolkit.MVVM.ViewModels

##### Summary

This is an extension of the ViewModelBase class that adds Error notifications.

<a name='P-JMWToolkit-MVVM-ViewModels-ViewModelBaseWithErrors-HasErrors'></a>
### HasErrors `property`

##### Summary

Gets a value that indicates whether the entity has validation errors.

<a name='M-JMWToolkit-MVVM-ViewModels-ViewModelBaseWithErrors-AddError-System-String,System-String-'></a>
### AddError(propertyName,error) `method`

##### Summary

Adds an error for the given property name.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The property name to add the validation error to. |
| error | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The error |

<a name='M-JMWToolkit-MVVM-ViewModels-ViewModelBaseWithErrors-ClearErrors-System-String-'></a>
### ClearErrors(propertyName) `method`

##### Summary

Clears the validation errors for the specified property If no property is specified it clears away all
validation errors.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-JMWToolkit-MVVM-ViewModels-ViewModelBaseWithErrors-ClearErrors-System-Collections-Generic-IEnumerable{System-String}-'></a>
### ClearErrors(propertyNames) `method`

##### Summary

Clears the validation errors for all of the specified properties.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| propertyNames | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') |  |

<a name='M-JMWToolkit-MVVM-ViewModels-ViewModelBaseWithErrors-GetErrors-System-String-'></a>
### GetErrors(propertyName) `method`

##### Summary

Gets the validation errors for a specified property or for the entire entity.

##### Returns

The validation errors for the property or entity.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the property to retrieve validation errors for; or null or Empty, to retrieve entity-level errors. |

<a name='M-JMWToolkit-MVVM-ViewModels-ViewModelBaseWithErrors-SetPropertyWithErrors``1-``0@,``0,System-String-'></a>
### SetPropertyWithErrors\`\`1(field,newValue,propertyName) `method`

##### Summary

Sets the value for the give property. If the value is changed it clears the existing errors for the property.

##### Returns

true if the property was updated, false if not.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| field | [\`\`0@](#T-``0@ '``0@') | The field value to be updated with the new value. |
| newValue | [\`\`0](#T-``0 '``0') | The new value for the property. |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The property name. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the property specified. |

<a name='M-JMWToolkit-MVVM-ViewModels-ViewModelBaseWithErrors-SetPropertyWithErrors``2-``1,``1,``0,System-Action{``0,``1},System-String-'></a>
### SetPropertyWithErrors\`\`2(oldValue,newValue,model,callback,propertyName) `method`

##### Summary

Sets the value for the give property. If the value is changed it clears the existing errors for the property.

##### Returns

true if the value is changed, false if not.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| oldValue | [\`\`1](#T-``1 '``1') | The old value to be replaced. |
| newValue | [\`\`1](#T-``1 '``1') | The new value. |
| model | [\`\`0](#T-``0 '``0') | The actual model to be updated. |
| callback | [System.Action{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{``0,``1}') | A callback which will be executed if the values are not equal. |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the property being updated. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TModel | The model class being whose property is being updated. |
| T | The type of the field in the class. |

<a name='T-JMWToolkit-MVVM-Converters-VisibilityConverterMode'></a>
## VisibilityConverterMode `type`

##### Namespace

JMWToolkit.MVVM.Converters

##### Summary

Enum which can be used to specify the conversion for our visibility converters.

<a name='F-JMWToolkit-MVVM-Converters-VisibilityConverterMode-Collapsed'></a>
### Collapsed `constants`

##### Summary

Control will be collapsed when condition is false

<a name='F-JMWToolkit-MVVM-Converters-VisibilityConverterMode-Hidden'></a>
### Hidden `constants`

##### Summary

Control will be hidden when the condition is false

<a name='F-JMWToolkit-MVVM-Converters-VisibilityConverterMode-InverseCollapsed'></a>
### InverseCollapsed `constants`

##### Summary

Control will be collapsed when the condition is true

<a name='F-JMWToolkit-MVVM-Converters-VisibilityConverterMode-InverseHidden'></a>
### InverseHidden `constants`

##### Summary

Control will be hidden when the condition is true

<a name='T-JMWToolkit-MVVM-Converters-WindowStateToVisibilityConverter'></a>
## WindowStateToVisibilityConverter `type`

##### Namespace

JMWToolkit.MVVM.Converters

##### Summary

Converts a window state to Visibility. The parameter specifies which state maps to Visible. All other states result in Collapsed.

<a name='M-JMWToolkit-MVVM-Converters-WindowStateToVisibilityConverter-Convert-System-Object,System-Type,System-Object,System-Globalization-CultureInfo-'></a>
### Convert(value,targetType,parameter,culture) `method`

##### Summary

Converts a WindowState into Visible or Hidden depending on the value of the parameter.

##### Returns

Visible if the state is the required state, Collapsed if not.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The WindowState to convert |
| targetType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Must be Visibility |
| parameter | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The mode that maps to Visible |
| culture | [System.Globalization.CultureInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Globalization.CultureInfo 'System.Globalization.CultureInfo') | ignored |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NotImplementedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotImplementedException 'System.NotImplementedException') |  |

<a name='M-JMWToolkit-MVVM-Converters-WindowStateToVisibilityConverter-ConvertBack-System-Object,System-Type,System-Object,System-Globalization-CultureInfo-'></a>
### ConvertBack(value,targetType,parameter,culture) `method`

##### Summary

Not implemented

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| targetType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |
| parameter | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| culture | [System.Globalization.CultureInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Globalization.CultureInfo 'System.Globalization.CultureInfo') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NotImplementedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotImplementedException 'System.NotImplementedException') |  |

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
