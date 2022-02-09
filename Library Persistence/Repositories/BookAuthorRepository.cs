using Library_Domain.dbInterfaces;
using Library_Domain.Objects.Book;
using Library_Domain.Objects.JunctionObj;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Library_Persistence.Repositories
{
    public class BookAuthorRepository  : GenericRepository<BookAuthor>, IBookAuthorRepository
    {
        public BookAuthorRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
