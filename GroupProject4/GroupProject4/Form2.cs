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
        HashSet<User> users;
        HashSet<Book> books;
        User currentUser;

        Form1 form1;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        public void Show(HashSet<User> users, HashSet<Book> books)
        {
            this.users = users;
            this.books = books;
            base.Show();
        }

        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Hide();
            this.clearAll();
        }

        private void btn_SearchUser_Click(object sender, EventArgs e)
        {
            String userID = tbx_userid.Text.Trim();
            if (userID.Equals(""))
            {
                lbl_SearchError.Text = "Please provide the user id";
                tbx_userid.Focus();
                tbx_useremail.Text = "";
                tbx_username.Text = "";
                tbx_userphone.Text = "";
                return;
            }
            this.currentUser = this.findUserByID(Int32.Parse(userID));
            if (this.currentUser == null)
            {
                lbl_SearchError.Text = "User with id " + userID + " not found";
                tbx_userid.Focus();
                tbx_useremail.Text = "";
                tbx_username.Text = "";
                tbx_userphone.Text = "";
                return;
            }
            tbx_username.Text = this.currentUser.UserFirstName + " " + this.currentUser.UserLastName;
            tbx_useremail.Text = this.currentUser.UserEmail;
            tbx_userphone.Text = this.currentUser.UserPhone;
            this.populateBorrowedBooks();
            this.populateAvailableBooks();
            lbl_SearchError.Text = "";
        }

        private void btn_borrow_book_Click(object sender, EventArgs e)
        {
            if (this.currentUser == null)
            {
                lbl_SearchError.Text = "Please search the user first";
                tbx_userid.Focus();
                return;
            }
            Book selectedBook = (Book)lbx_available_books.SelectedItem;
            if (selectedBook != null)
            {
                this.currentUser.AddBook(selectedBook);
                selectedBook.BorrowedBy = this.currentUser;
                this.populateAvailableBooks();
                this.populateBorrowedBooks();
            }
        }

        private void btn_return_book_Click(object sender, EventArgs e)
        {
            if (this.currentUser == null)
            {
                lbl_SearchError.Text = "Please search the user first";
                tbx_userid.Focus();
                return;
            }
            Book selectedBook = (Book)lbx_borrowed_books.SelectedItem;
            if (selectedBook != null)
            {
                this.currentUser.RemoveBook(selectedBook);
                selectedBook.BorrowedBy = null;
                this.populateAvailableBooks();
                this.populateBorrowedBooks();
            }
        }

        private void clearAll()
        {
            tbx_userid.Text = "";
            tbx_username.Text = "";
            tbx_useremail.Text = "";
            tbx_userphone.Text = "";
            lbl_SearchError.Text = "";
            lbx_available_books.Items.Clear();
            lbx_borrowed_books.Items.Clear();
            this.currentUser = null;
        }

        private void populateBorrowedBooks()
        {
            lbx_borrowed_books.Items.Clear();
            if (this.currentUser.BorrowedBooks.Count() <= 0)
            {
                // show error message
                return;
            }
            foreach (Book book in this.currentUser.BorrowedBooks)
            {
                lbx_borrowed_books.Items.Add(book);
            }
        }

        private void populateAvailableBooks()
        {
            lbx_available_books.Items.Clear();
            IEnumerable<Book> availableBooks = this.books
                .Where((Book book) => book.BorrowedBy == null)
               .Except(this.currentUser.BorrowedBooks);
            foreach (Book book in availableBooks)
            {
                lbx_available_books.Items.Add(book);
            }
        }

        private User findUserByID(int userID)
        {
            foreach (User user in users)
            {
                if (user.UserId == userID)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
