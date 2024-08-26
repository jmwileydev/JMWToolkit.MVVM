using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace JMWToolkit.MVVM.Converters;

/// <summary>
/// Converts a window state to Visibility. The parameter specifies which state maps to Visible. All other states result in Collapsed.
/// </summary>
[ValueConversion(typeof(WindowState), typeof(Visibility))]
public class WindowStateToVisibilityConverter : IValueConverter
{
    /// <summary>
    /// Converts a WindowState into Visible or Hidden depending on the value of the parameter.
    /// </summary>
    /// <param name="value">The WindowState to convert</param>
    /// <param name="targetType">Must be Visibility</param>
    /// <param name="parameter">The mode that maps to Visible</param>
    /// <param name="culture">ignored</param>
    /// <returns>Visible if the state is the required state, Collapsed if not.</returns>
    /// <exception cref="NotImplementedException"></exception>
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is not WindowState windowState)
        {
            return DependencyProperty.UnsetValue;
        }

        if (targetType !=  typeof(Visibility))
        {
            return DependencyProperty.UnsetValue;
        }

        if (parameter is not WindowState visibleWindowState)
        {
            return DependencyProperty.UnsetValue;
        }


        return (windowState == visibleWindowState) ? Visibility.Visible : Visibility.Collapsed;
    }

    /// <summary>
    /// Not implemented
    /// </summary>
    /// <param name="value"></param>
    /// <param name="targetType"></param>
    /// <param name="parameter"></param>
    /// <param name="culture"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
