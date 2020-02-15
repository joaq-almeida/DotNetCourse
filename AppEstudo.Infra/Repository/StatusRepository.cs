using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using AppEstudo.Domain.Models;
using AppEstudo.Infra.Context;

namespace AppEstudo.Infra.Repository
{
    public class StatusRepository : IRepository<Status>, IStatusRepository
    {
        private readonly AppDbContext _context;

        public StatusRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Status entity)
        {
            _context.Status.Add(entity);
        }

        public void Delete(Status entity)
        {
            _context.Status.Remove(entity);
        }

        public IEnumerable<Status> Get(Expression<Func<Status, bool>> predicate)
        {
            return _context.Status.Where(predicate);
        }

        public IEnumerable<Status> GetAll()
        {
            return _context.Status.ToList();
        }

        public Status GetById(Expression<Func<Status, bool>> predicate)
        {
            return _context.Status.SingleOrDefault(predicate);
        }

        public void Update(Status entity)
        {
            _context.Status.Update(entity);
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
