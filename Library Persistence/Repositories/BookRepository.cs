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
    }
}