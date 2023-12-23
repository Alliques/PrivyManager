using System;
using System.Windows.Input;
using TextCopy;

namespace PrivyManager.Commands
{
    public class CopyToClipboardCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is string text)
            {
                ClipboardService.SetText(text);
            }
        }

        public event EventHandler CanExecuteChanged;
    }
}
