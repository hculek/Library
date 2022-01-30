using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Library_Domain.dbInterfaces
{
    public interface IAuthorRepository : IGenericRepository<Author.Author>
    {
        IEnumerable<Author.Author> FindAuthor(Expression<Func<Author.Author, bool>> expression);
    }
}
