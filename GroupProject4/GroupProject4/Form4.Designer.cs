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
            this.btn_form3 = new System.Windows.Forms.Button();
            this.lbl_bookName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_showInfo = new System.Windows.Forms.Button();
            this.lbx_bookDetails = new System.Windows.Forms.ListBox();
            this.lbl_bookDetails = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_form3
            // 
            this.btn_form3.Location = new System.Drawing.Point(37, 853);
            this.btn_form3.Name = "btn_form3";
            this.btn_form3.Size = new System.Drawing.Size(194, 53);
            this.btn_form3.TabIndex = 0;
            this.btn_form3.Text = "Go to form3";
            this.btn_form3.UseVisualStyleBackColor = true;
            this.btn_form3.Click += new System.EventHandler(this.btn_form3_Click);
            // 
            // lbl_bookName
            // 
            this.lbl_bookName.AutoSize = true;
            this.lbl_bookName.Location = new System.Drawing.Point(87, 117);
            this.lbl_bookName.Name = "lbl_bookName";
            this.lbl_bookName.Size = new System.Drawing.Size(217, 25);
            this.lbl_bookName.TabIndex = 1;
            this.lbl_bookName.Text = "Enter the book name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 31);
            this.textBox1.TabIndex = 2;
            // 
            // btn_showInfo
            // 
            this.btn_showInfo.Location = new System.Drawing.Point(92, 266);
            this.btn_showInfo.Name = "btn_showInfo";
            this.btn_showInfo.Size = new System.Drawing.Size(194, 53);
            this.btn_showInfo.TabIndex = 3;
            this.btn_showInfo.Text = "Show info";
            this.btn_showInfo.UseVisualStyleBackColor = true;
            // 
            // lbx_bookDetails
            // 
            this.lbx_bookDetails.FormattingEnabled = true;
            this.lbx_bookDetails.ItemHeight = 25;
            this.lbx_bookDetails.Location = new System.Drawing.Point(551, 165);
            this.lbx_bookDetails.Name = "lbx_bookDetails";
            this.lbx_bookDetails.Size = new System.Drawing.Size(809, 529);
            this.lbx_bookDetails.TabIndex = 4;
            // 
            // lbl_bookDetails
            // 
            this.lbl_bookDetails.AutoSize = true;
            this.lbl_bookDetails.Location = new System.Drawing.Point(546, 117);
            this.lbl_bookDetails.Name = "lbl_bookDetails";
            this.lbl_bookDetails.Size = new System.Drawing.Size(139, 25);
            this.lbl_bookDetails.TabIndex = 5;
            this.lbl_bookDetails.Text = "Book Details:";
            this.lbl_bookDetails.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(92, 760);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(79, 25);
            this.lbl_status.TabIndex = 6;
            this.lbl_status.Text = "Status:";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 928);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_bookDetails);
            this.Controls.Add(this.lbx_bookDetails);
            this.Controls.Add(this.btn_showInfo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_bookName);
            this.Controls.Add(this.btn_form3);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_form3;
        private System.Windows.Forms.Label lbl_bookName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_showInfo;
        private System.Windows.Forms.ListBox lbx_bookDetails;
        private System.Windows.Forms.Label lbl_bookDetails;
        private System.Windows.Forms.Label lbl_status;
    }
}