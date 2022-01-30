using Library_Domain.dbInterfaces;
using Library_Domain.Objects.LibraryMember;

namespace Library_Persistence.Repositories
{
    class LibraryMemberRepository : GenericRepository<LibraryMember>, ILibraryMemberRepository
    {
        public LibraryMemberRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
