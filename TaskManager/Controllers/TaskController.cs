using Microsoft.AspNetCore.Mvc;
using TaskManager.Models;
using TaskManager.Repositories;
using System.Linq;

namespace TaskManager.Controllers
{
    public class TaskController : Controller
    {
        private readonly ITaskRepository _taskRepository;
        private readonly IUserRepository _userRepository;

        public TaskController(ITaskRepository taskRepository, IUserRepository userRepository)
        {
            _taskRepository = taskRepository;
            _userRepository = userRepository;
        }

        public IActionResult Index()
        {
            var tasks = _taskRepository.GetAllTasks();
            var users = _userRepository.GetAllUsers(); // Fetch all users

            ViewBag.Users = users; // Pass users to the view
            return View(tasks);
        }


        public IActionResult CreateTask()
        {
            ViewBag.Users = _userRepository.GetAllUsers().ToList(); // Populate the users for dropdown
            return View();
        }

        [HttpPost]
        public IActionResult CreateTask(Task task)
        {
            if (ModelState.IsValid)
            {
                _taskRepository.AddTask(task);
                return RedirectToAction("Index");
            }
            ViewBag.Users = _userRepository.GetAllUsers().ToList(); // Re-populate users if validation fails
            return View(task);
        }

        public IActionResult UpdateTask(int id)
        {
            var task = _taskRepository.GetTaskById(id);
            if (task == null)
            {
                return NotFound();
            }
            ViewBag.Users = _userRepository.GetAllUsers().ToList(); // Populate the users for dropdown
            return View(task);
        }

        [HttpPost]
        public IActionResult UpdateTask(Task task)
        {
            if (ModelState.IsValid)
            {
                _taskRepository.UpdateTask(task);
                return RedirectToAction("Index");
            }
            ViewBag.Users = _userRepository.GetAllUsers().ToList(); // Re-populate users if validation fails
            return View(task);
        }

        public IActionResult ViewTask(int id)
        {
            var task = _taskRepository.GetTaskById(id);
            if (task == null)
            {
                return NotFound();
            }
            return View(task);
        }

        public IActionResult DeleteTask(int id)
        {
            _taskRepository.DeleteTask(id);
            return RedirectToAction("Index");
        }
    }
}
