﻿namespace GroupProject4
{
    partial class Form2
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
            this.lbx_borrowed_books = new System.Windows.Forms.ListBox();
            this.lbx_available_books = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_borrow_book = new System.Windows.Forms.Button();
            this.btn_return_book = new System.Windows.Forms.Button();
            this.lbl_userid = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.tbx_userid = new System.Windows.Forms.TextBox();
            this.tbx_username = new System.Windows.Forms.TextBox();
            this.tbx_useremail = new System.Windows.Forms.TextBox();
            this.tbx_userphone = new System.Windows.Forms.TextBox();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.btn_SearchUser = new System.Windows.Forms.Button();
            this.lbl_SearchError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbx_borrowed_books
            // 
            this.lbx_borrowed_books.FormattingEnabled = true;
            this.lbx_borrowed_books.ItemHeight = 20;
            this.lbx_borrowed_books.Location = new System.Drawing.Point(16, 266);
            this.lbx_borrowed_books.Name = "lbx_borrowed_books";
            this.lbx_borrowed_books.Size = new System.Drawing.Size(448, 384);
            this.lbx_borrowed_books.TabIndex = 2;
            // 
            // lbx_available_books
            // 
            this.lbx_available_books.FormattingEnabled = true;
            this.lbx_available_books.ItemHeight = 20;
            this.lbx_available_books.Location = new System.Drawing.Point(706, 266);
            this.lbx_available_books.Name = "lbx_available_books";
            this.lbx_available_books.Size = new System.Drawing.Size(448, 384);
            this.lbx_available_books.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Borrowed Books";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(711, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Available Books";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.MaximumSize = new System.Drawing.Size(68, 20);
            this.label3.MinimumSize = new System.Drawing.Size(68, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "User ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.MaximumSize = new System.Drawing.Size(68, 20);
            this.label4.MinimumSize = new System.Drawing.Size(68, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 148);
            this.label5.MaximumSize = new System.Drawing.Size(68, 20);
            this.label5.MinimumSize = new System.Drawing.Size(68, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 184);
            this.label6.MaximumSize = new System.Drawing.Size(68, 20);
            this.label6.MinimumSize = new System.Drawing.Size(68, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Phone:";
            // 
            // btn_borrow_book
            // 
            this.btn_borrow_book.Location = new System.Drawing.Point(509, 398);
            this.btn_borrow_book.Name = "btn_borrow_book";
            this.btn_borrow_book.Size = new System.Drawing.Size(160, 29);
            this.btn_borrow_book.TabIndex = 10;
            this.btn_borrow_book.Text = "<< Borrow Book";
            this.btn_borrow_book.UseVisualStyleBackColor = true;
            this.btn_borrow_book.Click += new System.EventHandler(this.btn_borrow_book_Click);
            // 
            // btn_return_book
            // 
            this.btn_return_book.Location = new System.Drawing.Point(509, 466);
            this.btn_return_book.Name = "btn_return_book";
            this.btn_return_book.Size = new System.Drawing.Size(160, 29);
            this.btn_return_book.TabIndex = 11;
            this.btn_return_book.Text = "Return Book >>";
            this.btn_return_book.UseVisualStyleBackColor = true;
            this.btn_return_book.Click += new System.EventHandler(this.btn_return_book_Click);
            // 
            // lbl_userid
            // 
            this.lbl_userid.AutoSize = true;
            this.lbl_userid.Location = new System.Drawing.Point(86, 73);
            this.lbl_userid.Name = "lbl_userid";
            this.lbl_userid.Size = new System.Drawing.Size(0, 20);
            this.lbl_userid.TabIndex = 12;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(86, 111);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(0, 20);
            this.lbl_name.TabIndex = 13;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(86, 148);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(0, 20);
            this.lbl_email.TabIndex = 14;
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(86, 184);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(0, 20);
            this.lbl_phone.TabIndex = 15;
            // 
            // tbx_userid
            // 
            this.tbx_userid.HideSelection = false;
            this.tbx_userid.Location = new System.Drawing.Point(92, 70);
            this.tbx_userid.Name = "tbx_userid";
            this.tbx_userid.Size = new System.Drawing.Size(368, 26);
            this.tbx_userid.TabIndex = 27;
            // 
            // tbx_username
            // 
            this.tbx_username.Enabled = false;
            this.tbx_username.Location = new System.Drawing.Point(92, 108);
            this.tbx_username.Name = "tbx_username";
            this.tbx_username.ReadOnly = true;
            this.tbx_username.Size = new System.Drawing.Size(368, 26);
            this.tbx_username.TabIndex = 28;
            // 
            // tbx_useremail
            // 
            this.tbx_useremail.Enabled = false;
            this.tbx_useremail.Location = new System.Drawing.Point(92, 145);
            this.tbx_useremail.Name = "tbx_useremail";
            this.tbx_useremail.ReadOnly = true;
            this.tbx_useremail.Size = new System.Drawing.Size(368, 26);
            this.tbx_useremail.TabIndex = 29;
            // 
            // tbx_userphone
            // 
            this.tbx_userphone.Enabled = false;
            this.tbx_userphone.Location = new System.Drawing.Point(92, 181);
            this.tbx_userphone.Name = "tbx_userphone";
            this.tbx_userphone.ReadOnly = true;
            this.tbx_userphone.Size = new System.Drawing.Size(368, 26);
            this.tbx_userphone.TabIndex = 30;
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.Location = new System.Drawing.Point(16, 12);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(144, 35);
            this.btn_GoBack.TabIndex = 31;
            this.btn_GoBack.Text = "Go Back";
            this.btn_GoBack.UseVisualStyleBackColor = true;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // btn_SearchUser
            // 
            this.btn_SearchUser.Location = new System.Drawing.Point(478, 66);
            this.btn_SearchUser.Name = "btn_SearchUser";
            this.btn_SearchUser.Size = new System.Drawing.Size(125, 35);
            this.btn_SearchUser.TabIndex = 32;
            this.btn_SearchUser.Text = "Search User";
            this.btn_SearchUser.UseVisualStyleBackColor = true;
            this.btn_SearchUser.Click += new System.EventHandler(this.btn_SearchUser_Click);
            // 
            // lbl_SearchError
            // 
            this.lbl_SearchError.AutoSize = true;
            this.lbl_SearchError.ForeColor = System.Drawing.Color.Red;
            this.lbl_SearchError.Location = new System.Drawing.Point(618, 73);
            this.lbl_SearchError.Name = "lbl_SearchError";
            this.lbl_SearchError.Size = new System.Drawing.Size(0, 20);
            this.lbl_SearchError.TabIndex = 33;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 742);
            this.Controls.Add(this.lbl_SearchError);
            this.Controls.Add(this.btn_SearchUser);
            this.Controls.Add(this.btn_GoBack);
            this.Controls.Add(this.tbx_userphone);
            this.Controls.Add(this.tbx_useremail);
            this.Controls.Add(this.tbx_username);
            this.Controls.Add(this.tbx_userid);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_userid);
            this.Controls.Add(this.btn_return_book);
            this.Controls.Add(this.btn_borrow_book);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbx_available_books);
            this.Controls.Add(this.lbx_borrowed_books);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbx_borrowed_books;
        private System.Windows.Forms.ListBox lbx_available_books;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_borrow_book;
        private System.Windows.Forms.Button btn_return_book;
        private System.Windows.Forms.Label lbl_userid;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.TextBox tbx_userid;
        private System.Windows.Forms.TextBox tbx_username;
        private System.Windows.Forms.TextBox tbx_useremail;
        private System.Windows.Forms.TextBox tbx_userphone;
        private System.Windows.Forms.Button btn_GoBack;
        private System.Windows.Forms.Button btn_SearchUser;
        private System.Windows.Forms.Label lbl_SearchError;
    }
}