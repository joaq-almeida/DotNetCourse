using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppEstudo.Domain.Models;
using AppEstudo.Infra.Repository;

namespace AppEstudo.Controllers
{
    public class StatusController : Controller
    {
        private readonly IStatusRepository _status;

        public StatusController(IStatusRepository status)
        {
            _status = status;
        }

        public IActionResult Index()
        {
            var statuses = _status.GetAll();
            return View(statuses);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Status status)
        {
            status.Created = DateTime.Now;
            status.Modified = DateTime.Now;
            _status.Add(status);
            _status.Commit();
            return View();
        }

        public ActionResult Edit(int id)
        {
            var statuses = _status.GetById(w => w.ID == id);
            return View(statuses);
        }

        [HttpPost]
        public ActionResult Edit(Status status)
        {
            status.Modified = DateTime.Now;
            _status.Update(status);
            _status.Commit();
            return View();
        }

        public ActionResult Delete(Status status)
        {
            _status.Delete(status);
            _status.Commit();
            return View();
        }
    }
}