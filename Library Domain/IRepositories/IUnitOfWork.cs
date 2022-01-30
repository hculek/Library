using System;

namespace Library_Domain.dbInterfaces
{
    public interface IUnitOfWork: IDisposable
    {
        IAuthorRepository Author { get; }
        IBookRepository Book { get; }
        IGenreRepository Genre { get; }
        int Save();
    }
}
