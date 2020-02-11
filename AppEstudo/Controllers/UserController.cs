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
            _user.Add(user);
            _user.Commit();
            return View("Home", "Index");
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Edit(User user)
        {
            _user.Update(user);
            return View();
        }

        public IActionResult Delete(User user)
        {
            _user.Delete(user);
            return View();
        }
    }
}