using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMToDoApp.Models
{
    public class TaskController
    {
        public readonly List<Task> taskList = new List<Task>();

        public TaskController()
        {
            taskList = new List<Task>();
        }

        public List<Task> getAllTasks()
        {
            return taskList;
        }

        public void AddTask(Task task)
        {
            taskList.Add(task);
        }

        public void DeleteTask(Task task)
        {
            taskList.Remove(task);
        }
    }
}
