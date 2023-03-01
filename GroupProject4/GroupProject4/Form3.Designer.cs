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
            this.btn_form4 = new System.Windows.Forms.Button();
            this.btn_goback = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // btn_form4
            // 
            this.btn_form4.Location = new System.Drawing.Point(962, 682);
            this.btn_form4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_form4.Name = "btn_form4";
            this.btn_form4.Size = new System.Drawing.Size(146, 42);
            this.btn_form4.TabIndex = 0;
            this.btn_form4.Text = "Go to form4";
            this.btn_form4.UseVisualStyleBackColor = true;
            this.btn_form4.Click += new System.EventHandler(this.btn_form4_Click);
            // 
            // btn_goback
            // 
            this.btn_goback.Location = new System.Drawing.Point(28, 682);
            this.btn_goback.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_goback.Name = "btn_goback";
            this.btn_goback.Size = new System.Drawing.Size(146, 42);
            this.btn_goback.TabIndex = 1;
            this.btn_goback.Text = "Go Back";
            this.btn_goback.UseVisualStyleBackColor = true;
            this.btn_goback.Click += new System.EventHandler(this.btn_form2_Click);
            // 
            // btn_unassigned_book
            // 
            this.btn_unassigned_book.Location = new System.Drawing.Point(509, 412);
            this.btn_unassigned_book.Name = "btn_unassigned_book";
            this.btn_unassigned_book.Size = new System.Drawing.Size(160, 29);
            this.btn_unassigned_book.TabIndex = 25;
            this.btn_unassigned_book.Text = "Unassign Book >>";
            this.btn_unassigned_book.UseVisualStyleBackColor = true;
            // 
            // btn_assigned_book
            // 
            this.btn_assigned_book.Location = new System.Drawing.Point(509, 344);
            this.btn_assigned_book.Name = "btn_assigned_book";
            this.btn_assigned_book.Size = new System.Drawing.Size(160, 29);
            this.btn_assigned_book.TabIndex = 24;
            this.btn_assigned_book.Text = "<< Assign Book";
            this.btn_assigned_book.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 94);
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
            this.label4.Location = new System.Drawing.Point(12, 57);
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
            this.label3.Location = new System.Drawing.Point(12, 19);
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
            this.label2.Location = new System.Drawing.Point(702, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Unassigned Books";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Assigned Books";
            // 
            // lbx_unassigned_books
            // 
            this.lbx_unassigned_books.FormattingEnabled = true;
            this.lbx_unassigned_books.ItemHeight = 20;
            this.lbx_unassigned_books.Location = new System.Drawing.Point(706, 199);
            this.lbx_unassigned_books.Name = "lbx_unassigned_books";
            this.lbx_unassigned_books.Size = new System.Drawing.Size(448, 464);
            this.lbx_unassigned_books.TabIndex = 17;
            // 
            // lbx_assigned_books
            // 
            this.lbx_assigned_books.FormattingEnabled = true;
            this.lbx_assigned_books.ItemHeight = 20;
            this.lbx_assigned_books.Location = new System.Drawing.Point(12, 199);
            this.lbx_assigned_books.Name = "lbx_assigned_books";
            this.lbx_assigned_books.Size = new System.Drawing.Size(448, 464);
            this.lbx_assigned_books.TabIndex = 16;
            // 
            // tbx_categoryid
            // 
            this.tbx_categoryid.Enabled = false;
            this.tbx_categoryid.Location = new System.Drawing.Point(113, 16);
            this.tbx_categoryid.Name = "tbx_categoryid";
            this.tbx_categoryid.ReadOnly = true;
            this.tbx_categoryid.Size = new System.Drawing.Size(347, 26);
            this.tbx_categoryid.TabIndex = 26;
            // 
            // tbx_name
            // 
            this.tbx_name.Enabled = false;
            this.tbx_name.Location = new System.Drawing.Point(113, 54);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.ReadOnly = true;
            this.tbx_name.Size = new System.Drawing.Size(347, 26);
            this.tbx_name.TabIndex = 27;
            // 
            // tbx_description
            // 
            this.tbx_description.Enabled = false;
            this.tbx_description.Location = new System.Drawing.Point(113, 91);
            this.tbx_description.Multiline = true;
            this.tbx_description.Name = "tbx_description";
            this.tbx_description.ReadOnly = true;
            this.tbx_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_description.Size = new System.Drawing.Size(347, 68);
            this.tbx_description.TabIndex = 28;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 742);
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
            this.Controls.Add(this.btn_goback);
            this.Controls.Add(this.btn_form4);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_form4;
        private System.Windows.Forms.Button btn_goback;
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
    }
}