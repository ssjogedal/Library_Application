using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using Library.Repositories;

namespace Library.Services
{
    class AuthorService : IService<Author>
    {
        AuthorRepository authorRepository;

        public event EventHandler Updated;

        /// <summary>
        /// Constructor takes in a RepositoryFactory enabling the service to create its own repositorys.
        /// </summary>
        /// <param name="rFactory"></param>
        public AuthorService(RepositoryFactory rFactory)
        {
            this.authorRepository = rFactory.CreateAuthorRepository();
        }

        /// <summary>
        /// Calls All method i AuthorRepository
        /// </summary>
        /// <returns>
        /// List of all auhtors
        /// </returns>
        public IEnumerable<Author> All()
        {
            return authorRepository.All();
        }


        /// <summary>
        /// Calls Add method in AuthorRepository
        /// Raises Updated event
        /// </summary>
        /// <param name="item"></param>
        public void Add(Author item)
        {
            authorRepository.Add(item);
            OnUpdated(EventArgs.Empty);
        }

        /// <summary>
        /// Calls Edit method in AuthorRepository
        /// Rases Updated Event
        /// </summary>
        /// <param name="a"></param>
        public void Edit(Author a)
        {
            authorRepository.Edit(a);
            OnUpdated(EventArgs.Empty);
        }

        /// <summary>
        /// Checking for subscribers before raising Updated Event
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnUpdated(EventArgs e)
        {
            if (Updated != null)
            {
                Updated(this, EventArgs.Empty);
            }
        }
    }
}
