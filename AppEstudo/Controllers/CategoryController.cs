using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppEstudo.Domain.Models;
using AppEstudo.Infra.Repository;

namespace AppEstudo.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _category;

        public CategoryController(ICategoryRepository category)
        {
            _category = category;
        }

        public IActionResult Index()
        {
            var categories = _category.GetAll();
            return View(categories);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            category.Created = DateTime.Now;
            category.Modified = DateTime.Now;
            _category.Add(category);
            _category.Commit();
            return View();
        }

        public ActionResult Edit(int id)
        {
            var categories = _category.GetById(w => w.ID == id);
            return View(categories);
        }

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            category.Modified = DateTime.Now;
            _category.Update(category);
            _category.Commit();
            return View();
        }

        public ActionResult Delete(Category category)
        {
            _category.Delete(category);
            _category.Commit();
            return View();
        }
    }
}