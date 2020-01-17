namespace Library
{
    partial class BookAndAuthorForm
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
            this.AddBookButton = new System.Windows.Forms.Button();
            this.ISBN_textBox = new System.Windows.Forms.TextBox();
            this.Title_textBox = new System.Windows.Forms.TextBox();
            this.Description_richTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Author_listBox = new System.Windows.Forms.ListBox();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.AddAuthor_button = new System.Windows.Forms.Button();
            this.AuthorName_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numberOfCopies_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.StartPage_button = new System.Windows.Forms.Button();
            this.Book_listBox = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddBookButton
            // 
            this.AddBookButton.Location = new System.Drawing.Point(9, 58);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(101, 34);
            this.AddBookButton.TabIndex = 0;
            this.AddBookButton.Text = "Add New Book";
            this.AddBookButton.UseVisualStyleBackColor = true;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // ISBN_textBox
            // 
            this.ISBN_textBox.Location = new System.Drawing.Point(9, 69);
            this.ISBN_textBox.Name = "ISBN_textBox";
            this.ISBN_textBox.Size = new System.Drawing.Size(196, 20);
            this.ISBN_textBox.TabIndex = 1;
            // 
            // Title_textBox
            // 
            this.Title_textBox.Location = new System.Drawing.Point(9, 115);
            this.Title_textBox.Name = "Title_textBox";
            this.Title_textBox.Size = new System.Drawing.Size(196, 20);
            this.Title_textBox.TabIndex = 2;
            // 
            // Description_richTextBox
            // 
            this.Description_richTextBox.Location = new System.Drawing.Point(9, 165);
            this.Description_richTextBox.Name = "Description_richTextBox";
            this.Description_richTextBox.Size = new System.Drawing.Size(196, 68);
            this.Description_richTextBox.TabIndex = 3;
            this.Description_richTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description";
            // 
            // Author_listBox
            // 
            this.Author_listBox.FormattingEnabled = true;
            this.Author_listBox.Location = new System.Drawing.Point(6, 138);
            this.Author_listBox.Name = "Author_listBox";
            this.Author_listBox.Size = new System.Drawing.Size(213, 186);
            this.Author_listBox.TabIndex = 7;
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(6, 122);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(43, 13);
            this.AuthorLabel.TabIndex = 8;
            this.AuthorLabel.Text = "Authors";
            // 
            // AddAuthor_button
            // 
            this.AddAuthor_button.Location = new System.Drawing.Point(14, 385);
            this.AddAuthor_button.Name = "AddAuthor_button";
            this.AddAuthor_button.Size = new System.Drawing.Size(75, 23);
            this.AddAuthor_button.TabIndex = 9;
            this.AddAuthor_button.Text = "Add Author";
            this.AddAuthor_button.UseVisualStyleBackColor = true;
            this.AddAuthor_button.Click += new System.EventHandler(this.AddAuthor_button_Click);
            // 
            // AuthorName_textBox
            // 
            this.AuthorName_textBox.Location = new System.Drawing.Point(14, 359);
            this.AuthorName_textBox.Name = "AuthorName_textBox";
            this.AuthorName_textBox.Size = new System.Drawing.Size(100, 20);
            this.AuthorName_textBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Author Name";
            // 
            // numberOfCopies_textBox
            // 
            this.numberOfCopies_textBox.Location = new System.Drawing.Point(9, 264);
            this.numberOfCopies_textBox.Name = "numberOfCopies_textBox";
            this.numberOfCopies_textBox.Size = new System.Drawing.Size(100, 20);
            this.numberOfCopies_textBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Number Of Copies";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Author_listBox);
            this.groupBox1.Controls.Add(this.AddAuthor_button);
            this.groupBox1.Controls.Add(this.AuthorName_textBox);
            this.groupBox1.Controls.Add(this.AuthorLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 421);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step One";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Add new author then select from list";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Or";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Select existing author from list";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.ISBN_textBox);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numberOfCopies_textBox);
            this.groupBox2.Controls.Add(this.Title_textBox);
            this.groupBox2.Controls.Add(this.Description_richTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(286, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 421);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step two";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Fill out the requested information";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.AddBookButton);
            this.groupBox3.Location = new System.Drawing.Point(22, 308);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Step three";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Click to add new book to Library";
            // 
            // StartPage_button
            // 
            this.StartPage_button.Location = new System.Drawing.Point(167, 385);
            this.StartPage_button.Name = "StartPage_button";
            this.StartPage_button.Size = new System.Drawing.Size(75, 23);
            this.StartPage_button.TabIndex = 17;
            this.StartPage_button.Text = "Back";
            this.StartPage_button.UseVisualStyleBackColor = true;
            this.StartPage_button.Click += new System.EventHandler(this.StartPage_button_Click);
            // 
            // Book_listBox
            // 
            this.Book_listBox.FormattingEnabled = true;
            this.Book_listBox.Location = new System.Drawing.Point(17, 65);
            this.Book_listBox.Name = "Book_listBox";
            this.Book_listBox.Size = new System.Drawing.Size(213, 290);
            this.Book_listBox.TabIndex = 18;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.Book_listBox);
            this.groupBox4.Controls.Add(this.StartPage_button);
            this.groupBox4.Location = new System.Drawing.Point(548, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(248, 421);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Library";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Books";
            // 
            // BookAndAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BookAndAuthorForm";
            this.Text = "BookAndAuthorForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.TextBox ISBN_textBox;
        private System.Windows.Forms.TextBox Title_textBox;
        private System.Windows.Forms.RichTextBox Description_richTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Author_listBox;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Button AddAuthor_button;
        private System.Windows.Forms.TextBox AuthorName_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numberOfCopies_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button StartPage_button;
        private System.Windows.Forms.ListBox Book_listBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
    }
}