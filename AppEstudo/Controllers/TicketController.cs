using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppEstudo.Infra.Repository;
using AppEstudo.Domain.Models;

namespace AppEstudo.Controllers
{
    public class TicketController : Controller
    {
        //private readonly UnitOfwork _unit;
        //public TicketController(UnitOfwork unit){ _unit = unit; }

        private readonly ITicketRepository _ticket;

        public TicketController(ITicketRepository ticket)
        {
            _ticket = ticket;
        }

        public IActionResult Index()
        {
            var tickets = _ticket.GetAll();
            return View(tickets);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Create(Ticket ticket)
        {
            _ticket.Add(ticket);
            _ticket.Commit();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var ticket = _ticket.GetById(w => w.ID == id);
            return View(ticket);
        }

        [HttpPost]
        public IActionResult Edit(Ticket ticket)
        {
            _ticket.Update(ticket);
            _ticket.Commit();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(Ticket ticket)
        {
            _ticket.Delete(ticket);
            _ticket.Commit();
            return View();
        }

    }
}