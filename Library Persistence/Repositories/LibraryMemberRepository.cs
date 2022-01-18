using Library_Domain.dbInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Persistence.Repositories
{
    class LibraryMemberRepository : GenericRepository<Library_Domain.LibraryMember.LibraryMember>, ILibraryMemberRepository
    {
        public LibraryMemberRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
