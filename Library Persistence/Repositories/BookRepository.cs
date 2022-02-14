using Library_Domain.dbInterfaces;
using Library_Domain.Objects;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.Entity;

namespace Library_Persistence.Repositories
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(ApplicationContext context) : base(context)
        {
        }
        public override void Add(Book entity) 
        {
            try
            {
                _context.Set<Book>().Add(entity);
                //_context.Set<Author>().Attach();
                _context.Entry(entity.Authors).State = EntityState.Unchanged;
                _context.Entry(entity.Genres).State = EntityState.Unchanged;

                //https://docs.microsoft.com/en-us/archive/msdn-magazine/2013/april/data-points-why-does-entity-framework-reinsert-existing-objects-into-my-database
            }
            catch (DBConcurrencyException)
            {
                throw new DBConcurrencyException("Database connection error. If problem persists please contact IT support.");
            }

            catch (Exception)
            {
                throw new Exception("Database connection error. If problem persists please contact IT support.");
            }

        }





    }
}