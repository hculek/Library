using Library_Domain.Author;
using Library_Domain.dbInterfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Library_Persistence.Repositories
{
    public class AuthorRepository  : GenericRepository<Library_Domain.Author.Author>, IAuthorRepository
    {
        private IAuthorRepository _authorRepository;

        public AuthorRepository(ApplicationContext context) : base(context)
        {
        }

        public IEnumerable<Author> FindAuthor(Expression<Func<Author, bool>> expression)
        {
            //var authors = from author in _authorRepository.Find(f => (f.FirstName + " " + f.MiddleName + " " + f.LastName).Contains(SearchTerm))
            //              select author;

            //return authors;
            return null;
        }
    }
}
