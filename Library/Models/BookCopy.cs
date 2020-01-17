using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class BookCopy
    {

        [Key]
        public int BookCopyId { get; set; }
        [ForeignKey ("Book")]
        public virtual int BookId { get; set; }
        [Required]
        public virtual Book Book { get; set; }
        public bool OnLoan { get; set; }

        public BookCopy() { }

        public BookCopy(Book _book)
        {
            OnLoan = false;
            this.Book = _book;
        }

        public override string ToString()
        {
            return this.Book.Title;
        }
    }
}

