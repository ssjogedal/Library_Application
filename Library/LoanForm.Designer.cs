namespace Library
{
    partial class LoanForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowAllBooks_button = new System.Windows.Forms.Button();
            this.ByAuthorButton = new System.Windows.Forms.Button();
            this.Author_listBox = new System.Windows.Forms.ListBox();
            this.Book_listBox = new System.Windows.Forms.ListBox();
            this.BookCopies_listBox = new System.Windows.Forms.ListBox();
            this.Member_listBox = new System.Windows.Forms.ListBox();
            this.AddLoanButton = new System.Windows.Forms.Button();
            this.Loan_listbox = new System.Windows.Forms.ListBox();
            this.Returned_listbox = new System.Windows.Forms.ListBox();
            this.Return_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Overdue_button = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ShowAllBooks_button);
            this.groupBox1.Controls.Add(this.ByAuthorButton);
            this.groupBox1.Controls.Add(this.Author_listBox);
            this.groupBox1.Controls.Add(this.Book_listBox);
            this.groupBox1.Location = new System.Drawing.Point(40, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 180);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restrict Book list by:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Authors";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Books";
            // 
            // ShowAllBooks_button
            // 
            this.ShowAllBooks_button.Location = new System.Drawing.Point(452, 109);
            this.ShowAllBooks_button.Name = "ShowAllBooks_button";
            this.ShowAllBooks_button.Size = new System.Drawing.Size(91, 50);
            this.ShowAllBooks_button.TabIndex = 14;
            this.ShowAllBooks_button.Text = "Show All Book";
            this.ShowAllBooks_button.UseVisualStyleBackColor = true;
            this.ShowAllBooks_button.Click += new System.EventHandler(this.ShowAllBooks_button_Click);
            // 
            // ByAuthorButton
            // 
            this.ByAuthorButton.Location = new System.Drawing.Point(452, 38);
            this.ByAuthorButton.Name = "ByAuthorButton";
            this.ByAuthorButton.Size = new System.Drawing.Size(91, 50);
            this.ByAuthorButton.TabIndex = 6;
            this.ByAuthorButton.Text = "Search by author";
            this.ByAuthorButton.UseVisualStyleBackColor = true;
            this.ByAuthorButton.Click += new System.EventHandler(this.ByAuthorButton_Click);
            // 
            // Author_listBox
            // 
            this.Author_listBox.FormattingEnabled = true;
            this.Author_listBox.Location = new System.Drawing.Point(249, 38);
            this.Author_listBox.Name = "Author_listBox";
            this.Author_listBox.Size = new System.Drawing.Size(197, 121);
            this.Author_listBox.TabIndex = 4;
            // 
            // Book_listBox
            // 
            this.Book_listBox.FormattingEnabled = true;
            this.Book_listBox.Location = new System.Drawing.Point(33, 38);
            this.Book_listBox.Name = "Book_listBox";
            this.Book_listBox.Size = new System.Drawing.Size(197, 121);
            this.Book_listBox.TabIndex = 7;
            // 
            // BookCopies_listBox
            // 
            this.BookCopies_listBox.FormattingEnabled = true;
            this.BookCopies_listBox.Location = new System.Drawing.Point(33, 52);
            this.BookCopies_listBox.Name = "BookCopies_listBox";
            this.BookCopies_listBox.Size = new System.Drawing.Size(197, 95);
            this.BookCopies_listBox.TabIndex = 8;
            // 
            // Member_listBox
            // 
            this.Member_listBox.FormattingEnabled = true;
            this.Member_listBox.Location = new System.Drawing.Point(249, 52);
            this.Member_listBox.Name = "Member_listBox";
            this.Member_listBox.Size = new System.Drawing.Size(197, 95);
            this.Member_listBox.TabIndex = 9;
            // 
            // AddLoanButton
            // 
            this.AddLoanButton.Location = new System.Drawing.Point(452, 107);
            this.AddLoanButton.Name = "AddLoanButton";
            this.AddLoanButton.Size = new System.Drawing.Size(91, 40);
            this.AddLoanButton.TabIndex = 10;
            this.AddLoanButton.Text = "Add Loan";
            this.AddLoanButton.UseVisualStyleBackColor = true;
            this.AddLoanButton.Click += new System.EventHandler(this.AddLoanButton_Click);
            // 
            // Loan_listbox
            // 
            this.Loan_listbox.FormattingEnabled = true;
            this.Loan_listbox.Location = new System.Drawing.Point(33, 178);
            this.Loan_listbox.Name = "Loan_listbox";
            this.Loan_listbox.Size = new System.Drawing.Size(413, 121);
            this.Loan_listbox.TabIndex = 11;
            // 
            // Returned_listbox
            // 
            this.Returned_listbox.FormattingEnabled = true;
            this.Returned_listbox.Location = new System.Drawing.Point(33, 332);
            this.Returned_listbox.Name = "Returned_listbox";
            this.Returned_listbox.Size = new System.Drawing.Size(413, 121);
            this.Returned_listbox.TabIndex = 12;
            // 
            // Return_button
            // 
            this.Return_button.Location = new System.Drawing.Point(452, 259);
            this.Return_button.Name = "Return_button";
            this.Return_button.Size = new System.Drawing.Size(91, 40);
            this.Return_button.TabIndex = 13;
            this.Return_button.Text = "Return Book";
            this.Return_button.UseVisualStyleBackColor = true;
            this.Return_button.Click += new System.EventHandler(this.Return_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(642, 664);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 14;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Member_listBox);
            this.groupBox2.Controls.Add(this.BookCopies_listBox);
            this.groupBox2.Controls.Add(this.Return_button);
            this.groupBox2.Controls.Add(this.AddLoanButton);
            this.groupBox2.Controls.Add(this.Returned_listbox);
            this.groupBox2.Controls.Add(this.Loan_listbox);
            this.groupBox2.Location = new System.Drawing.Point(40, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 480);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loan and Return";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Step 4 (On return)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Step 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Step 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Step 1";
            // 
            // Overdue_button
            // 
            this.Overdue_button.Location = new System.Drawing.Point(616, 396);
            this.Overdue_button.Name = "Overdue_button";
            this.Overdue_button.Size = new System.Drawing.Size(91, 49);
            this.Overdue_button.TabIndex = 16;
            this.Overdue_button.Text = "Test: Make Existing Loan Overdue";
            this.Overdue_button.UseVisualStyleBackColor = true;
            this.Overdue_button.Click += new System.EventHandler(this.Overdue_button_Click);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(616, 462);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(91, 40);
            this.button.TabIndex = 17;
            this.button.Text = "Test: Return Loan Overdue";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Loans";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Returns";
            // 
            // LoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 736);
            this.Controls.Add(this.button);
            this.Controls.Add(this.Overdue_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.groupBox1);
            this.Name = "LoanForm";
            this.Text = "LoanForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ByAuthorButton;
        private System.Windows.Forms.ListBox Author_listBox;
        private System.Windows.Forms.ListBox Book_listBox;
        private System.Windows.Forms.ListBox BookCopies_listBox;
        private System.Windows.Forms.ListBox Member_listBox;
        private System.Windows.Forms.Button AddLoanButton;
        private System.Windows.Forms.ListBox Loan_listbox;
        private System.Windows.Forms.ListBox Returned_listbox;
        private System.Windows.Forms.Button Return_button;
        private System.Windows.Forms.Button ShowAllBooks_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Overdue_button;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}