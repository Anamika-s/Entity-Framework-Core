using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppEF_CodeFirst.IRepository;
using WebAppEF_CodeFirst.Repository;
using WebAppEF_CodeFirst.Models;

namespace WebAppEF_CodeFirst.Controllers
{
    public class BatchController : Controller
    {
        IBatchRepository _repo;
        public BatchController(IBatchRepository repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            return View(_repo.GetBatches());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Batch batch)
        {
            _repo.AddBatch(batch);
            return RedirectToAction("Index");

        }
        public IActionResult Edit(int id)
        {
           Batch batch = _repo.Search(id);
            return View(batch);
        }
        [HttpPost]
        public IActionResult Edit(int id, Batch batch)
        {
            _repo.EditBatch(id, batch);
            return RedirectToAction("Index");

        }

        public IActionResult Delete(int id)
        {
            Batch batch = _repo.Search(id);
            return View(batch);
        }
        [HttpPost]
        public IActionResult Delete(int id, Batch batch)
        {
            _repo.DeleteBatch(id);
            return RedirectToAction("Index");

        }


    }
}
