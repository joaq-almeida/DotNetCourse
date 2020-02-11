using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace AppEstudo.Infra.Repository
{
    public interface IRepository<T> where T: class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);
        T GetById(Expression<Func<T, bool>> predicate);
        void Commit();
    }
}
