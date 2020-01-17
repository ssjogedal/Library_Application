using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    public class BookRepository : IRepository<Book, int>
    {
        LibraryContext context;

        /// <summary>
        /// Constructor takes in a LibraryContext, enabling the repository to create its own Librarycontext.
        /// </summary>
        /// <param name="c"></param>
        public BookRepository(LibraryContext c)
        {
            this.context = c;
        }

        /// <summary>
        /// Adds a book to context and save changes in context to db  
        /// </summary>
        /// <param name="item"></param>
        public void Add(Book item)
        {
            context.Books.Add(item);
            context.SaveChanges();
        }

        /// <summary>
        /// Gets all books from context
        /// </summary>
        /// <returns>
        /// Book table from db
        /// </returns>
        public IEnumerable<Book> All()
        {
            return context.Books;
        }

        /// <summary>
        /// Save changes made in context to db
        /// </summary>
        /// <param name="b"></param>
        public void Edit(Book b)
        {   
            context.SaveChanges();
        }

        public Book Find(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Book item)
        {
            throw new NotImplementedException();
        }
    }
}