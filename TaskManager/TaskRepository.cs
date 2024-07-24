using TaskManager.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TaskManager.Repositories
{
    

    public class TaskRepository : ITaskRepository
    {
        private readonly ApplicationDbContext _context;

        public TaskRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Task> GetAllTasks()
        {
            return _context.Tasks.Include(t => t.User).ToList(); // Include the User
        }

        public Task GetTaskById(int id)
        {
            return _context.Tasks.Include(t => t.User)
                                 .FirstOrDefault(t => t.Id == id);
        }

        public void AddTask(Task task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();
        }

        public void UpdateTask(Task task)
        {
            _context.Tasks.Update(task);
            _context.SaveChanges();
        }

        public void DeleteTask(int id)
        {
            var task = _context.Tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                _context.Tasks.Remove(task);
                _context.SaveChanges();
            }
        }

       

        
    }
}
