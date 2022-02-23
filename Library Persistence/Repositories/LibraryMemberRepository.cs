using Library_Domain.dbInterfaces;
using Library_Domain.Objects;

namespace Library_Persistence.Repositories
{
    class LibraryMemberRepository : GenericRepository<LibraryMember>, ILibraryMemberRepository
    {
        public LibraryMemberRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
