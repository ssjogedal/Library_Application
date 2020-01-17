using Library.Models;
using Library.Repositories;
using Library.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class LoanForm : Form
    {
        BookService bookService;
        AuthorService authorService;
        MemberService memberService;
        BookCopyService bookCopyService;
        LoanService loanService;
        LibraryForm libraryForm;

        public LoanForm(LibraryForm libraryForm)
        {
            InitializeComponent();

            LibraryContext context = new LibraryContext();

            RepositoryFactory repFactory = new RepositoryFactory(context);

            this.bookService = new BookService(repFactory);
            this.authorService = new AuthorService(repFactory);
            this.memberService = new MemberService(repFactory);
            this.bookCopyService = new BookCopyService(repFactory);
            this.loanService = new LoanService(repFactory);
            this.libraryForm = libraryForm;

            ShowAllBooks(bookService.All());
            ShowAllBookCopies(bookCopyService.AllAvailableCopies());
            ShowAllMembers(memberService.All());
            ShowAllAuthors(authorService.All());
            ShowAllLoans(loanService.AllCurrentLoans());
            ShowAllReturns(loanService.Returns());

            loanService.Updated += LoanService_Updated;
           
        }

        private void LoanService_Updated(object sender, EventArgs e)
        {
            ShowAllLoans(loanService.AllCurrentLoans());
            ShowAllBookCopies(bookCopyService.AllAvailableCopies());
            ShowAllReturns(loanService.Returns());

        }

        private void ShowAllBooks(IEnumerable<Book> books)
        {
            Book_listBox.Items.Clear();
            foreach (Book book in books)
            {
                Book_listBox.Items.Add(book);
            }
        }

        private void ShowAllBookCopies(IEnumerable<BookCopy> bookcopies)
        {
            BookCopies_listBox.Items.Clear();
            foreach (BookCopy bookcopy in bookcopies)
            {
                BookCopies_listBox.Items.Add(bookcopy);
            }
        }

        private void ShowAllMembers(IEnumerable<Member> members)
        {
            Member_listBox.Items.Clear();
            foreach (Member member in members)
            {
                Member_listBox.Items.Add(member);
            }
        }


        private void ShowAllAuthors(IEnumerable<Author> authors)
        {
            Author_listBox.Items.Clear();
            foreach (Author author in authors)
            {
                Author_listBox.Items.Add(author);
            }
        }

        private void ShowAllLoans(IEnumerable<Loan> loans)
        {
            Loan_listbox.Items.Clear();
            foreach (Loan loan in loans)
            {
                Loan_listbox.Items.Add(loan);
            }
        }

        private void ShowAllReturns(IEnumerable<Loan> loans)
        {
            Returned_listbox.Items.Clear();
            foreach (Loan loan in loans)
            {
                Returned_listbox.Items.Add(loan);
            }
        }



        private void AddLoanButton_Click(object sender, EventArgs e)
        {
            var bookCopy = BookCopies_listBox.SelectedItem;
            var member = Member_listBox.SelectedItem;

            if (bookCopy != null && member != null)
            {
                BookCopy _bookCopy = bookCopy as BookCopy;
                Member _member = member as Member;

                Loan loan = new Loan(_bookCopy, _member);

                _bookCopy.OnLoan = true;
                loanService.Add(loan);
                
            }
        }

        private void Return_button_Click(object sender, EventArgs e)
        {

            Loan loan = Loan_listbox.SelectedItem as Loan;

            loanService.ReturnBook(loan);

        }

        private void ByAuthorButton_Click(object sender, EventArgs e)
        {
            Author author = Author_listBox.SelectedItem as Author;

            ShowAllBooks(bookService.BooksByAuthor(author));
            ShowAllBookCopies(bookCopyService.BooksByAuthor(author));
        }

        private void ShowAllBooks_button_Click(object sender, EventArgs e)
        {
            ShowAllBooks(bookService.All());
            ShowAllBookCopies(bookCopyService.AllAvailableCopies());
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
            libraryForm.Show();
        }

        private void Overdue_button_Click(object sender, EventArgs e)
        {
            Loan loan = Loan_listbox.SelectedItem as Loan;

            loan.DueDate = loan.TimeOfLoan.AddDays(-15);

            ShowAllLoans(loanService.AllCurrentLoans());
        }

        private void button_Click(object sender, EventArgs e)
        {
            Loan loan = Loan_listbox.SelectedItem as Loan;
            loanService.ReturnBook(loan);

        }
    }
}