using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Styling;
using PrivyManager.ViewModel.Controls;
using System;

namespace PrivyManager.Controls;

public class MenuButton : Button, IStyleable
{
    Type IStyleable.StyleKey => typeof(Button);
    public MenuButton()
    {
        DataContext = new MenuButtonViewModel();
    }

    public int? Count
    {
        get => (int?)GetValue(CountProperty);
        set => SetValue(CountProperty, value);
    }

    public static StyledProperty<int?> CountProperty =
        AvaloniaProperty.Register<MenuButton, int?>(nameof(Count));

    public string? Title
    {
        get => (string?)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public static StyledProperty<string> TitleProperty =
        AvaloniaProperty.Register<MenuButton, string>(nameof(Title));

    public Geometry? IconData
    {
        get => (Geometry?)GetValue(IconDataProperty);
        set => SetValue(IconDataProperty, value);
    }

    public static StyledProperty<Geometry> IconDataProperty =
        AvaloniaProperty.Register<MenuButton, Geometry>(nameof(IconData));

    public Brush? IconColor
    {
        get => (Brush)GetValue(IconColorProperty);
        set => SetValue(IconColorProperty, value);
    }

    public static StyledProperty<Brush> IconColorProperty =
        AvaloniaProperty.Register<MenuButton, Brush>(nameof(IconColor));
}