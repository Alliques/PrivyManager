using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using Avalonia.Metadata;
using PrivyManager.ViewModel.Controls;

namespace PrivyManager.Controls;

public class Menu : TemplatedControl
{
    private StackPanel menuPanel;
    public Menu()
    {
        TemplateApplied += OnTemplateApplied;
    }

    public static StyledProperty<MenuItem> ItemProperty =
    AvaloniaProperty.Register<Menu, MenuItem>(nameof(Item));
    public MenuItem? Item
    {
        get => (MenuItem)GetValue(ItemProperty);
    }

    public static readonly StyledProperty<bool> IsMenuOpenProperty =
            AvaloniaProperty.Register<Menu, bool>(nameof(IsMenuOpen));

    public bool IsMenuOpen
    {
        get => GetValue(IsMenuOpenProperty);
        set => SetValue(IsMenuOpenProperty, value);
    }

    [Content]
    public Control MenuContent
    {
        get => GetValue(MenuContentProperty);
        set => SetValue(MenuContentProperty, value);
    }

    public static readonly StyledProperty<Control> MenuContentProperty =
        AvaloniaProperty.Register<Menu, Control>(nameof(MenuContent));

    private void OnTemplateApplied(object sender, TemplateAppliedEventArgs e)
    {
        var button = e.NameScope.Find<Button>("ToggleButton");
        menuPanel = e.NameScope.Find<StackPanel>("SideMenu");
        if (button != null)
        {
            button.Click += ToggleButtonClick;
        }
    }

    private void ToggleButtonClick(object sender, RoutedEventArgs e)
    {
        IsMenuOpen = !IsMenuOpen;
        menuPanel.Width = IsMenuOpen ? 230d : 60d;
    }
}