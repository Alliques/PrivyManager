using PrivyManager.ViewModels;
using ReactiveUI;
using System;

namespace PrivyManager.Views
{
    public class AppViewLocator : IViewLocator
    {
        public IViewFor? ResolveView<T>(T? viewModel, string? contract = null)
        => viewModel switch
        {
            MainViewModel context => new MainView { DataContext = context },
            AccountsViewModel context => new AccountsView { DataContext = context },
            _ => throw new ArgumentOutOfRangeException(nameof(viewModel))
        };
    }
}
