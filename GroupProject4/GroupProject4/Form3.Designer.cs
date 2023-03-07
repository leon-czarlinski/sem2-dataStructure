namespace GroupProject4
{
    partial class Form3
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
            this.btn_unassigned_book = new System.Windows.Forms.Button();
            this.btn_assigned_book = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbx_unassigned_books = new System.Windows.Forms.ListBox();
            this.lbx_assigned_books = new System.Windows.Forms.ListBox();
            this.tbx_categoryid = new System.Windows.Forms.TextBox();
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.tbx_description = new System.Windows.Forms.TextBox();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.lbl_SearchError = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_unassigned_book
            // 
            this.btn_unassigned_book.Location = new System.Drawing.Point(509, 465);
            this.btn_unassigned_book.Name = "btn_unassigned_book";
            this.btn_unassigned_book.Size = new System.Drawing.Size(160, 29);
            this.btn_unassigned_book.TabIndex = 25;
            this.btn_unassigned_book.Text = "Unassign Book >>";
            this.btn_unassigned_book.UseVisualStyleBackColor = true;
            this.btn_unassigned_book.Click += new System.EventHandler(this.btn_unassigned_book_Click);
            // 
            // btn_assigned_book
            // 
            this.btn_assigned_book.Location = new System.Drawing.Point(509, 397);
            this.btn_assigned_book.Name = "btn_assigned_book";
            this.btn_assigned_book.Size = new System.Drawing.Size(160, 29);
            this.btn_assigned_book.TabIndex = 24;
            this.btn_assigned_book.Text = "<< Assign Book";
            this.btn_assigned_book.UseVisualStyleBackColor = true;
            this.btn_assigned_book.Click += new System.EventHandler(this.btn_assigned_book_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 147);
            this.label5.MaximumSize = new System.Drawing.Size(95, 20);
            this.label5.MinimumSize = new System.Drawing.Size(95, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.MaximumSize = new System.Drawing.Size(95, 20);
            this.label4.MinimumSize = new System.Drawing.Size(95, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.MaximumSize = new System.Drawing.Size(95, 20);
            this.label3.MinimumSize = new System.Drawing.Size(95, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "CategoryID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(702, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Unassigned Books";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Assigned Books";
            // 
            // lbx_unassigned_books
            // 
            this.lbx_unassigned_books.FormattingEnabled = true;
            this.lbx_unassigned_books.ItemHeight = 20;
            this.lbx_unassigned_books.Location = new System.Drawing.Point(706, 266);
            this.lbx_unassigned_books.Name = "lbx_unassigned_books";
            this.lbx_unassigned_books.Size = new System.Drawing.Size(448, 384);
            this.lbx_unassigned_books.TabIndex = 17;
            // 
            // lbx_assigned_books
            // 
            this.lbx_assigned_books.FormattingEnabled = true;
            this.lbx_assigned_books.ItemHeight = 20;
            this.lbx_assigned_books.Location = new System.Drawing.Point(12, 266);
            this.lbx_assigned_books.Name = "lbx_assigned_books";
            this.lbx_assigned_books.Size = new System.Drawing.Size(448, 384);
            this.lbx_assigned_books.TabIndex = 16;
            // 
            // tbx_categoryid
            // 
            this.tbx_categoryid.Enabled = false;
            this.tbx_categoryid.Location = new System.Drawing.Point(113, 69);
            this.tbx_categoryid.Name = "tbx_categoryid";
            this.tbx_categoryid.ReadOnly = true;
            this.tbx_categoryid.Size = new System.Drawing.Size(347, 26);
            this.tbx_categoryid.TabIndex = 26;
            // 
            // tbx_name
            // 
            this.tbx_name.Location = new System.Drawing.Point(113, 107);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(347, 26);
            this.tbx_name.TabIndex = 27;
            // 
            // tbx_description
            // 
            this.tbx_description.Enabled = false;
            this.tbx_description.Location = new System.Drawing.Point(113, 144);
            this.tbx_description.Multiline = true;
            this.tbx_description.Name = "tbx_description";
            this.tbx_description.ReadOnly = true;
            this.tbx_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_description.Size = new System.Drawing.Size(347, 68);
            this.tbx_description.TabIndex = 28;
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.Location = new System.Drawing.Point(16, 12);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(120, 35);
            this.btn_GoBack.TabIndex = 29;
            this.btn_GoBack.Text = "Go Back";
            this.btn_GoBack.UseVisualStyleBackColor = true;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // lbl_SearchError
            // 
            this.lbl_SearchError.AutoSize = true;
            this.lbl_SearchError.ForeColor = System.Drawing.Color.Red;
            this.lbl_SearchError.Location = new System.Drawing.Point(632, 110);
            this.lbl_SearchError.Name = "lbl_SearchError";
            this.lbl_SearchError.Size = new System.Drawing.Size(0, 20);
            this.lbl_SearchError.TabIndex = 35;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(466, 103);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(140, 35);
            this.btn_Search.TabIndex = 34;
            this.btn_Search.Text = "Search Category";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 742);
            this.Controls.Add(this.lbl_SearchError);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_GoBack);
            this.Controls.Add(this.tbx_description);
            this.Controls.Add(this.tbx_name);
            this.Controls.Add(this.tbx_categoryid);
            this.Controls.Add(this.btn_unassigned_book);
            this.Controls.Add(this.btn_assigned_book);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbx_unassigned_books);
            this.Controls.Add(this.lbx_assigned_books);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_unassigned_book;
        private System.Windows.Forms.Button btn_assigned_book;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbx_unassigned_books;
        private System.Windows.Forms.ListBox lbx_assigned_books;
        private System.Windows.Forms.TextBox tbx_categoryid;
        private System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.TextBox tbx_description;
        private System.Windows.Forms.Button btn_GoBack;
        private System.Windows.Forms.Label lbl_SearchError;
        private System.Windows.Forms.Button btn_Search;
    }
}