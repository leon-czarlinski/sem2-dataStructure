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
    public partial class Form2 : Form
    {
        User user;
        SortedSet<Book> books;

        Form1 form1;
        Form3 form3;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            form3 = new Form3(this);
            this.populateData();
        }

        public void Show(User user, SortedSet<Book> books)
        {
            this.user = user;
            this.books = books;
            this.populateData();
            this.Show();
        }

        private void populateData()
        {
            tbx_userid.Text = this.user.UserId.ToString();
            tbx_username.Text = this.user.UserFirstName + " " + this.user.UserLastName;
            tbx_useremail.Text = this.user.UserEmail;
            tbx_userphone.Text = this.user.UserPhone;
        }

        private void btn_form1_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Hide();
        }

        private void btn_form3_Click(object sender, EventArgs e)
        {
            form3.Show();
            this.Hide();
        }

        private void btn_borrow_book_Click(object sender, EventArgs e)
        {

        }
    }
}
