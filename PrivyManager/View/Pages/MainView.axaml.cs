using Avalonia.Controls;
using PrivyManager.ViewModels;

namespace PrivyManager.View;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
        DataContext = new MainViewModel();
    }
}