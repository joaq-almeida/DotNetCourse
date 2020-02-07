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
        private readonly UnitOfwork _unit;

        public UserController(UnitOfwork unit)
        {
            _unit = unit;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            _unit.UserRepository.Add(user);
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Edit(User user)
        {
            _unit.UserRepository.Update(user);
            return View();
        }

        public IActionResult Delete(User user)
        {
            _unit.UserRepository.Delete(user);
            return View();
        }
    }
}