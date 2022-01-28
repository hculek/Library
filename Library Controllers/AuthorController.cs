using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Domain.dbInterfaces;
using Library_Domain.Author;
using Library_Persistence;
using Library_Persistence.Repositories;

namespace Library_Controllers
{
    public class AuthorController
    {
        private IAuthorRepository _authorRepository;

        public AuthorController() 
        { 
            this._authorRepository = new AuthorRepository(new ApplicationContext());

        }

        public IEnumerable<Author> GetAll()
        {
            try
            {
                var authors = from author in _authorRepository.GetAll()
                             select author;
                return authors;
            }
            catch (Exception)
            {
            }
            return null;
        }



        public IEnumerable<Author> Find(string SearchTerm)
        {
            try
            {
                //var authors = from author in _authorRepository.Find(f => (f.LastName.Trim() + " " + f.MiddleName.Trim() + " "+ f.LastName.Trim()).Trim().Equals(SearchTerm))
                //          select author;
                var authors = from author in _authorRepository.Find(f => (f.LastName + " " + f.MiddleName + " " + f.LastName).Equals(SearchTerm))
                              select author;

                return authors;
            }
            catch (Exception)
            {
            }
            return null;
        }

        public void Add(Author Author)
        {
            try
            {
                _authorRepository.Add(Author);
                _authorRepository.Save();
            }
            catch (Exception)
            {
                //"Unable to save changes. Try again, and if the problem persists see your system administrator."
            }

        }

        public void AddRange(IEnumerable<Author> Authors)
        {
            try
            {
                foreach (var author in Authors)
                {
                    _authorRepository.Add(author);
                }
                _authorRepository.Save();
            }
            catch (Exception)
            {
            }
        }

        public void Update(Author Author)
        {
            try
            {
                _authorRepository.Update(Author);
                _authorRepository.Save();
            }
            catch (Exception)
            {
            }
        }

        public void Remove(Author Author)
        {
            try
            {
                _authorRepository.Remove(Author);
                _authorRepository.Save();
            }
            catch (Exception)
            {
            }
        }

        public void RemoveRange(IEnumerable<Author> Authors)
        {
            try
            {
                foreach (var author in Authors)
                {
                    _authorRepository.Remove(author);
                }
                _authorRepository.Save();

            }
            catch (Exception)
            {
            }
        }
    }
}
