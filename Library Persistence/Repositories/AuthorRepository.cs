using Library_Domain.dbInterfaces;
using Library_Domain.Objects;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Library_Persistence.Repositories
{
    public class AuthorRepository  : GenericRepository<Author>, IAuthorRepository
    {
        private IAuthorRepository _authorRepository;

        public AuthorRepository(ApplicationContext context) : base(context)
        {
        }

        public IEnumerable<Author> FindAuthor(Expression<Func<Author, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
