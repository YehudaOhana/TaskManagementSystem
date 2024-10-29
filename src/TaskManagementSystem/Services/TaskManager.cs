using TaskManagementSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace TaskManagementSystem.Services
{
    public class TaskManager
    {
        private List<TaskManagementSystem.Models.Task> tasks = [];
        public void AddTask(TaskManagementSystem.Models.Task task) => tasks.Add(task);
        public void DeleteTask(int taskId) => tasks.RemoveAll(t => t.Id == taskId);
        public TaskManagementSystem.Models.Task GetTask(int taskId) => tasks.FirstOrDefault(t => t.Id == taskId);
        public List<TaskManagementSystem.Models.Task> GetAllTasks() => tasks;
        public void UpdateTaskStatus(int taskId, string status)
        {
            var task = GetTask(taskId);
            if (task != null) task.Status = status;
        }

        public List<TaskManagementSystem.Models.Task> SortTasksByPriority() =>
            tasks.OrderBy(t => t.Priority).ToList();

        public List<TaskManagementSystem.Models.Task> SortTasksByDeadline() =>
            tasks.OrderBy(t => t.Deadline).ToList();
    }
}
