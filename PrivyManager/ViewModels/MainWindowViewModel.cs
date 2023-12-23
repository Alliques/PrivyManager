using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using PrivyManager.Controls;
using PrivyManager.Enums;
using System;

namespace PrivyManager.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        private IServiceProvider _serviceProvider;
        private ViewModelBase? _currentViewModel;

        public ViewModelBase? CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel = value;
                OnPropertyChanged(nameof(CurrentViewModel));
            }
        }

        public MainWindowViewModel(IServiceProvider serviceProvider)
        {
            CurrentViewModel = new MainViewModel();
            _serviceProvider = serviceProvider;
        }

        [RelayCommand]
        public void SelectedMenuItemChanged(object arg)
        {
            if (arg is MenuItem && arg != null)
            {
                switch ((arg as MenuItem).Type as MenuItems?)
                {
                    case MenuItems.Main:
                        CurrentViewModel = _serviceProvider.GetService<MainViewModel>();
                        break;
                    case MenuItems.Accounts:
                        CurrentViewModel = _serviceProvider.GetService<AccountsViewModel>();
                        break;
                    case MenuItems.Cards:
                        CurrentViewModel = _serviceProvider.GetService<CardsViewModel>();
                        break;
                    case MenuItems.Documents:
                        CurrentViewModel = _serviceProvider.GetService<DocumentsViewModel>();
                        break;
                    case MenuItems.Address:
                        CurrentViewModel = _serviceProvider.GetService<AddressViewModel>();
                        break;
                    case MenuItems.Notes:
                        CurrentViewModel = _serviceProvider.GetService<NotesViewModel>();
                        break;
                    default:
                        throw new Exception("Page not found");
                }
            }
        }
    }
}