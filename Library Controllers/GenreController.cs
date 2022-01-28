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

        public IEnumerable<Genre.Genre> Find()
        {
            var genres = from genre in _genreRepository.Find(f => f.GenreName.Equals(string searchTerm))
                         select genre;
            return genres;
        }

        public void Create(Genre.Genre Genre) 
        { 
        
        }

        //https://www.c-sharpcorner.com/UploadFile/3d39b4/crud-using-the-repository-pattern-in-mvc/

    }
}
