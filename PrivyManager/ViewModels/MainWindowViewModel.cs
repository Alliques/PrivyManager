using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace PrivyManager.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public object SelectedMenuItem { get; set; }
        public ICommand SelectedMenuItemChangedCommand { get; set; }

        public MainWindowViewModel()
        {
            SelectedMenuItemChangedCommand = new RelayCommand<object>((arg) => SelectedMenuItemChanged(arg));
        }


        public void SelectedMenuItemChanged(object arg)
        {
         
        }
    }
}