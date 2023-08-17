using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using PrivyManager.ViewModels.Controls;
using System;
using System.Collections.Generic;

namespace PrivyManager.Controls;

public partial class Menu : UserControl
{
    public readonly Guid MenuGuid = Guid.NewGuid();
    public Menu()
    {
        InitializeComponent();
        DataContext = new MenuViewModel();
    }
    public static readonly AttachedProperty<IEnumerable<MenuItem>> ItemsProperty =
    AvaloniaProperty.RegisterAttached<Grid, Control, IEnumerable<MenuItem>>("Items");

    public static IEnumerable<MenuItem> GetColumn(Control element)
    {
        return element.GetValue(ItemsProperty);
    }

    public static void SetColumn(Control element, IEnumerable<MenuItem> value)
    {
        element.SetValue(ItemsProperty, value);
    }

    public void OpenMenu(object? sender, RoutedEventArgs args)
    {
        if (((ToggleButton)sender).IsChecked.Value)
        {
            SideMenu.Width = 230;
        }
        else
        {
            SideMenu.Width = 60;
        }
    }
}