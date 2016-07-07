using System.Collections.ObjectModel;
using System.Windows.Input;

namespace WpfBindingOneWayWithSaveButton
{
    public class MainWindowsViewModel
    {
        public ObservableCollection<Note> ListOfNotes { get; set; }

        public Note SelectedNote { get; set; }

        public ICommand SaveCommand { get; set; }

        public MainWindowsViewModel()
        {
            ListOfNotes = new ObservableCollection<Note>
            {
                new Note { Text = "Note 1" },
                new Note { Text = "Note 2" }
            };
            SaveCommand = new SaveCommand(this);
        }
    }
}