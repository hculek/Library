using Library_Domain.dbInterfaces;
using Library_Domain.Objects.Book;
using Library_Domain.Objects.JunctionObj;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Library_Persistence.Repositories
{
    public class BookGenreRepository  : GenericRepository<BookGenre>, IBookGenreRepository
    {
        public BookGenreRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
