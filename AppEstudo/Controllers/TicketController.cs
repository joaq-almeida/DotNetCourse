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

        private readonly TicketRepository _ticket;

        public TicketController(TicketRepository ticket)
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
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Edit(Ticket ticket)
        {
            _ticket.Update(ticket);
            return View();
        }

        public IActionResult Delete(Ticket ticket)
        {
            _ticket.Delete(ticket);
            return View();
        }
    }
}