using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Domain.Objects;
using Library_Service.UOW;

namespace Library_Service.dbAccess
{
    public class LibraryMembers
    {
        public static List<LibraryMember> Load()
        {
            try
            {
                using (var uow = UnitOfWorkFactory.Create())
                {
                    var list = uow.LibraryMembers.Get().OrderBy(m=>m.Lastname).ToList();
                    return list;
                }

            }
            catch (Exception)
            {

                throw new Exception("Error. Database connection failed. If problem persists, please contact system administrator.");
            }
        
        }

        public static void Add(LibraryMember libraryMember) 
        {
            try
            {
                using (var uow = UnitOfWorkFactory.Create()) 
                {
                    uow.LibraryMembers.Add(libraryMember);
                    uow.Save();
                }

            }
            catch (Exception)
            {

                throw new Exception("Error. Database connection failed. If problem persists, please contact system administrator.");
            }
        
        }

        public static void Update(LibraryMember libraryMember)
        {
            try
            {
                if (CheckExistingID(libraryMember))
                {
                    using (var uow = UnitOfWorkFactory.Create())
                    {
                        uow.LibraryMembers.Update(libraryMember);
                        uow.Save();
                    }

                }
                else
                {
                    throw new Exception("Error. Record does not exist.");
                }

            }
            catch (Exception)
            {

                throw new Exception("Error. Database connection failed. If problem persists, please contact system administrator.");
            }

        }

        public static void Remove(LibraryMember libraryMember)
        {
            try
            {
                if (CheckExistingID(libraryMember))
                {
                    using (var uow = UnitOfWorkFactory.Create())
                    {
                        uow.LibraryMembers.Remove(libraryMember);
                        uow.Save();
                    }

                }
                else
                {
                    throw new Exception("Error. Record does not exist.");
                }

            }
            catch (Exception)
            {

                throw new Exception("Error. Database connection failed. If problem persists, please contact system administrator.");
            }

        }

        private static bool CheckExistingID(LibraryMember libraryMember)
        {
            var list = Load();
            return list.Any(g => g.LibraryMemberID == libraryMember.LibraryMemberID) ? true : false;
        }

    }
}
