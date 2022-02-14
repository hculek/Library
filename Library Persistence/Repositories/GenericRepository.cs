using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data;
using Library_Domain.dbInterfaces;
using System.Data.Entity;

namespace Library_Persistence
{

    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ApplicationContext _context;
        public GenericRepository(ApplicationContext context)
        {
            _context = context;
        }
        public virtual void Add(T entity)
        {
            try
            {
                _context.Set<T>().Add(entity);
            }
            catch (DBConcurrencyException)
            {

                //https://stackoverflow.com/questions/29994402/is-there-a-way-to-throw-custom-exception-without-exception-class

                throw new DBConcurrencyException("Database connection error. If problem persists please contact IT support.");
            }

            catch (Exception)
            {
                throw new Exception("Database connection error. If problem persists please contact IT support.");
            }

        }
        public virtual void AddRange(IEnumerable<T> entities)
        {
            try
            {
                _context.Set<T>().AddRange(entities);
            }
            catch (Exception)
            {

            }
        }
        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> expression)
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
        public virtual IEnumerable<T> Get()
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

        public virtual IEnumerable<T> GetAll(params Expression<Func<T, object>>[] navigationProperties)
        {
            try
            {
                List<T> list;
                using (var context = new ApplicationContext())
                {
                    IQueryable<T> dbQuery = context.Set<T>();

                    //Apply eager loading
                    foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                        dbQuery = dbQuery.Include<T, object>(navigationProperty);

                    list = dbQuery
                        .AsNoTracking()
                        .ToList<T>();
                }
                return list;
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
                //_context.Set<T>().Remove(entity);
                _context.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
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
