namespace GroupProject4
{
    partial class Form4
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
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.lbl_SearchError = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tbx_booktitle = new System.Windows.Forms.TextBox();
            this.tbx_bookid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_bookyear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_bookprice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_bookauthor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_categorydesc = new System.Windows.Forms.TextBox();
            this.tbx_categoryname = new System.Windows.Forms.TextBox();
            this.tbx_categoryid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbx_userphone = new System.Windows.Forms.TextBox();
            this.tbx_useremail = new System.Windows.Forms.TextBox();
            this.tbx_username = new System.Windows.Forms.TextBox();
            this.tbx_userid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_CategoryStatus = new System.Windows.Forms.Label();
            this.lbl_BorrowedStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.Location = new System.Drawing.Point(12, 12);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(146, 42);
            this.btn_GoBack.TabIndex = 7;
            this.btn_GoBack.Text = "Go Back";
            this.btn_GoBack.UseVisualStyleBackColor = true;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // lbl_SearchError
            // 
            this.lbl_SearchError.AutoSize = true;
            this.lbl_SearchError.ForeColor = System.Drawing.Color.Red;
            this.lbl_SearchError.Location = new System.Drawing.Point(632, 104);
            this.lbl_SearchError.Name = "lbl_SearchError";
            this.lbl_SearchError.Size = new System.Drawing.Size(0, 20);
            this.lbl_SearchError.TabIndex = 41;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(466, 97);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(140, 35);
            this.btn_Search.TabIndex = 40;
            this.btn_Search.Text = "Search Book";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tbx_booktitle
            // 
            this.tbx_booktitle.Location = new System.Drawing.Point(113, 101);
            this.tbx_booktitle.Name = "tbx_booktitle";
            this.tbx_booktitle.Size = new System.Drawing.Size(347, 26);
            this.tbx_booktitle.TabIndex = 39;
            // 
            // tbx_bookid
            // 
            this.tbx_bookid.Enabled = false;
            this.tbx_bookid.Location = new System.Drawing.Point(113, 63);
            this.tbx_bookid.Name = "tbx_bookid";
            this.tbx_bookid.ReadOnly = true;
            this.tbx_bookid.Size = new System.Drawing.Size(347, 26);
            this.tbx_bookid.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.MaximumSize = new System.Drawing.Size(95, 20);
            this.label4.MinimumSize = new System.Drawing.Size(95, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.MaximumSize = new System.Drawing.Size(95, 20);
            this.label3.MinimumSize = new System.Drawing.Size(95, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "BookID:";
            // 
            // tbx_bookyear
            // 
            this.tbx_bookyear.Enabled = false;
            this.tbx_bookyear.Location = new System.Drawing.Point(113, 138);
            this.tbx_bookyear.Name = "tbx_bookyear";
            this.tbx_bookyear.ReadOnly = true;
            this.tbx_bookyear.Size = new System.Drawing.Size(347, 26);
            this.tbx_bookyear.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.MaximumSize = new System.Drawing.Size(95, 20);
            this.label1.MinimumSize = new System.Drawing.Size(95, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Year:";
            // 
            // tbx_bookprice
            // 
            this.tbx_bookprice.Enabled = false;
            this.tbx_bookprice.Location = new System.Drawing.Point(113, 176);
            this.tbx_bookprice.Name = "tbx_bookprice";
            this.tbx_bookprice.ReadOnly = true;
            this.tbx_bookprice.Size = new System.Drawing.Size(347, 26);
            this.tbx_bookprice.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 179);
            this.label2.MaximumSize = new System.Drawing.Size(95, 20);
            this.label2.MinimumSize = new System.Drawing.Size(95, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Price:";
            // 
            // tbx_bookauthor
            // 
            this.tbx_bookauthor.Enabled = false;
            this.tbx_bookauthor.Location = new System.Drawing.Point(113, 214);
            this.tbx_bookauthor.Name = "tbx_bookauthor";
            this.tbx_bookauthor.ReadOnly = true;
            this.tbx_bookauthor.Size = new System.Drawing.Size(347, 26);
            this.tbx_bookauthor.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 217);
            this.label5.MaximumSize = new System.Drawing.Size(95, 20);
            this.label5.MinimumSize = new System.Drawing.Size(95, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "Author:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 266);
            this.label6.MaximumSize = new System.Drawing.Size(130, 20);
            this.label6.MinimumSize = new System.Drawing.Size(130, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "Category Status:";
            // 
            // tbx_categorydesc
            // 
            this.tbx_categorydesc.Enabled = false;
            this.tbx_categorydesc.Location = new System.Drawing.Point(113, 381);
            this.tbx_categorydesc.Multiline = true;
            this.tbx_categorydesc.Name = "tbx_categorydesc";
            this.tbx_categorydesc.ReadOnly = true;
            this.tbx_categorydesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_categorydesc.Size = new System.Drawing.Size(347, 68);
            this.tbx_categorydesc.TabIndex = 54;
            // 
            // tbx_categoryname
            // 
            this.tbx_categoryname.Enabled = false;
            this.tbx_categoryname.Location = new System.Drawing.Point(113, 344);
            this.tbx_categoryname.Name = "tbx_categoryname";
            this.tbx_categoryname.ReadOnly = true;
            this.tbx_categoryname.Size = new System.Drawing.Size(347, 26);
            this.tbx_categoryname.TabIndex = 53;
            // 
            // tbx_categoryid
            // 
            this.tbx_categoryid.Enabled = false;
            this.tbx_categoryid.Location = new System.Drawing.Point(113, 306);
            this.tbx_categoryid.Name = "tbx_categoryid";
            this.tbx_categoryid.ReadOnly = true;
            this.tbx_categoryid.Size = new System.Drawing.Size(347, 26);
            this.tbx_categoryid.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 384);
            this.label7.MaximumSize = new System.Drawing.Size(95, 20);
            this.label7.MinimumSize = new System.Drawing.Size(95, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "Description:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 347);
            this.label8.MaximumSize = new System.Drawing.Size(95, 20);
            this.label8.MinimumSize = new System.Drawing.Size(95, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 50;
            this.label8.Text = "Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 309);
            this.label9.MaximumSize = new System.Drawing.Size(95, 20);
            this.label9.MinimumSize = new System.Drawing.Size(95, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 49;
            this.label9.Text = "CategoryID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 469);
            this.label10.MaximumSize = new System.Drawing.Size(140, 20);
            this.label10.MinimumSize = new System.Drawing.Size(140, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 20);
            this.label10.TabIndex = 55;
            this.label10.Text = "Borrowed Status:";
            // 
            // tbx_userphone
            // 
            this.tbx_userphone.Enabled = false;
            this.tbx_userphone.Location = new System.Drawing.Point(113, 616);
            this.tbx_userphone.Name = "tbx_userphone";
            this.tbx_userphone.ReadOnly = true;
            this.tbx_userphone.Size = new System.Drawing.Size(347, 26);
            this.tbx_userphone.TabIndex = 67;
            // 
            // tbx_useremail
            // 
            this.tbx_useremail.Enabled = false;
            this.tbx_useremail.Location = new System.Drawing.Point(113, 580);
            this.tbx_useremail.Name = "tbx_useremail";
            this.tbx_useremail.ReadOnly = true;
            this.tbx_useremail.Size = new System.Drawing.Size(347, 26);
            this.tbx_useremail.TabIndex = 66;
            // 
            // tbx_username
            // 
            this.tbx_username.Enabled = false;
            this.tbx_username.Location = new System.Drawing.Point(113, 543);
            this.tbx_username.Name = "tbx_username";
            this.tbx_username.ReadOnly = true;
            this.tbx_username.Size = new System.Drawing.Size(347, 26);
            this.tbx_username.TabIndex = 65;
            // 
            // tbx_userid
            // 
            this.tbx_userid.Enabled = false;
            this.tbx_userid.HideSelection = false;
            this.tbx_userid.Location = new System.Drawing.Point(113, 505);
            this.tbx_userid.Name = "tbx_userid";
            this.tbx_userid.ReadOnly = true;
            this.tbx_userid.Size = new System.Drawing.Size(347, 26);
            this.tbx_userid.TabIndex = 64;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 619);
            this.label11.MaximumSize = new System.Drawing.Size(68, 20);
            this.label11.MinimumSize = new System.Drawing.Size(68, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 20);
            this.label11.TabIndex = 59;
            this.label11.Text = "Phone:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 583);
            this.label12.MaximumSize = new System.Drawing.Size(68, 20);
            this.label12.MinimumSize = new System.Drawing.Size(68, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 20);
            this.label12.TabIndex = 58;
            this.label12.Text = "Email:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 546);
            this.label13.MaximumSize = new System.Drawing.Size(68, 20);
            this.label13.MinimumSize = new System.Drawing.Size(68, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 20);
            this.label13.TabIndex = 57;
            this.label13.Text = "Name:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 508);
            this.label14.MaximumSize = new System.Drawing.Size(68, 20);
            this.label14.MinimumSize = new System.Drawing.Size(68, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 20);
            this.label14.TabIndex = 56;
            this.label14.Text = "User ID:";
            // 
            // lbl_CategoryStatus
            // 
            this.lbl_CategoryStatus.AutoSize = true;
            this.lbl_CategoryStatus.Location = new System.Drawing.Point(158, 266);
            this.lbl_CategoryStatus.Name = "lbl_CategoryStatus";
            this.lbl_CategoryStatus.Size = new System.Drawing.Size(0, 20);
            this.lbl_CategoryStatus.TabIndex = 68;
            // 
            // lbl_BorrowedStatus
            // 
            this.lbl_BorrowedStatus.AutoSize = true;
            this.lbl_BorrowedStatus.Location = new System.Drawing.Point(152, 469);
            this.lbl_BorrowedStatus.Name = "lbl_BorrowedStatus";
            this.lbl_BorrowedStatus.Size = new System.Drawing.Size(0, 20);
            this.lbl_BorrowedStatus.TabIndex = 69;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 742);
            this.Controls.Add(this.lbl_BorrowedStatus);
            this.Controls.Add(this.lbl_CategoryStatus);
            this.Controls.Add(this.tbx_userphone);
            this.Controls.Add(this.tbx_useremail);
            this.Controls.Add(this.tbx_username);
            this.Controls.Add(this.tbx_userid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbx_categorydesc);
            this.Controls.Add(this.tbx_categoryname);
            this.Controls.Add(this.tbx_categoryid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbx_bookauthor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbx_bookprice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_bookyear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_SearchError);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tbx_booktitle);
            this.Controls.Add(this.tbx_bookid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_GoBack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_GoBack;
        private System.Windows.Forms.Label lbl_SearchError;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tbx_booktitle;
        private System.Windows.Forms.TextBox tbx_bookid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_bookyear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_bookprice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_bookauthor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_categorydesc;
        private System.Windows.Forms.TextBox tbx_categoryname;
        private System.Windows.Forms.TextBox tbx_categoryid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbx_userphone;
        private System.Windows.Forms.TextBox tbx_useremail;
        private System.Windows.Forms.TextBox tbx_username;
        private System.Windows.Forms.TextBox tbx_userid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_CategoryStatus;
        private System.Windows.Forms.Label lbl_BorrowedStatus;
    }
}