using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;
using Microsoft.Extensions.DependencyInjection;
using PrivyManager.View;
using PrivyManager.ViewModels;

namespace PrivyManager
{
    public partial class App : Application
    {
        private ServiceProvider serviceProvider;
        private ServiceCollection services;
        public App()
        {
            services = new ServiceCollection();
            ConfigureServices();
            serviceProvider = services.BuildServiceProvider();
        }

        private void ConfigureServices()
        {
            services.AddSingleton<MainWindowViewModel>();
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<DocumentsViewModel>();
            services.AddSingleton<AddressViewModel>();
            services.AddSingleton<AccountsViewModel>();
            services.AddSingleton<NotesViewModel>();
            services.AddSingleton<CardsViewModel>();
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
                desktop.MainWindow = new MainWindow
                {
                    DataContext = serviceProvider.GetService<MainWindowViewModel>()
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}