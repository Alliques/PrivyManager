using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Styling;
using PrivyManager.ViewModel.Controls;
using System;

namespace PrivyManager.Controls;

public class MenuItem : ListBoxItem, IStyleable
{
    public MenuItem()
    {
        DataContext = new MenuItemViewModel();
    }

    Type IStyleable.StyleKey => typeof(ListBoxItem);

    public int? Count
    {
        get => (int?)GetValue(CountProperty);
        set => SetValue(CountProperty, value);
    }

    public static AvaloniaProperty CountProperty =
        AvaloniaProperty.Register<MenuItem, int?>(nameof(Count));

    public string? Title
    {
        get => (string?)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public static AvaloniaProperty TitleProperty =
        AvaloniaProperty.Register<MenuItem, string>(nameof(Title));

    public Geometry? IconData
    {
        get => (Geometry?)GetValue(IconDataProperty);
        set => SetValue(IconDataProperty, value);
    }

    public static AvaloniaProperty IconDataProperty =
        AvaloniaProperty.Register<MenuItem, Geometry>(nameof(IconData));

    public Brush? IconColor
    {
        get => (Brush)GetValue(IconColorProperty);
        set => SetValue(IconColorProperty, value);
    }

    public static AvaloniaProperty IconColorProperty =
        AvaloniaProperty.Register<MenuItem, Brush>(nameof(IconColor));

    public object Type
    {
        get => (object?)GetValue(TypeProperty);
        set => SetValue(TypeProperty, value);
    }

    public static AvaloniaProperty TypeProperty =
        AvaloniaProperty.Register<MenuItem, object?>(nameof(Type));
}