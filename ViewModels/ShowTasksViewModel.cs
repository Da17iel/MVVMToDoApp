using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMTodo.Models;

namespace MVVMTodo.ViewModels
{
    public class ShowTasksViewModel : ViewModelBase
    {
        private List<Models.Task> _tasks;
        public List<Models.Task> Tasks
        {
            get { return _tasks; }
            set
            {
                if (_tasks != value)
                {
                    _tasks = value;
                    OnPropertyChanged(nameof(Tasks));
                }
            }
        }

        public ShowTasksViewModel(SharedDataViewModel sharedDataViewModel)
        {
            _tasks = sharedDataViewModel.Tasks;

            sharedDataViewModel.Tasks.Add(new Models.Task("New Task", "This is a TestTask", Models.TaskStatus.INPROGRESS));
            sharedDataViewModel.Tasks.Add(new Models.Task("Create Task", "Create a new Task", Models.TaskStatus.DONE));
            sharedDataViewModel.Tasks.Add(new Models.Task("Cook a book", "Cook the cookbook", Models.TaskStatus.DUE));
            sharedDataViewModel.Tasks.Add(new Models.Task("Drive a Car", "Drive a car fast!", Models.TaskStatus.INPROGRESS));
        }
    }
}
