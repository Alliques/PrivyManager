using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;
using Microsoft.Extensions.DependencyInjection;
using PrivyManager.View;
using PrivyManager.ViewModels;
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
            ConfigViews();
            ConfigureViewModels();
            _serviceProvider = _services.BuildServiceProvider();
        }

        private void ConfigViews()
        {
            _services.AddSingleton<Window>(provider => new MainWindow());
            _services.AddSingleton<MainView>();
        }

        private void ConfigureViewModels()
        {
            _services.AddTransient<MainWindowViewModel>();
            _services.AddTransient<MainViewModel>();
            _services.AddTransient<DocumentsViewModel>();
            _services.AddTransient<AddressViewModel>();
            _services.AddTransient<AccountsViewModel>();
            _services.AddTransient<NotesViewModel>();
            _services.AddTransient<CardsViewModel>();
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
                //mainView.DataContext = _serviceProvider.GetService<MainViewModel>();
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}