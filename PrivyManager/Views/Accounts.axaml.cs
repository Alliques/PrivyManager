using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using PrivyManager.ViewModels;
using ReactiveUI;

namespace PrivyManager.Views;

public partial class Accounts : ReactiveUserControl<AccountsViewModel>
{
    public Accounts()
    {
        // If we need to handle view model activation and deactivation
        this.WhenActivated(disposables => { });
        AvaloniaXamlLoader.Load(this);
    }
}