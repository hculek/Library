using Library_Domain.dbInterfaces;
using Library_Persistence;
using Library_Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Domain.Controller
{
    public class GenreController
    {
        private IGenreRepository _genreRepository;
        public GenreController()
        {
            this._genreRepository = new GenreRepository(new ApplicationContext());

        }

        public IEnumerable<Genre.Genre> GetAll() 
        { 
            var genres = from genre in _genreRepository.GetAll()
                         select genre;
            return genres;
        }

        public IEnumerable<Genre.Genre> Find(string SearchTerm)
        {
            var genres = from genre in _genreRepository.Find(f => f.GenreName.Equals(SearchTerm))
                         select genre;
            return genres;
        }

        public void Add(Genre.Genre Genre) 
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

        public void AddRange(IEnumerable<Genre.Genre> genres)
        {
            try
            {
                foreach (var genre in genres)
                {
                    _genreRepository.Add(genre);
                }
                _genreRepository.Save();
            }
            catch (Exception)
            {
            }
        }

        public void Update(Genre.Genre Genre)
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

        public void Remove(Genre.Genre Genre)
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

        public void RemoveRange(IEnumerable<Genre.Genre> genres)
        {
            try
            {
                foreach (var genre in genres)
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
