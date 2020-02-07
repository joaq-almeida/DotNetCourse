using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using AppEstudo.Domain.Models;
using AppEstudo.Infra.Context;

namespace AppEstudo.Infra.Repository
{
    public class TicketRepository : IRepository<Ticket>, ITicketRepository
    {
        private readonly AppDbContext _context;

        public TicketRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Ticket entity)
        {
            _context.Ticket.Add(entity);
        }

        public void Delete(Ticket entity)
        {
            _context.Ticket.Remove(entity);
        }

        public IEnumerable<Ticket> Get(Expression<Func<Ticket, bool>> predicate)
        {
            return _context.Ticket.Where(predicate);
        }

        public IEnumerable<Ticket> GetAll()
        {
            return _context.Ticket.ToList();
        }

        public Ticket GetById(Expression<Func<Ticket, bool>> predicate)
        {
            return _context.Ticket.FirstOrDefault(predicate);
        }

        public void Update(Ticket entity)
        {
            _context.Ticket.Update(entity);
        }
    }
}
