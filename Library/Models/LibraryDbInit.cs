using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models {
    /// <summary>
    /// Database strategy is chosen as the base class to LibraryDbInit.
    /// Here in the Seed method you can create the default objects you want in the database.
    /// </summary>
    class LibraryDbInit : DropCreateDatabaseAlways<LibraryContext> {
        protected override void Seed(LibraryContext context) {
            base.Seed(context);

            LibraryContext db = new LibraryContext();

            Author Author1 = new Author("J.K Rowling");
            Author author2 = new Author("Fjodor Dostojevskij");
            Author author3 = new Author("John Steinbeck");

   
            Book hp1 = new Book("123", "Harry Potter 1", "Fantasy", Author1, 5);
            Book bos = new Book("3456", "Brott & Straff", "Roman", author2, 2);
            Book omom = new Book("1337", "Of Mice & Men", "Roman", author3, 3);
            Book hp2 = new Book("14g5", "Harry Potter 2", "Fantasy", author2, 2);

            Member simoonSjogedal = new Member(19911028, "Simon Sjogedal");

            

            // Add the book to the DbSet of books.
            db.Authors.Add(Author1);
            db.Authors.Add(author2);
            db.Authors.Add(author3);
            db.Books.Add(hp1);
            db.Books.Add(bos);
            db.Books.Add(omom);
            db.Books.Add(hp2);
            db.Members.Add(simoonSjogedal);

            // Persist changes to the database
            db.SaveChanges();
        }
    }
}
