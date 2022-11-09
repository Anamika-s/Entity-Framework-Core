using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppEF_CodeFirst.IRepository;
using WebAppEF_CodeFirst.Models;
namespace WebAppEF_CodeFirst.Controllers
{
    public class UserController : Controller
    {
        private IUserRepository _repo;
        public UserController(IUserRepository repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            return View(_repo.GetUsers().ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(User user)
        {
            _repo.AddUser(user);
            return RedirectToAction("Index");
        }

    }
}
