using Avalonia.Controls;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using PrivyManager.Enums;
using System;

namespace PrivyManager.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        private readonly Window _mainWindow;
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

        public MainWindowViewModel(Window mainWindow, IServiceProvider serviceProvider)
        {
            _mainWindow = mainWindow;
            CurrentViewModel = new MainViewModel();
            _serviceProvider = serviceProvider;
        }

        [RelayCommand]
        public void SelectedMenuItemChanged(object arg)
        {
            if (arg is PrivyManager.Controls.MenuItem && arg != null)
            {
                switch (((PrivyManager.Controls.MenuItem)arg).Type as Pages?)
                {
                    case Pages.Main:
                        CurrentViewModel = _serviceProvider.GetService<MainViewModel>();
                        break;
                    case Pages.Accounts:
                        CurrentViewModel = _serviceProvider.GetService<AccountsViewModel>();
                        break;
                    case Pages.Cards:
                        CurrentViewModel = _serviceProvider.GetService<CardsViewModel>();
                        break;
                    case Pages.Documents:
                        CurrentViewModel = _serviceProvider.GetService<DocumentsViewModel>();
                        break;
                    case Pages.Address:
                        CurrentViewModel = _serviceProvider.GetService<AddressViewModel>();
                        break;
                    case Pages.Notes:
                        CurrentViewModel = _serviceProvider.GetService<NotesViewModel>();
                        break;
                    default:
                        throw new Exception("Page not found");
                }
            }
        }
    }
}