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

namespace Library
{
    public partial class MemberForm : Form
    {
        MemberService memberService;
        LibraryForm libraryForm;

        public MemberForm(LibraryForm libraryForm)
        {
            InitializeComponent();

            LibraryContext context = new LibraryContext();

            RepositoryFactory repFactory = new RepositoryFactory(context);

            this.memberService = new MemberService(repFactory);
            this.libraryForm = libraryForm;

            ShowAllMembers(memberService.All());

            memberService.Updated += MemberService_Updated;
        }

        private void MemberService_Updated(object sender, EventArgs e)
        {
            ShowAllMembers(memberService.All());
        }

        private void ShowAllMembers(IEnumerable<Member> members)
        {
            Member_listBox.Items.Clear();
            foreach (Member member in members)
            {
                Member_listBox.Items.Add(member);
            }
        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            string pNumber = pNumberTextBox.Text;
            int convertedPNumber;

            bool isPNumber = int.TryParse(pNumber, out convertedPNumber);

            if (isPNumber == true && !string.IsNullOrEmpty(NameTextBox.Text))
            {
                Member member = new Member(convertedPNumber, NameTextBox.Text);
                memberService.Add(member);
            }
            else
            {
                MessageBox.Show("Invalid input");
            }

            
            
            
        }

        private void SelectMemberButton_Click(object sender, EventArgs e)
        {
            Member member = Member_listBox.SelectedItem as Member;

            if (member != null)
            {
                memberIdTextbox.Text = Convert.ToString(member.MemberId);
                ScnOutTextBox.Text = Convert.ToString(member.PersonalId);
                NameOutTextBox.Text = member.Name;
                FineTextBox.Text = Convert.ToString(member.Fine);

                foreach (Loan loan in member.Loans)
                {
                        Loans_listBox.Items.Add(loan.BookCopy.Book.Title);
                   
                }
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
            libraryForm.Show();
        }
    }
}
