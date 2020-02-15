using System;
using System.Collections.Generic;
using System.Text;
using AppEstudo.Domain.Models;
using System.Linq;
using System.Linq.Expressions;
using AppEstudo.Infra.Context;

namespace AppEstudo.Infra.Repository
{
    public class PriorityRepository : IRepository<Priority>, IPriorityRepository
    {
        private readonly AppDbContext _context;

        public PriorityRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Priority entity)
        {
            _context.Priority.Add(entity);
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Delete(Priority entity)
        {
            _context.Priority.Remove(entity);
        }

        public IEnumerable<Priority> Get(Expression<Func<Priority, bool>> predicate)
        {
            return _context.Priority.Where(predicate);
        }

        public IEnumerable<Priority> GetAll()
        {
            return _context.Priority.ToList();
        }

        public Priority GetById(Expression<Func<Priority, bool>> predicate)
        {
            return _context.Priority.SingleOrDefault(predicate);
        }

        public void Update(Priority entity)
        {
            _context.Priority.Update(entity);
        }
    }
}
