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
        private readonly UserRepository _user;

        public UserController(UserRepository user) 
        {
            _user = user;
        }
        public IActionResult Index()
        {
            var users = _user.GetAll();
            return View(User);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            _user.Add(user);
            return View();
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