using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    class BookService : IService<Book>
    {
        
        BookRepository bookRepository;

        public event EventHandler Updated;


        /// <summary>
        /// Constructor takes in a RepositoryFactory enabling the service to create its own repositorys.
        /// </summary>
        /// <param name="rFactory"></param>
        public BookService(RepositoryFactory rFactory)
        {
            this.bookRepository = rFactory.CreateBookRepository();
        }

        /// <summary>
        /// Calls Add method in BookRepository
        /// Raises Updated event
        /// </summary>
        /// <param name="item"></param>
        public void Add(Book item)
        {
            bookRepository.Add(item);
            OnUpdated(EventArgs.Empty);

        }

        /// <summary>
        /// Calls All() method in BookRepository
        /// </summary>
        /// <returns>
        /// Returns list of all books
        /// </returns>
        public IEnumerable<Book> All()
        {
            return bookRepository.All();
        }

        /// <summary>
        /// Filters books by authors name
        /// </summary>
        /// <param name="author"></param>
        /// <returns>
        /// Returns books with authors name equal to the selected authors name.
        /// </returns>
        public IEnumerable<Book> BooksByAuthor(Author author)
        {
            return from b in bookRepository.All()
            where b.Author.Name == author.Name
            select b;

        }

        /// <summary>
        /// The Edit method makes sure that the given Book object is saved to the database and raises the Updated() event.
        /// </summary>
        /// <param name="b"></param>
        public void Edit(Book b)
        {
            bookRepository.Edit(b);
            OnUpdated(EventArgs.Empty);

        }

        /// <summary>
        /// Checks for subcribers before raising the Updated event.
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
