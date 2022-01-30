using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Library_Domain.Objects.Author;

namespace Library_Domain.dbInterfaces
{
    public interface IAuthorRepository : IGenericRepository<Author>
    {
        IEnumerable<Author> FindAuthor(Expression<Func<Author, bool>> expression);
    }
}
