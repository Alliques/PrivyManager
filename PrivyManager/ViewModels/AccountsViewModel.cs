using ReactiveUI;
using System;
using System.Reactive.Disposables;

namespace PrivyManager.ViewModels
{
    public class AccountsViewModel : ViewModelBase, IRoutableViewModel
    {
        public IScreen HostScreen { get; }

        public string? UrlPathSegment => Guid.NewGuid().ToString().Substring(0, 5);

        public AccountsViewModel(IScreen screen) : base()
        {
            HostScreen = screen;
        }

    }
}
