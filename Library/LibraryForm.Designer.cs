namespace Library {
    partial class LibraryForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbBooks = new System.Windows.Forms.ListBox();
            this.AddCopies_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AddLoanButton = new System.Windows.Forms.Button();
            this.MemberButton = new System.Windows.Forms.Button();
            this.AddCopies_textBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.Location = new System.Drawing.Point(40, 19);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(244, 108);
            this.lbBooks.TabIndex = 0;
            // 
            // AddCopies_Button
            // 
            this.AddCopies_Button.Location = new System.Drawing.Point(306, 92);
            this.AddCopies_Button.Margin = new System.Windows.Forms.Padding(2);
            this.AddCopies_Button.Name = "AddCopies_Button";
            this.AddCopies_Button.Size = new System.Drawing.Size(75, 35);
            this.AddCopies_Button.TabIndex = 1;
            this.AddCopies_Button.Text = "Add New Book Copies";
            this.AddCopies_Button.UseVisualStyleBackColor = true;
            this.AddCopies_Button.Click += new System.EventHandler(this.AddCopies_Button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 79);
            this.button1.TabIndex = 2;
            this.button1.Text = "Authors and Books";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddLoanButton
            // 
            this.AddLoanButton.Location = new System.Drawing.Point(172, 29);
            this.AddLoanButton.Name = "AddLoanButton";
            this.AddLoanButton.Size = new System.Drawing.Size(112, 79);
            this.AddLoanButton.TabIndex = 3;
            this.AddLoanButton.Text = "Loans";
            this.AddLoanButton.UseVisualStyleBackColor = true;
            this.AddLoanButton.Click += new System.EventHandler(this.AddLoanButton_Click);
            // 
            // MemberButton
            // 
            this.MemberButton.Location = new System.Drawing.Point(306, 29);
            this.MemberButton.Name = "MemberButton";
            this.MemberButton.Size = new System.Drawing.Size(112, 79);
            this.MemberButton.TabIndex = 4;
            this.MemberButton.Text = "Members";
            this.MemberButton.UseVisualStyleBackColor = true;
            this.MemberButton.Click += new System.EventHandler(this.MemberButton_Click);
            // 
            // AddCopies_textBox
            // 
            this.AddCopies_textBox.Location = new System.Drawing.Point(306, 67);
            this.AddCopies_textBox.Name = "AddCopies_textBox";
            this.AddCopies_textBox.Size = new System.Drawing.Size(37, 20);
            this.AddCopies_textBox.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Refresh Book List";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbBooks);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.AddCopies_Button);
            this.groupBox1.Controls.Add(this.AddCopies_textBox);
            this.groupBox1.Location = new System.Drawing.Point(31, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 173);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AddLoanButton);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.MemberButton);
            this.groupBox2.Location = new System.Drawing.Point(31, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 129);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25F);
            this.label1.Location = new System.Drawing.Point(106, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 41);
            this.label1.TabIndex = 9;
            this.label1.Text = "The Library";
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "LibraryForm";
            this.Text = "Library";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.Button AddCopies_Button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddLoanButton;
        private System.Windows.Forms.Button MemberButton;
        private System.Windows.Forms.TextBox AddCopies_textBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}

