using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Library.Models;


namespace Library.Repositories
{
    public class MemberRepository : IRepository<Member, int>
    {
        LibraryContext context;

        /// <summary>
        /// Constructor takes in a LibraryContext, enabling the repository to create its own Librarycontext.
        /// </summary>
        /// <param name="c"></param>
        public MemberRepository(LibraryContext c)
        {
            this.context = c;
        }

        /// <summary>
        /// Gets all members from context
        /// </summary>
        /// <returns>
        /// Members table from db
        /// </returns>
        public IEnumerable<Member> All()
        {
            return context.Members;
        }

        /// <summary>
        /// Save changes made in context to db
        /// </summary>
        /// <param name="m"></param>
        public void Edit(Member m)
        {
            context.SaveChanges();
        }

        /// <summary>
        /// Adds a member to context and save changes in context to db
        /// </summary>
        /// <param name="m"></param>
        public void Add(Member m)
        {
            context.Members.Add(m);
            context.SaveChanges();
        }

        public void Remove(Member item)
        {
            throw new NotImplementedException();
        }

        public Member Find(int id)
        {
            throw new NotImplementedException();
        }
    }
}
