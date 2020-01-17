using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    public class BookCopyRepository : IRepository<BookCopy, int>
    {
        LibraryContext context;

        /// <summary>
        /// Constructor takes in a LibraryContext, enabling the repository to create its own Librarycontext.
        /// </summary>
        /// <param name="c"></param>
        public BookCopyRepository(LibraryContext c)
        {
            this.context = c;
        }

        /// <summary>
        /// Adds a bookcopy to context and save changes in context to db  
        /// </summary>
        /// <param name="item"></param>
        public void Add(BookCopy item)
        {
            context.BookCopys.Add(item);
            context.SaveChanges();
        }

        /// <summary>
        /// Gets all bookcopies from context
        /// </summary>
        /// <returns>
        /// Bookcopy table in db
        /// </returns>
        public IEnumerable<BookCopy> All()
        {
            return context.BookCopys;
        }

        /// <summary>
        /// Save changes made in context to db
        /// </summary>
        /// <param name="item"></param>
        public void Edit(BookCopy item)
        {
            context.SaveChanges();
        }

        public BookCopy Find(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(BookCopy item)
        {
            throw new NotImplementedException();
        }


    }
}
