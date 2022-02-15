using Library_Domain.dbInterfaces;
using Library_Domain.Objects;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Library_Persistence.Repositories
{
    public class AuthorRepository  : GenericRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
