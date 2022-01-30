using System.Collections.Generic;

namespace Library_Domain.Objects.Book
{
    public interface IBook
    {
        void BookID(long BookID);
        void Title(string Title);
        void TotalPages(int TotalPages);
        void Author(ICollection<Library_Domain.Objects.Author.Author> Authors);
        void Genre(ICollection<Library_Domain.Objects.Genre.Genre> Genres);
        //Book GetBook();
    }
}
