using MVVMToDoApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMToDoApp.Models
{
    public class Task
    {
        public string TaskTitle { get; private set; }
        public string TaskDescription { get; private set; }
        public TaskStatus TaskStatus { get; private set; }

        public Task(string title, string description, TaskStatus status)
        {
            TaskTitle = title;
            TaskDescription = description;
            TaskStatus = status;
        }

        public override string ToString()
        {
            return $"{TaskTitle}{TaskDescription}{TaskStatus}";
        }

        public static string getStatus(TaskStatus status)
        {
            switch (status)
            {
                case TaskStatus.DONE:
                    return "Done";

                case TaskStatus.NOTDONE:
                    return "Not Done";

                case TaskStatus.DUE:
                    return "Due";

                case TaskStatus.INPROGRESS:
                    return "In Progress";

                default:
                    return "Not Found";
            }
        }

        public static TaskStatus setStatus(string status)
        {
            switch (status)
            {
                case "Not Started":
                    return TaskStatus.DONE;

                case "Not Done":
                    return TaskStatus.NOTDONE;

                case "Due":
                    return TaskStatus.DUE;

                case "In Progress":
                    return TaskStatus.INPROGRESS;

                default:
                    return TaskStatus.NOTDONE;
            }
        }
    }
}
