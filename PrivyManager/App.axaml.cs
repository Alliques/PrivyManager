using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;
using Microsoft.Extensions.DependencyInjection;
using PrivyManager.Navigation;
using PrivyManager.View;
using PrivyManager.ViewModel;
using System;

namespace PrivyManager
{
    public partial class App : Application
    {
        private ServiceProvider _serviceProvider;
        private ServiceCollection _services;
        public App()
        {
            _services = new ServiceCollection();
            ConfigNavigation();
            ConfigViews();
            ConfigureViewModel();
            _serviceProvider = _services.BuildServiceProvider();
        }

        private void ConfigViews()
        {
            _services.AddSingleton<Window>(provider => new MainWindow());
            _services.AddSingleton<MainView>();
        }

        private void ConfigureViewModel()
        {
            _services.AddSingleton<MainWindowViewModel>();
            _services.AddTransient<MainViewModel>();
            _services.AddTransient<DocumentsViewModel>();
            _services.AddTransient<AddressViewModel>();
            _services.AddTransient<AccountsViewModel>();
            _services.AddTransient<NotesViewModel>();
            _services.AddTransient<CardsViewModel>();
        }

        private void ConfigNavigation()
        {
            _services.AddSingleton(s => new Router<ViewModelBase>(t => (ViewModelBase)s.GetRequiredService(t)));
        }

        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                BindingPlugins.DataValidators.RemoveAt(0);
                var mainWindow = _serviceProvider.GetService<Window>();
                desktop.MainWindow = mainWindow;
                mainWindow.DataContext = _serviceProvider.GetService<MainWindowViewModel>();

                var mainView = _serviceProvider.GetService<MainView>();
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}