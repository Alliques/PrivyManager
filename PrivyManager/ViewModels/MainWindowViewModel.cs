using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using PrivyManager.Enums;
using PrivyManager.Navigation;
using System;

namespace PrivyManager.ViewModel
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        private readonly Router<ViewModelBase> _router;
        private readonly Window _mainWindow;
        private IServiceProvider _serviceProvider;

        [ObservableProperty]
        private ViewModelBase _content = default!;

        public MainWindowViewModel(
            Window mainWindow, 
            Router<ViewModelBase> router, 
            IServiceProvider serviceProvider)
        {
            _router = router;
            _router.CurrentViewModelChanged += viewModel => Content = viewModel;
            _router.GoTo<MainViewModel>();
            _mainWindow = mainWindow;
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
                        _router.GoTo<MainViewModel>();
                        break;
                    case Pages.Accounts:
                        _router.GoTo<AccountsViewModel>();
                        break;
                    case Pages.Cards:
                        _router.GoTo<CardsViewModel>();
                        break;
                    case Pages.Documents:
                        _router.GoTo<DocumentsViewModel>();
                        break;
                    case Pages.Address:
                        _router.GoTo<AddressViewModel>();
                        break;
                    case Pages.Notes:
                        _router.GoTo<NotesViewModel>();
                        break;
                    default:
                        throw new Exception("Page not found");
                }
            }
        }
    }
}