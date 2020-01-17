using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Models;
using Library.Repositories;
using Library.Services;
using System.Runtime.Remoting.Contexts;

namespace Library
{
    public partial class BookAndAuthorForm : Form
    {
        BookService bookService;
        AuthorService authorService;
        LibraryForm libraryForm;
        

        public BookAndAuthorForm(LibraryForm libraryForm)
        {
            InitializeComponent();

            LibraryContext context = new LibraryContext();
        
            RepositoryFactory repFactory = new RepositoryFactory(context);

            
            this.bookService = new BookService(repFactory);
            this.authorService = new AuthorService(repFactory);
            this.libraryForm = libraryForm;

            ShowAllAuthors(authorService.All());
            ShowAllBooks(bookService.All());

            authorService.Updated += Service_Updated;
            bookService.Updated += Service_Updated;
        }

        private void Service_Updated(object sender, EventArgs e)
        {
            ShowAllAuthors(authorService.All());
            ShowAllBooks(bookService.All());
        }

        private void ShowAllAuthors(IEnumerable<Author> authors)
        {
            Author_listBox.Items.Clear();
            foreach (Author author in authors)
            {
                Author_listBox.Items.Add(author);
            }
        }

        private void ShowAllBooks(IEnumerable<Book> books)
        {
            Book_listBox.Items.Clear();
            foreach (Book book in books)
            {
                Book_listBox.Items.Add(book);
            }
        }

        private void AddAuthor_button_Click(object sender, EventArgs e)
        {
            string authorName = AuthorName_textBox.Text;

            if (!string.IsNullOrEmpty(authorName))
            {
                Author author = new Author(authorName);
                authorService.Add(author);

                MessageBox.Show(authorName + " was succesfully added");
            }
            else
            {
                MessageBox.Show("Invalid Input - An author must have a name");
            }

           
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            Author selectedAuthor = Author_listBox.SelectedItem as Author;

            int copies;
            string selectedCopies = numberOfCopies_textBox.Text;
            bool isSelectedCopies = int.TryParse(selectedCopies, out copies);

            string isbn = ISBN_textBox.Text;
            string title = Title_textBox.Text;
            string description = Description_richTextBox.Text;

            if (isSelectedCopies == true && !string.IsNullOrEmpty(isbn) && !string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(description) && selectedAuthor != null)
            {
                Book book = new Book(isbn, title, description, selectedAuthor, copies);
                bookService.Add(book);

                MessageBox.Show(title + " was succesfully added too library");
            }
            else
            {
                MessageBox.Show("Invalid input");
            }

        }

        private void StartPage_button_Click(object sender, EventArgs e)
        {
            this.Close();
            libraryForm.Show();
        }
    }
}
