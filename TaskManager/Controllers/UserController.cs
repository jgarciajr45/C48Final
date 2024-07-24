using Microsoft.AspNetCore.Mvc;
using TaskManager.Models;
using TaskManager.Repositories;

namespace TaskManager.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult Index()
        {
            var users = _userRepository.GetAllUsers();
            return View(users);
        }

        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateUser(User user)
        {
            if (ModelState.IsValid)
            {
                _userRepository.AddUser(user);
                return RedirectToAction("Index");
            }
            return View(user);
        }

        public IActionResult UpdateUser(int id)
        {
            var user = _userRepository.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost]
        public IActionResult UpdateUser(User user)
        {
            if (ModelState.IsValid)
            {
                _userRepository.UpdateUser(user);
                return RedirectToAction("Index");
            }
            return View(user);
        }

        public IActionResult ViewUser(int id)
        {
            var user = _userRepository.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        public IActionResult DeleteUser(int id)
        {
            _userRepository.DeleteUser(id);
            return RedirectToAction("Index");
        }
    }
}
