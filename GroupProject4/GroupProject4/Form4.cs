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
    public partial class Form4 : Form
    {
        HashSet<Book> books;
        Book currentBook;

        Form1 form1;
        public Form4(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        public void Show(HashSet<Book> books)
        {
            this.books = books;
            base.Show();
        }

        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            this.form1.Show();
            this.Hide();
            this.clearAll();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            String bookTitle = tbx_booktitle.Text.Trim();
            if (bookTitle.Equals(""))
            {
                this.clearAll();
                lbl_SearchError.Text = "Please provide the book name";
                tbx_booktitle.Focus();
                return;
            }
            this.currentBook = this.findBookByTitle(bookTitle);
            if (this.currentBook == null)
            {
                this.clearAll();
                lbl_SearchError.Text = "Book with title " + bookTitle + " not found";
                tbx_booktitle.Focus();
                return;
            }

            tbx_bookid.Text = "" + this.currentBook.BookId;
            tbx_bookyear.Text = "" + this.currentBook.BookYear;
            tbx_bookprice.Text = "" + this.currentBook.BookPrice;
            tbx_bookauthor.Text = this.currentBook.BookAuthor;
            this.populateCategory(this.currentBook.Category);
            this.populateBorrowedBy(this.currentBook.BorrowedBy);
            lbl_SearchError.Text = "";
        }

        private void clearAll()
        {
            tbx_bookid.Text = "";
            tbx_booktitle.Text = "";
            tbx_bookyear.Text = "";
            tbx_bookprice.Text = "";
            tbx_bookauthor.Text = "";
            tbx_categoryid.Text = "";
            tbx_categoryname.Text = "";
            tbx_categorydesc.Text = "";
            tbx_userid.Text = "";
            tbx_username.Text = "";
            tbx_useremail.Text = "";
            tbx_userphone.Text = "";
            lbl_SearchError.Text = "";
            lbl_CategoryStatus.Text = "";
            lbl_BorrowedStatus.Text = "";
            this.currentBook = null;
        }

        private void populateCategory(Category category)
        {
            if (category == null)
            {
                lbl_CategoryStatus.Text = "UNASSIGNED";
                return;
            }
            lbl_CategoryStatus.Text = "ASSIGNED";
            tbx_categoryid.Text = "" + category.CategoryID;
            tbx_categoryname.Text = category.CategoryName;
            tbx_categorydesc.Text = category.CategoryDescription;
        }

        private void populateBorrowedBy(User borrowedBy)
        {
            if (borrowedBy == null)
            {
                lbl_BorrowedStatus.Text = "AVAILABLE";
                return;
            }
            lbl_BorrowedStatus.Text = "BORROWED";
            tbx_userid.Text = "" + borrowedBy.UserId;
            tbx_username.Text = borrowedBy.UserFirstName + " " + borrowedBy.UserLastName;
            tbx_useremail.Text = borrowedBy.UserEmail;
            tbx_userphone.Text = borrowedBy.UserPhone;
        }

        private Book findBookByTitle(String bookTitle)
        {
            foreach (Book book in books)
            {
                if (book.BookTitle.Equals(bookTitle))
                {
                    return book;
                }
            }
            return null;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
