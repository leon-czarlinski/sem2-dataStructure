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
            this.btn_form2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_form4
            // 
            this.btn_form4.Location = new System.Drawing.Point(1283, 853);
            this.btn_form4.Name = "btn_form4";
            this.btn_form4.Size = new System.Drawing.Size(194, 53);
            this.btn_form4.TabIndex = 0;
            this.btn_form4.Text = "Go to form4";
            this.btn_form4.UseVisualStyleBackColor = true;
            this.btn_form4.Click += new System.EventHandler(this.btn_form4_Click);
            // 
            // btn_form2
            // 
            this.btn_form2.Location = new System.Drawing.Point(37, 853);
            this.btn_form2.Name = "btn_form2";
            this.btn_form2.Size = new System.Drawing.Size(194, 53);
            this.btn_form2.TabIndex = 1;
            this.btn_form2.Text = "Go to form2";
            this.btn_form2.UseVisualStyleBackColor = true;
            this.btn_form2.Click += new System.EventHandler(this.btn_form2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 928);
            this.Controls.Add(this.btn_form2);
            this.Controls.Add(this.btn_form4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_form4;
        private System.Windows.Forms.Button btn_form2;
    }
}