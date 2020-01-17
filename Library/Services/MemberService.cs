using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using Library.Repositories;

namespace Library.Services
{
    class MemberService : IService<Member>
    {
        MemberRepository memberRepository;

        public event EventHandler Updated;

        /// <summary>
        /// Constructor takes in a RepositoryFactory enabling the service to create its own repositorys.
        /// </summary>
        /// <param name="rFactory"></param>
        public MemberService(RepositoryFactory rFactory)
        {
            this.memberRepository = rFactory.CreateMemberRepository();
        }

        /// <summary>
        /// Calls All() method in MemberRepository
        /// </summary>
        /// <returns>
        /// List of all members
        /// </returns>
        public IEnumerable<Member> All()
        {
            return memberRepository.All();
        }

        /// <summary>
        /// Calls Edit method in MemberRepository
        /// Raises Updated event
        /// </summary>
        /// <param name="m"></param>
        public void Edit(Member m)
        {
            memberRepository.Edit(m);
            OnUpdated(EventArgs.Empty);
        }

        /// <summary>
        /// Calls Add method in MemberRepository
        /// Raises Updated Event
        /// </summary>
        /// <param name="m"></param>
        public void Add(Member m)
        {
            memberRepository.Add(m);
            OnUpdated(EventArgs.Empty);
        }

        /// <summary>
        /// Checks for subscribers before raising Updated event
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
