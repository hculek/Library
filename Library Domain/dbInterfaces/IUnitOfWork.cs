using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Domain.dbInterfaces
{
    public interface IUnitOfWork: IDisposable
    {
        IAuthorRepository Authors { get; }
        IBookRepository Books { get; }
        IGenreRepository Genres { get; }
        int Save();
    }
}
