using MVVMTodo.Commands;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MVVMTodo.ViewModels
{
    public class CreateTaskViewModel : ViewModelBase
    {
        public ICommand AddTask { get; }

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

        public CreateTaskViewModel(SharedDataViewModel sharedDataViewModel)
        {
            // Create a new ReplayCommand to bind to the AddTask ICommand property
            //AddTask = new AddTaskCommand(this, sharedDataViewModel);

        }
    }
}
