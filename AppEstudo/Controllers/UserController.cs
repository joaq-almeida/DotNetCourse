using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppEstudo.Infra.Repository;
using AppEstudo.Domain.Models;

namespace AppEstudo.Controllers
{
    public class UserController : Controller
    {
        //private readonly UnitOfwork _unit;
        //public UserController(UnitOfwork unit) { _unit = unit; }
        private readonly IUserRepository _user;

        public UserController(IUserRepository user) 
        {
            _user = user;
        }
        public IActionResult Index()
        {
            var users = _user.GetAll();
            return View(users);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            user.Created = DateTime.Now;
            user.Modified = DateTime.Now;
            _user.Add(user);
            _user.Commit();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var userEdit = _user.GetById(w => w.ID == id);
            return View(userEdit);
        }

        [HttpPost]
        public IActionResult Edit(User user)
        {
            user.Modified = DateTime.Now;
            _user.Update(user);
            _user.Commit();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(User user)
        {
            _user.Delete(user);
            _user.Commit();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var user = _user.GetById(w => w.ID == id);
            return View(user);
        }
    }
}