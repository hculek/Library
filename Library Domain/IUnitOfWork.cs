using System;
using Library_Domain.dbInterfaces;

namespace Library_Domain
{
    public interface IUnitOfWork: IDisposable
    {
        IAuthorRepository Authors { get; }
        IBookRepository Books { get; }
        IGenreRepository Genres { get; }
        int Save();
    }
}
