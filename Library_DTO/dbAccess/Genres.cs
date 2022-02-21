using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Domain.Objects;
using Library_Service.UOW;

namespace Library_DTO.dbAccess
{
    public class Genres
    {

        public static List<Genre> Load() 
        {
            try
            {
                using (var uow = UnitOfWorkFactory.Create())
                {
                    var list = uow.Genres.Get().OrderBy(g => g.GenreName).ToList();
                    return list;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }


        public static void Add(Genre genre)
        {
            try
            {

                if (!CheckExisting(genre) == true)
                {
                    using (var uow = UnitOfWorkFactory.Create())
                    {
                        uow.Genres.Add(genre);
                        uow.Save();
                    }
                }
                else
                {
                    throw new Exception("Record already exists.");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Update(Genre genre)
        {
            try
            {
                if (CheckExisting(genre) == true) 
                {
                    using (var uow = UnitOfWorkFactory.Create())
                    {
                        uow.Genres.Update(genre);
                        uow.Save();
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Remove(Genre genre)
        {
            try
            {
                if (CheckExisting(genre) == true)
                {
                    using (var uow = UnitOfWorkFactory.Create())
                    {
                        uow.Genres.Remove(genre);
                        uow.Save();
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private static bool CheckExisting(Genre genre) 
        {
            var list = Load();
            return list.Any(g => g.GenreName == genre.GenreName) ? true : false;
        }
    }
}
