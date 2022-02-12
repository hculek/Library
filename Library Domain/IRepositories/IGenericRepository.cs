using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Library_Domain.dbInterfaces
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> Get();
        IEnumerable<T> GetAll(params Expression<Func<T, object>>[] navigationProperties);
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);

        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);

        void Update(T entity);
        void Save();
    }
}
