using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class Author
    {

        [Key]
        public int AuthorId { get; set; }
        [Required]
        public string Name { get; set; }
 
        public virtual ICollection<Book> Books { get; set; }

        public Author() { }

        public Author(string _name)
        {
            Books = new List<Book>();

            this.Name = _name;
            this.Books = Books;
            
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
