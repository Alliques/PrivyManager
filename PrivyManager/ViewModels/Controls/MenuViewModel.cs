namespace PrivyManager.ViewModels.Controls
{
    public class MenuViewModel : ViewModelBase
    {
        private object _value;
        public bool IsMenuOpened { get; set; }
        public double MenuWidth { get; set; } = 50;
        public object SelectedItem
        {
            get { return _value; }
            set { _value = value; }
        }

        public void Open()
        {
            MenuWidth = 200d;
        }

    }
}
