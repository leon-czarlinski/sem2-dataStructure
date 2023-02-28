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
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 928);
            this.Controls.Add(this.btn_form3);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_form3;
    }
}