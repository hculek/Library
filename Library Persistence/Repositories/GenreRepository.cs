using Library_Domain.dbInterfaces;
using Library_Domain.Objects;

namespace Library_Persistence.Repositories
{
    public class GenreRepository  : GenericRepository<Genre>, IGenreRepository
    {
        public GenreRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
