using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfBindingOneWayWithSaveButton
{
    public class Note : INotifyPropertyChanged
    {
        private string text;

        public string Text
        {
            get { return text; }
            set
            {
                text = value; 
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}