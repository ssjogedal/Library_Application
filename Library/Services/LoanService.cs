using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using Library.Repositories;

namespace Library.Services
{
    class LoanService : IService<Loan>
    {
        LoanRepository loanRepository;
        MemberRepository memberRepository;

        public event EventHandler Updated;

        /// <summary>
        /// Constructor takes in a RepositoryFactory enabling the service to create its own repositorys.
        /// </summary>
        /// <param name="rFactory"></param>
        public LoanService(RepositoryFactory rFactory)
        {
            this.loanRepository = rFactory.CreateLoanRepository();
            this.memberRepository = rFactory.CreateMemberRepository();
        }

        /// <summary>
        /// Calls All() method in LoanRepository
        /// </summary>
        /// <returns>
        /// List of all loans
        /// </returns>
        public IEnumerable<Loan> All()
        {
            return loanRepository.All();
        }

        /// <summary>
        /// Calls Add() method in Loanrepository
        /// Raises Updated event
        /// </summary>
        /// <param name="item"></param>
        public void Add(Loan item)
        {
            loanRepository.Add(item);
            OnUpdated(EventArgs.Empty);
        }

        /// <summary>
        /// Calls Edit method in Loanreository
        /// Raises updated event
        /// </summary>
        /// <param name="item"></param>
        public void Edit(Loan item)
        {
            loanRepository.Edit(item);
            OnUpdated(EventArgs.Empty);
        }

        /// <summary>
        /// Gets all returned loans  
        /// </summary>
        /// <returns>
        /// Returned loans
        /// </returns>
        public IEnumerable<Loan> Returns()
        {
            return from l in loanRepository.All()
                   where l.Returned == true
                   select l;
        }

        /// <summary>
        /// Retuns a loan by setting a Time of return, change OnLoan to false and Retuned to True
        /// Calculates eventual fine and adds it to a members total fine
        /// Raises Updated event.
        /// </summary>
        /// <param name="loan"></param>
        public void ReturnBook(Loan loan)
        {
            if (loan != null)
            {
                loan.TimeOfReturn = DateTime.Now;
                loan.BookCopy.OnLoan = false;
                

                loan.Returned = true;
                loanRepository.Edit(loan);

                if (loan.TimeOfReturn > loan.DueDate)
                {
                    int fineDays = ((DateTime)loan.TimeOfReturn - loan.DueDate).Days;
                    loan.Member.Fine += fineDays * 10;

                    memberRepository.Edit(loan.Member);
                }

                OnUpdated(EventArgs.Empty);
            }
        }

        /// <summary>
        /// Gets all loans wich has not yet been returned
        /// </summary>
        /// <returns>
        /// List of loans
        /// </returns>
        public IEnumerable<Loan> AllCurrentLoans()
        {
            return from l in loanRepository.All()
                   where l.Returned == false
                   select l;
        }

        /// <summary>
        /// Checking for subscribers before raising Updated event
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
