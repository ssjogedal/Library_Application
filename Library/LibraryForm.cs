using Library.Models;
using Library.Repositories;
using Library.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;
    
namespace Library
{
    public partial class LibraryForm : Form
    {
        BookService bookService;
        AuthorService authorService;
        MemberService memberService;
        BookCopyService bookCopyService;
        LoanService loanService;
        
        public LibraryForm()
        {
            InitializeComponent();

            // we create only one context in our application, which gets shared among repositories
            LibraryContext context = new LibraryContext();
            // we use a factory object that will create the repositories as they are needed, it also makes
            // sure all the repositories created use the same context.
            RepositoryFactory repFactory = new RepositoryFactory(context);

            this.bookService = new BookService(repFactory);
            this.authorService = new AuthorService(repFactory);
            this.memberService = new MemberService(repFactory);
            this.bookCopyService = new BookCopyService(repFactory);
            this.loanService = new LoanService(repFactory);

            ShowAllBooks(bookService.All());

            bookService.Updated += BookService_Updated;
            
        }

        private void BookService_Updated(object sender, EventArgs e)
        {
            ShowAllBooks(bookService.All());

        }

        // System.InvalidOperationException: 'The ForeignKeyAttribute on property 'books' on type 
        // 'Library.Models.Author' is not valid. The foreign key name 'BookList' was not found on the
        // dependent type 'Library.Models.Book'. The Name value should be a comma separated list of
        // foreign key property names.'



        private void ShowAllBooks(IEnumerable<Book> books)
        {
            lbBooks.Items.Clear();
            foreach (Book book in books)
            {
                lbBooks.Items.Add(book);
            }
        }


        private void AddCopies_Button_Click(object sender, EventArgs e)
        {
            Book book = lbBooks.SelectedItem as Book;
            string copies = AddCopies_textBox.Text;
            int number;

            bool isNumber = int.TryParse(copies, out number);

            if (isNumber == true)
            {
                bookCopyService.AddCopies(book, number);
                MessageBox.Show("Copies added:"  + number);
            }
            else
            {
                MessageBox.Show("Input must be a number");
            }

        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            BookAndAuthorForm bookAndAuthor = new BookAndAuthorForm(this);
            bookAndAuthor.Show();
            this.Hide();
        }

        private void AddLoanButton_Click(object sender, EventArgs e)
        {
            LoanForm loanForm = new LoanForm(this);
            loanForm.Show();
            this.Hide();
        }

        private void MemberButton_Click(object sender, EventArgs e)
        {
            MemberForm memberForm = new MemberForm(this);
            memberForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowAllBooks(bookService.All());
        }
    }
}
