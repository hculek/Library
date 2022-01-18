using System.Collections.Generic;

namespace Library_Domain.Book
{
    public interface IBook
    {
        void BookID(long BookID);
        void Title(string Title);
        void TotalPages(int TotalPages);
        void Author(List<Library_Domain.Author.Author> Authors);
        void Genre(List<Library_Domain.Genre.Genre> Genres);
        //Book GetBook();
    }
}
