using Library_Domain.dbInterfaces;

namespace Library_Persistence.Repositories
{
    class LibraryMemberRepository : GenericRepository<Library_Domain.LibraryMember.LibraryMember>, ILibraryMemberRepository
    {
        public LibraryMemberRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
