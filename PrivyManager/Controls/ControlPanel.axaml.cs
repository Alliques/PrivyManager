using Avalonia.Controls;
using PrivyManager.ViewModel;

namespace PrivyManager.Controls;

public partial class ControlPanel : UserControl
{
    public ControlPanel()
    {
        InitializeComponent();
        DataContext = new ControlPanelViewModel();
    }
}