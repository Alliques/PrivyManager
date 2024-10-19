using Avalonia.Controls;
using PrivyManager.ViewModels;

namespace PrivyManager.Controls;

public partial class ControlPanel : UserControl
{
    public ControlPanel()
    {
        InitializeComponent();
        DataContext = new ControlPanelViewModel();
    }
}