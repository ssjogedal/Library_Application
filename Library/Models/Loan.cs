using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Loan
    {   [Key]
        public int LoanId { get; set; }
        [Required]
        public DateTime TimeOfLoan { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        public DateTime? TimeOfReturn { get; set; }
        [Required]
        public virtual BookCopy BookCopy { get; set; }
        
        public virtual Member Member { get; set; }

        public bool Returned { get; set; }

        public Loan() { }

        public Loan(BookCopy _bookCopy, Member _member)
        {
            this.TimeOfLoan = DateTime.Now;
            this.DueDate = TimeOfLoan.AddDays(15);
            
            this.BookCopy = _bookCopy;
            this.Member = _member;

            this.Returned = false;
            
        }

        /// <summary>
        /// Checks if loan is overdue and changes state before adding to listbox
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string state;

            if(DueDate < DateTime.Now)
            {
                state = "Overdue";
            }
            else
            {
                state = "Not Overdue";
            }

            return "Member: " + Member.Name + ", Book: " + BookCopy.Book.Title + TimeOfLoan + " " + state;
        }

    }
}
