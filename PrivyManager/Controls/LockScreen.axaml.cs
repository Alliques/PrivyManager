using Avalonia;
using Avalonia.Controls.Primitives;
using PrivyManager.ViewModel;

namespace PrivyManager.Controls;

public class LockScreen : TemplatedControl
{
    public LockScreen()
    {
        DataContext = new LockScreenViewModel();
    }
}