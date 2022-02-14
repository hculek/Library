using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Library_Domain.Objects;

namespace Library_Domain.dbInterfaces
{
    public interface IAuthorRepository : IGenericRepository<Author>
    {
    }
}
