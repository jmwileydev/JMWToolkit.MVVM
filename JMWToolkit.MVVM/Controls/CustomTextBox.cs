using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace JMWToolkit.MVVM.Controls;

/// <summary>
/// CustomTextBox is a TextBox that allows a corner radius and placeholder text.
/// </summary>
public class CustomTextBox : TextBox
{
    /// <summary>
    /// The CornerRadius for the text box. Default is (0,0,0,0).
    /// </summary>
    public CornerRadius CornerRadius
    {
        get { return (CornerRadius)GetValue(CornerRadiusProperty); }
        set { SetValue(CornerRadiusProperty, value); }
    }

    /// <summary>
    /// The DependencyProperty for the CornerRadius.
    /// </summary>
    public static readonly DependencyProperty CornerRadiusProperty =
        DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(CustomTextBox), new PropertyMetadata(new CornerRadius(0, 0, 0, 0)));

    /// <summary>
    /// Gets or sets the text that is displayed in the control until the value is changed by a user action or some other operation.
    /// </summary>
    public string? PlaceholderText
    {
        get { return (string)GetValue(PlaceholderTextProperty); }
        set { SetValue(PlaceholderTextProperty, value); }
    }

    /// <summary>
    /// The DependencyProperty for the PlaceholderText.
    /// </summary>
    public static readonly DependencyProperty PlaceholderTextProperty =
        DependencyProperty.Register("PlaceholderText", typeof(string), typeof(CustomTextBox), new PropertyMetadata(null));

    /// <summary>
    /// Gets or sets a brush that describes the foreground color of the PlaceholderText
    /// </summary>
    public Brush? PlaceholderTextBrush
    {
        get { return (Brush)GetValue(PlaceholderTextBrushProperty); }
        set { SetValue(PlaceholderTextBrushProperty, value); }
    }

    /// <summary>
    /// The DependencyProperty for the PlaceholderText.
    /// </summary>
    public static readonly DependencyProperty PlaceholderTextBrushProperty =
        DependencyProperty.Register("PlaceholderTextBrush", typeof(Brush), typeof(CustomTextBox), new PropertyMetadata(null));
}
