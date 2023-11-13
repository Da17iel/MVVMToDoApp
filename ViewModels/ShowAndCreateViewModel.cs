using MVVMTodo.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MVVMTodo.ViewModels
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

            Tasks.Add(new Models.Task("New Task", "Desc.", Models.TaskStatus.NOTDONE));
            Tasks.Add(new Models.Task("TestTask 1", "Sample Text 1", Models.TaskStatus.DUE));
            Tasks.Add(new Models.Task("TestTask 2", "Sample Text 2", Models.TaskStatus.INPROGRESS));
            Tasks.Add(new Models.Task("TestTask 3", "Sample Text 3", Models.TaskStatus.NOTDONE));

        }
    }
}
