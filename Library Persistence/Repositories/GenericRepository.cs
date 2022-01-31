using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Library_Domain;
using Library_Domain.dbInterfaces;

namespace Library_Persistence
{

    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ApplicationContext _context;
        public GenericRepository(ApplicationContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            try
            {
                _context.Set<T>().Add(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void AddRange(IEnumerable<T> entities)
        {
            try
            {
                _context.Set<T>().AddRange(entities);
            }
            catch (Exception)
            {

            }
        }
        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            //return _context.Set<T>().Where(expression);
            try
            {
                return _context.Set<T>().Where(expression);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<T> GetAll()
        {
            try
            {
                //return _context.Set<T>().ToList();
                return _context.Set<T>().ToList() != null ? _context.Set<T>().ToList() : Enumerable.Empty<T>();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        
        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }
        public void Remove(T entity)
        {
            try
            {
                _context.Set<T>().Remove(entity);
            }
            catch (Exception)
            {
            }

        }
        public void RemoveRange(IEnumerable<T> entities)
        {
            try
            {
                _context.Set<T>().RemoveRange(entities);
            }
            catch (Exception)
            {
            }
        }

        public void Update(T entity)
        {
            try
            {
                _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            }
            catch (Exception)
            {
            }
        }

        public void Save() 
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception)
            {
            }
        }
    }
}
