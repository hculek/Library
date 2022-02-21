using System;
using System.Collections.Generic;
using System.Linq;
using Library_Domain.Objects;
using Library_Service.UOW;

namespace Library_Service.dbAccess
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

                //settle different, check string in class
                //if (String.IsNullOrWhiteSpace(genre.GenreName))


                if (!CheckExistingName(genre) == true)
                {
                    using (var uow = UnitOfWorkFactory.Create())
                    {
                        uow.Genres.Add(genre);
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
                throw ex;
            }
        }

        public static void Update(Genre genre)
        {
            try
            {
                if (CheckExistingID(genre) == true)
                {
                    using (var uow = UnitOfWorkFactory.Create())
                    {
                        uow.Genres.Update(genre);
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
                throw ex;
            }
        }

        public static void Remove(Genre genre)
        {
            try
            {
                if (CheckExistingID(genre) == true)
                {
                    using (var uow = UnitOfWorkFactory.Create())
                    {
                        uow.Genres.Remove(genre);
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
                throw ex;
            }
        }


        private static bool CheckExistingName(Genre genre) 
        {
            var list = Load();
            return list.Any(g => g.GenreName == genre.GenreName) ? true : false;
        }

        private static bool CheckExistingID(Genre genre)
        {
            var list = Load();
            return list.Any(g => g.GenreID == genre.GenreID) ? true : false;
        }

    }
}
