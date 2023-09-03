using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace PrivyManager.Views;

public partial class AccountsView : ReactiveUserControl<AccountsView>
{
    public AccountsView()
    {
        this.WhenActivated(disposables => { });
        AvaloniaXamlLoader.Load(this);
    }
}