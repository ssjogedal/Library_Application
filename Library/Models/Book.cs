using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Book {

        [Key]
        public int BookId { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }

        [ForeignKey ("Author")]
        public virtual int AuthorId { get; set; }
        [Required]
        public virtual Author Author { get; set; }
       
        public virtual ICollection<BookCopy> bookCopy { get; set; }

        public Book() { }

        public Book(string _isbn, string _title, string _description, Author _author, int numberOfCopies)
        {
            bookCopy = new List<BookCopy>();

            this.ISBN = _isbn;
            this.Title = _title;
            this.Description = _description;
            this.Author = _author;
            this.bookCopy = bookCopy;
   
            _author.Books.Add(this);  
            addBookCopy(numberOfCopies); 
        }

        /// <summary>
        /// Creating and adding BookCopys to the books bookCopy list
        /// </summary>
        /// <param name="number"></param>
        public void addBookCopy(int number) 
        {
            for (int i = 0; i < number; i++)
            {
                BookCopy copy = new BookCopy(this); 
                bookCopy.Add(copy);
                
            }

        }
        
        public override string ToString()
        {
            return Title;
        }
    }
}