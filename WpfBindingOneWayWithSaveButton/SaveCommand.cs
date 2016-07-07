using System;
using System.Windows.Input;

namespace WpfBindingOneWayWithSaveButton
{
    public class SaveCommand : ICommand
    {
        private MainWindowsViewModel vm;

        public SaveCommand(MainWindowsViewModel vm)
        {
            this.vm = vm;
        }

        public bool CanExecute(object parameter)
        {
            // What should go here?
            return true;

            // Pseudo code
            // return (is the TextBox text different from the original note text)
        }

        public void Execute(object parameter)
        {
            // What should go here?

            // Pseudo code
            // Let WPF know that the TextBox text has changed
            // Invoke the binding so it propagates the TextBox text back to the list
        }

        public event EventHandler CanExecuteChanged;
    }
}