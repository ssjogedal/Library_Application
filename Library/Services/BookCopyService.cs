using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using Library.Repositories;

namespace Library.Services
{
    class BookCopyService : IService<BookCopy>
    {
        public event EventHandler Updated;

        BookCopyRepository bookCopyRepository;

        /// <summary>
        /// Constructor takes in a RepositoryFactory enabling the service to create its own repositorys.
        /// </summary>
        /// <param name="rFactory"></param>
        public BookCopyService(RepositoryFactory rFactory)
        {
            this.bookCopyRepository = rFactory.CreateBookCopyRepository();
        }

        /// <summary>
        /// Calls Add method in BooCopyRepository.
        /// Raises Updated event.
        /// </summary>
        /// <param name="item"></param>
        public void Add(BookCopy item)
        {
            bookCopyRepository.Add(item);
        }

        /// <summary>
        /// Takes in a Book and a number.
        /// Creates this number of BookCopies.
        /// Calls Add method.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="number"></param>
        public void AddCopies(Book item, int number)
        {
            for (int i = 0; i < number; i++)
            {
                BookCopy bookCopy = new BookCopy(item);
                Add(bookCopy);               
            }
        }

        /// <summary>
        /// Calls All() method in BookCopyRepository:
        /// </summary>
        /// <returns>
        /// List of all bookcopies
        /// </returns>
        public IEnumerable<BookCopy> All()
        {
            return bookCopyRepository.All();
        }

        /// <summary>
        /// Filters bookcopies by author name and the bookcopys availability.
        /// </summary>
        /// <param name="author"></param>
        /// <returns>
        /// Bookcopies from the selected author that are not currently on loan
        /// </returns>
        public IEnumerable<BookCopy> BooksByAuthor(Author author)
        {
            return from b in bookCopyRepository.All()
                   where b.Book.Author.Name == author.Name && b.OnLoan == false
                   select b;

        }

        /// <summary>
        /// Calls Edit method in BooCopyRepository
        /// Raises Updated event
        /// </summary>
        /// <param name="item"></param>
        public void Edit(BookCopy item)
        {
            bookCopyRepository.Edit(item);
            OnUpdated(EventArgs.Empty);
        }

        /// <summary>
        /// Filter bookcopys by availability
        /// </summary>
        /// <returns>
        /// Bookcopies that are currently not on loan
        /// </returns>
        public IEnumerable<BookCopy> AllAvailableCopies()
        {
            return from b in bookCopyRepository.All()
                where b.OnLoan == false
                select b;
        }

        /// <summary>
        /// Checking for subscribers before raising Updated event.
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