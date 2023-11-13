using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace MVVMTodo.ViewModels
{
    public class SharedDataViewModel : ViewModelBase
    {
        private List<Models.Task> tasks = new List<Models.Task>();
        public List<Models.Task> Tasks
        {
            get { return tasks; }
            set
            {
                if (tasks != value)
                {
                    tasks = value;
                    OnPropertyChanged(nameof(Tasks));
                }
            }
        }
    }
}
