using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Repositories
{
    public class AuthorRepository : IRepository<Author, int>
    {
        LibraryContext context;

        /// <summary>
        /// Constructor takes in a LibraryContext, enabling the repository to create its own Librarycontext.
        /// </summary>
        /// <param name="c"></param>
        public AuthorRepository(LibraryContext c)
        {
            this.context = c;
        }

        /// <summary>
        /// Adds an author to context and save changes in context to db  
        /// </summary>
        /// <param name="item"></param>
        public void Add(Author item)
        {
            context.Authors.Add(item);
            context.SaveChanges();
        }

        /// <summary>
        /// Gets all authors from context
        /// </summary>
        /// <returns>
        /// Author table in db
        /// </returns>
        public IEnumerable<Author> All()
        {
            return context.Authors;
        }

        /// <summary>
        /// Save changes made in context to db
        /// </summary>
        /// <param name="a"></param>
        public void Edit(Author a)
        {
            context.SaveChanges();
        }

        public Author Find(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Author item)
        {
            throw new NotImplementedException();
        }
    }
}
