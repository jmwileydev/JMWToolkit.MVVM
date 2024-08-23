using System.Windows;
using System.Windows.Controls;

namespace JMWToolkit.MVVM.Controls;

/// <summary>
/// This is a button which allows you to specify a rounded corner.
/// </summary>
public class RoundedCornerButton : Button
{
    /// <summary>
    /// The CornerRadius for the button. Default is (0,0,0,0)
    /// </summary>
    public CornerRadius CornerRadius
    {
        get { return (CornerRadius)GetValue(CornerRadiusProperty); }
        set { SetValue(CornerRadiusProperty, value); }
    }

    /// <summary>
    /// The DependencyProperty for the CornerRadius
    /// </summary>
    public static readonly DependencyProperty CornerRadiusProperty =
        DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(RoundedCornerButton), new PropertyMetadata(new CornerRadius(0, 0, 0, 0)));
}
