using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject4
{
    public partial class Form3 : Form
    {
        Category category;
        SortedSet<Book> books;

        Form2 form2;
        Form4 form4;
        public Form3(Form2 form2)
        {
            InitializeComponent();
            this.form2 = form2;
            form4 = new Form4(this);
        }

        public void Show(Category category, SortedSet<Book> books)
        {
            this.category = category;
            this.books = books;
            this.populateData();
            this.Show();
        }

        private void populateData()
        {
            tbx_categoryid.Text = this.category.CategoryID.ToString();
            tbx_name.Text = this.category.CategoryName;
            tbx_description.Text = this.category.CategoryDescription;
        }

        private void btn_form2_Click(object sender, EventArgs e)
        {
            form2.Show();
            this.Hide();
        }

        private void btn_form4_Click(object sender, EventArgs e)
        {
            form4.Show();
            this.Hide();
        }
    }
}
