using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Styling;

namespace PrivyManager.Controls;

public class LoginTextBox : TextBox, IStyleable
{
    public Geometry? Icon
    {
        get => (Geometry?)GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }

    public static StyledProperty<Geometry> IconProperty =
        AvaloniaProperty.Register<SearchTextBox, Geometry>(nameof(Icon));

    public Brush? IconColor
    {
        get => GetValue(IconColorProperty);
        set => SetValue(IconColorProperty, value);
    }

    public static StyledProperty<Brush> IconColorProperty =
        AvaloniaProperty.Register<SearchTextBox, Brush>(nameof(IconColor));
}