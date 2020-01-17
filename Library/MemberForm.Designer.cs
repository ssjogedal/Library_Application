namespace Library
{
    partial class MemberForm
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.pNumberTextBox = new System.Windows.Forms.TextBox();
            this.AddMemberButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Member_listBox = new System.Windows.Forms.ListBox();
            this.Members = new System.Windows.Forms.Label();
            this.memberIdTextbox = new System.Windows.Forms.TextBox();
            this.ScnOutTextBox = new System.Windows.Forms.TextBox();
            this.NameOutTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Loans_listBox = new System.Windows.Forms.ListBox();
            this.Loans = new System.Windows.Forms.Label();
            this.SelectMemberButton = new System.Windows.Forms.Button();
            this.FineTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(17, 95);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // pNumberTextBox
            // 
            this.pNumberTextBox.Location = new System.Drawing.Point(17, 49);
            this.pNumberTextBox.Name = "pNumberTextBox";
            this.pNumberTextBox.Size = new System.Drawing.Size(114, 20);
            this.pNumberTextBox.TabIndex = 1;
            // 
            // AddMemberButton
            // 
            this.AddMemberButton.Location = new System.Drawing.Point(17, 134);
            this.AddMemberButton.Name = "AddMemberButton";
            this.AddMemberButton.Size = new System.Drawing.Size(75, 23);
            this.AddMemberButton.TabIndex = 2;
            this.AddMemberButton.Text = "Add Member";
            this.AddMemberButton.UseVisualStyleBackColor = true;
            this.AddMemberButton.Click += new System.EventHandler(this.AddMemberButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Social Security Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // Member_listBox
            // 
            this.Member_listBox.FormattingEnabled = true;
            this.Member_listBox.Location = new System.Drawing.Point(36, 54);
            this.Member_listBox.Name = "Member_listBox";
            this.Member_listBox.Size = new System.Drawing.Size(120, 95);
            this.Member_listBox.TabIndex = 5;
            // 
            // Members
            // 
            this.Members.AutoSize = true;
            this.Members.Location = new System.Drawing.Point(36, 38);
            this.Members.Name = "Members";
            this.Members.Size = new System.Drawing.Size(50, 13);
            this.Members.TabIndex = 6;
            this.Members.Text = "Members";
            // 
            // memberIdTextbox
            // 
            this.memberIdTextbox.Location = new System.Drawing.Point(42, 47);
            this.memberIdTextbox.Name = "memberIdTextbox";
            this.memberIdTextbox.Size = new System.Drawing.Size(71, 20);
            this.memberIdTextbox.TabIndex = 7;
            // 
            // ScnOutTextBox
            // 
            this.ScnOutTextBox.Location = new System.Drawing.Point(132, 47);
            this.ScnOutTextBox.Name = "ScnOutTextBox";
            this.ScnOutTextBox.Size = new System.Drawing.Size(117, 20);
            this.ScnOutTextBox.TabIndex = 8;
            // 
            // NameOutTextBox
            // 
            this.NameOutTextBox.Location = new System.Drawing.Point(132, 96);
            this.NameOutTextBox.Name = "NameOutTextBox";
            this.NameOutTextBox.Size = new System.Drawing.Size(117, 20);
            this.NameOutTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Member Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Social Security Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Name";
            // 
            // Loans_listBox
            // 
            this.Loans_listBox.FormattingEnabled = true;
            this.Loans_listBox.Location = new System.Drawing.Point(273, 31);
            this.Loans_listBox.Name = "Loans_listBox";
            this.Loans_listBox.Size = new System.Drawing.Size(120, 95);
            this.Loans_listBox.TabIndex = 13;
            // 
            // Loans
            // 
            this.Loans.AutoSize = true;
            this.Loans.Location = new System.Drawing.Point(270, 15);
            this.Loans.Name = "Loans";
            this.Loans.Size = new System.Drawing.Size(36, 13);
            this.Loans.TabIndex = 14;
            this.Loans.Text = "Loans";
            // 
            // SelectMemberButton
            // 
            this.SelectMemberButton.Location = new System.Drawing.Point(39, 156);
            this.SelectMemberButton.Name = "SelectMemberButton";
            this.SelectMemberButton.Size = new System.Drawing.Size(94, 34);
            this.SelectMemberButton.TabIndex = 15;
            this.SelectMemberButton.Text = "Select Member";
            this.SelectMemberButton.UseVisualStyleBackColor = true;
            this.SelectMemberButton.Click += new System.EventHandler(this.SelectMemberButton_Click);
            // 
            // FineTextBox
            // 
            this.FineTextBox.Location = new System.Drawing.Point(42, 96);
            this.FineTextBox.Name = "FineTextBox";
            this.FineTextBox.Size = new System.Drawing.Size(71, 20);
            this.FineTextBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Overdue Fine";
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(751, 262);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 18;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Controls.Add(this.pNumberTextBox);
            this.groupBox1.Controls.Add(this.AddMemberButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 212);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new member";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.Member_listBox);
            this.groupBox2.Controls.Add(this.Members);
            this.groupBox2.Controls.Add(this.SelectMemberButton);
            this.groupBox2.Location = new System.Drawing.Point(241, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 212);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Members";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Loans_listBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.Loans);
            this.groupBox3.Controls.Add(this.NameOutTextBox);
            this.groupBox3.Controls.Add(this.FineTextBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.ScnOutTextBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.memberIdTextbox);
            this.groupBox3.Location = new System.Drawing.Point(192, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(413, 143);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Member Details";
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 315);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.back_button);
            this.Name = "MemberForm";
            this.Text = "MemberForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox pNumberTextBox;
        private System.Windows.Forms.Button AddMemberButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Member_listBox;
        private System.Windows.Forms.Label Members;
        private System.Windows.Forms.TextBox memberIdTextbox;
        private System.Windows.Forms.TextBox ScnOutTextBox;
        private System.Windows.Forms.TextBox NameOutTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox Loans_listBox;
        private System.Windows.Forms.Label Loans;
        private System.Windows.Forms.Button SelectMemberButton;
        private System.Windows.Forms.TextBox FineTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}