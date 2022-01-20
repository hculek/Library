using System.Collections.Generic;

namespace Library_Domain.Book
{
    public interface IBook
    {
        void BookID(long BookID);
        void Title(string Title);
        void TotalPages(int TotalPages);
        void Author(ICollection<Library_Domain.Author.Author> Authors);
        void Genre(ICollection<Library_Domain.Genre.Genre> Genres);
        //Book GetBook();
    }
}
