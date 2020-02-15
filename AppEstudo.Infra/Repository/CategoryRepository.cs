using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using AppEstudo.Domain.Models;
using AppEstudo.Infra.Context;
using System.Linq;


namespace AppEstudo.Infra.Repository
{
    public class CategoryRepository : IRepository<Category>, ICategoryRepository
    {
        public readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }


        public void Add(Category entity)
        {
            _context.Category.Add(entity);
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Delete(Category entity)
        {
            _context.Category.Remove(entity);
        }

        public IEnumerable<Category> Get(Expression<Func<Category, bool>> predicate)
        {
            return _context.Category.Where(predicate);
        }

        public IEnumerable<Category> GetAll()
        {
            return _context.Category.ToList();
        }

        public Category GetById(Expression<Func<Category, bool>> predicate)
        {
            return _context.Category.SingleOrDefault(predicate);
        }

        public void Update(Category entity)
        {
            _context.Category.Update(entity);
        }
    }
}
