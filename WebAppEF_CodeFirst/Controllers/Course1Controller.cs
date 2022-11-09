using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppEF_CodeFirst.IRepository;
using WebAppEF_CodeFirst.Models;
namespace WebAppEF_CodeFirst.Controllers
{
    public class Course1Controller : Controller
    {
        private ICourseRepository _repo;
        public Course1Controller(ICourseRepository repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            return View(_repo.GetCourses().ToList());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Course course)
        {
            _repo.AddCourse(course);
            return RedirectToAction("Index");
        }
    }
}
