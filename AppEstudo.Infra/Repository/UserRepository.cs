using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using AppEstudo.Domain.Models;
using AppEstudo.Infra.Context;

namespace AppEstudo.Infra.Repository
{
    public class UserRepository: IRepository<User>, IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(User entity)
        {
            _context.User.Add(entity);
        }

        public void Delete(User entity)
        {
            _context.User.Remove(entity);
        }

        public IEnumerable<User> Get(Expression<Func<User, bool>> predicate)
        {
            return _context.User.Where(predicate);
        }

        public IEnumerable<User> GetAll()
        {
            return _context.User.ToList();
        }

        public User GetById(Expression<Func<User, bool>> predicate)
        {
            return _context.User.SingleOrDefault(predicate);
        }

        public void Update(User entity)
        {
            _context.User.Update(entity);
        }
    }
}
