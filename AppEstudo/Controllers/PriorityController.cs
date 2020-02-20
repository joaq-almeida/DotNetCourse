using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppEstudo.Domain.Models;
using AppEstudo.Infra.Repository;

namespace AppEstudo.Controllers
{
    public class PriorityController : Controller
    {
        private readonly IPriorityRepository _priority;
        
        public PriorityController(IPriorityRepository priority)
        {
            _priority = priority;
        }

        public IActionResult Index()
        {
            var priorities = _priority.GetAll();
            return View(priorities);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Priority priority)
        {
            priority.Created = DateTime.Now;
            priority.Modified = DateTime.Now;
            priority.CreatedBy.ID = 1;
            priority.ModifiedBy.ID = 1;
            _priority.Add(priority);
            _priority.Commit();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var priorities =_priority.GetById(w => w.ID == id);
            return View(priorities);
        }

        [HttpPost]
        public ActionResult Edit(Priority priority)
        {
            priority.Modified = DateTime.Now;
            _priority.Update(priority);
            _priority.Commit();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(Priority priority)
        {
            _priority.Delete(priority);
            _priority.Commit();
            return View();
        }
    }
}