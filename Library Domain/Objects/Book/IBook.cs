using System.Collections.Generic;

namespace Library_Domain.Objects
{
    public interface IBook
    {
        void BookID(long BookID);
        void Title(string Title);
        void TotalPages(int TotalPages);
        void Author(ICollection<Author> Authors);
        void Genre(ICollection<Genre> Genres);
        //Book GetBook();
    }
}
