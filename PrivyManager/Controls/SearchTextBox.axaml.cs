using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Media;
using Avalonia.Styling;
using System;

namespace PrivyManager.Controls;

public class SearchTextBox : TextBox, IStyleable
{
    // Type IStyleable.StyleKey => typeof(TextBox);
    public Geometry? Icon
    {
        get => (Geometry?)GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }

    public static StyledProperty<Geometry> IconProperty =
        AvaloniaProperty.Register<SearchTextBox, Geometry>(nameof(Icon));

    public Brush? IconColor
    {
        get => (Brush)GetValue(IconColorProperty);
        set => SetValue(IconColorProperty, value);
    }

    public static StyledProperty<Brush> IconColorProperty =
        AvaloniaProperty.Register<SearchTextBox, Brush>(nameof(IconColor));
}