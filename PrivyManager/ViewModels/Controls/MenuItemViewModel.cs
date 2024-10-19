using Avalonia.Media;
using PrivyManager.Enums;
using System;

namespace PrivyManager.ViewModels.Controls
{
    public class MenuItemViewModel : ViewModelBase
    {
        public MenuItemViewModel()
        {
           
        }
        public string? Title { get; set; }
        public int? Count { get; set; }
        public Geometry? IconData { get; set; }
        public Brush? IconColor { get; set; }
        public string? Content { get; set; }
        private void NavigateTo(object args)
        {
            var viewModel = (Pages)args;
            //var type = Activator.CreateInstance(NavigationHelper.GetViewModel((Pages)args), HostScreen);
            //Router.Navigate.Execute(new AccountsViewModel(HostScreen));
        }
    }
}