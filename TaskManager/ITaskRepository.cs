using System.Collections.Generic;
using TaskManager.Models;

namespace TaskManager.Repositories
{
    public interface ITaskRepository
    {
        IEnumerable<Task> GetAllTasks();
        Task GetTaskById(int id);
        void AddTask(Task task);
        void UpdateTask(Task task);
        void DeleteTask(int id);
    }
}
