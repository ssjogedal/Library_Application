using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Library.Models;
using Library.Services;


namespace Library.Repositories
{
    public class LoanRepository : IRepository<Loan, int>
    {
        LibraryContext context;

        /// <summary>
        /// Constructor takes in a LibraryContext, enabling the repository to create its own Librarycontext.
        /// </summary>
        /// <param name="c"></param>
        public LoanRepository(LibraryContext c)
        {
            this.context = c;
        }

        /// <summary>
        /// Adds a loan to context and save changes in context to db 
        /// </summary>
        /// <param name="item"></param>
        public void Add(Loan item)
        {
            context.Loans.Add(item);
            context.SaveChanges();
        }

        /// <summary>
        /// Gets all loans from context
        /// </summary>
        /// <returns>
        /// Loan table from db
        /// </returns>
        public IEnumerable<Loan> All()
        {
            return context.Loans;
        }

        /// <summary>
        /// Save changes made in context to db
        /// </summary>
        /// <param name="item"></param>
        public void Edit(Loan item)
        {
            context.SaveChanges();
        }

        public Loan Find(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Loan item)
        {
            throw new NotImplementedException();
        }
    }
}
