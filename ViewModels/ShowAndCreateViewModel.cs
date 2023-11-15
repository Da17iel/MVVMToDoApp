using MVVMToDoApp.Commands;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MVVMToDoApp.ViewModels
{
    public class ShowAndCreateViewModel : ViewModelBase
    {
        public ICommand AddTask { get; }

        public ObservableCollection<Models.Task> Tasks { get; set; }


        private string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (title != value)
                {
                    title = value;
                    OnPropertyChanged(nameof(Title));
                }
            }
        }

        private string description;
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (description != value)
                {
                    description = value;
                    OnPropertyChanged(nameof(Description));
                }
            }
        }

        private Models.TaskStatus status;
        public Models.TaskStatus Status
        {
            get
            {
                return status;
            }
            set
            {
                if (status != value)
                {
                    status = value;
                    OnPropertyChanged(nameof(Status));
                }
            }
        }

        public void clearGUI()
        {
            Title = "";
            Description = "";
            Status = Models.TaskStatus.DONE;

        }

        public ShowAndCreateViewModel()
        {
            Tasks = new ObservableCollection<Models.Task>();
            AddTask = new AddTaskCommand(this);
        }
    }
}
