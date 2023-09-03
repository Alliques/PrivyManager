using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using PrivyManager.ViewModels;
using ReactiveUI;

namespace PrivyManager.Views;

public partial class MainView : ReactiveUserControl<MainViewModel>
{
    public MainView()
    {
        this.WhenActivated(disposables => { });
        AvaloniaXamlLoader.Load(this);
    }
}