using System;
using System.Collections.Generic;
using System.Linq;
using Library_Domain.Objects;
using Library_Service.UOW;

namespace Library_Service.dbAccess
{
    public class Authors
    {
        public static List<Author> Load()
        {
            try
            {
                using (var uow = UnitOfWorkFactory.Create())
                {
                    var list = uow.Authors.Get().OrderBy(g => g.LastName).ToList();
                    return list;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error. Database connection failed. If problem persists, please contact system administrator.");
            }


        }


        public static void Add(Author author)
        {
            try
            {

                //settle different, check string in class
                //if (String.IsNullOrWhiteSpace(author.FirstName)) ;
                if (!CheckExistingAuthor(author) == true)
                {
                   using (var uow = UnitOfWorkFactory.Create())
                   {
                      uow.Authors.Add(author);
                      uow.Save();
                   }
                }
                else
                {
                    throw new Exception("Error. Record already exists.");
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error. Database connection failed. If problem persists, please contact system administrator.");
            }
        }


        public static void Update(Author author)
        {
            try
            {

                //settle different, check string in class
                //if (String.IsNullOrWhiteSpace(author.FirstName))

                if (CheckExistingID(author) == true)
                {
                   using (var uow = UnitOfWorkFactory.Create())
                   {
                      uow.Authors.Update(author);
                      uow.Save();
                   }
                }
                else
                {
                   throw new Exception("Error. Record does not exist.");
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error. Database connection failed. If problem persists, please contact system administrator.");
            }
        }

        public static void Remove(Author author)
        {
            try
            {
                //settle different, check string in class
                //if (String.IsNullOrWhiteSpace(author.FirstName))
                if (CheckExistingID(author) == true)
                {
                   using (var uow = UnitOfWorkFactory.Create())
                   {
                     uow.Authors.Remove(author);
                     uow.Save();
                   }
                }
                else
                {
                   throw new Exception("Error. Record does not exist.");
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error. Database connection failed. If problem persists, please contact system administrator.");
            }
        }


        private static bool CheckExistingAuthor(Author author)
        {
            var list = Load();
            if (list.Exists(a => a.FirstName == author.FirstName)
                && list.Exists(a => a.MiddleName == author.MiddleName)
                && list.Exists(a => a.LastName == author.LastName))
            {
                return true;
            }
            else return false;
        }

        private static bool CheckExistingID(Author author)
        {
            var list = Load();
            if (list.Exists(a => a.AuthorID == author.AuthorID))
            {
                return true;
            }
            else return false;
        }

    }
}
