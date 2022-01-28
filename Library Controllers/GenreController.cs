using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Domain.dbInterfaces;
using Library_Domain.Genre;
using Library_Persistence;
using Library_Persistence.Repositories;

namespace Library_Controllers
{
    public class GenreController
    {
        private IGenreRepository _genreRepository;
        public GenreController()
        {
            this._genreRepository = new GenreRepository(new ApplicationContext());
        }

        public IEnumerable<Genre> GetAll() 
        {
            try
            {
                var genres = from genre in _genreRepository.GetAll()
                             select genre;
                return genres;
            }
            catch (Exception)
            {
            }
            return null;
        }

        public IEnumerable<Genre> Find(string SearchTerm)
        {
            try
            {
                var genres = from genre in _genreRepository.Find(f => f.GenreName.Equals(SearchTerm))
                             select genre;
                return genres;
            }
            catch (Exception)
            {
            }
            return null;
        }

        public void Add(Genre Genre) 
        {
            try
            {
                _genreRepository.Add(Genre);
                _genreRepository.Save();
            }
            catch (Exception)
            {
                //"Unable to save changes. Try again, and if the problem persists see your system administrator."
            }

        }

        public void AddRange(IEnumerable<Genre> Genres)
        {
            try
            {
                foreach (var genre in Genres)
                {
                    _genreRepository.Add(genre);
                }
                _genreRepository.Save();
            }
            catch (Exception)
            {
            }
        }

        public void Update(Genre Genre)
        {
            try
            {
                _genreRepository.Update(Genre);
                _genreRepository.Save();
            }
            catch (Exception)
            {
            }
        }

        public void Remove(Genre Genre)
        {
            try
            {
                _genreRepository.Remove(Genre);
                _genreRepository.Save();
            }
            catch (Exception)
            {
            }
        }

        public void RemoveRange(IEnumerable<Genre> Genres)
        {
            try
            {
                foreach (var genre in Genres)
                {
                    _genreRepository.Remove(genre);
                }
                _genreRepository.Save();

            }
            catch (Exception)
            {
            }
        }

        //https://www.c-sharpcorner.com/UploadFile/3d39b4/crud-using-the-repository-pattern-in-mvc/
    }
}
