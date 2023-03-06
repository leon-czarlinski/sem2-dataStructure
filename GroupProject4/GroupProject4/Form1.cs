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
    public partial class Form1 : Form
    {
        Form2 form2;
        HashSet<User> users;
        HashSet<Book> books;
        SortedSet<Category> categories;
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2(this);
            users = new HashSet<User>(new UserComparator());
            books = new HashSet<Book>(new BookComparator());
            categories = new SortedSet<Category>();
        }

        private void btn_form2_Click(object sender, EventArgs e)
        {
            Object selectedItem = lbx_display.SelectedItem;
            if (selectedItem == null) return;
            if (selectedItem.GetType().Equals(typeof(User)))
            {
                User selectedUser = (User) selectedItem;
                this.form2.Show(selectedUser, books);
                this.Hide();
            } else if (selectedItem.GetType().Equals(typeof(Book)))
            {
                // open form4 passing book
            } else if(selectedItem.GetType().Equals(typeof(Category)))
            {
                // open form3 passing category
            }
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            lbl_errorUser.Text = "";
            if (string.IsNullOrWhiteSpace(txt_userID.Text) || string.IsNullOrWhiteSpace(txt_firstName.Text) ||
                string.IsNullOrWhiteSpace(txt_lastName.Text) || string.IsNullOrWhiteSpace(txt_email.Text) ||
                string.IsNullOrWhiteSpace(txt_phone.Text))
            {
                lbl_errorUser.Text = "Please, insert information";
                return;
            }

            int userID;
            if (!Int32.TryParse(txt_userID.Text, out userID))
            {
                lbl_errorUser.Text = "Invalid user ID format";
                return;
            }

            User newuser = new User(Int32.Parse(txt_userID.Text), txt_firstName.Text, txt_lastName.Text, txt_email.Text, txt_phone.Text);

            if (!users.Contains(newuser))
            {
                users.Add(newuser);
                txt_userID.Clear();
                txt_firstName.Clear();
                txt_lastName.Clear();
                txt_email.Clear();
                txt_phone.Clear();
                lbl_errorUser.Text = "User added with success";
            }
            else
            {
                lbl_errorUser.Text = "User already exists.";
            }
        }

        private void btn_removeUser_Click(object sender, EventArgs e)
        {
            lbl_errorUser.Text = "";
            if (users.Count > 0)
            {
                if (txt_userID.Text != "")
                {
                    User userToRemove = null;
                    foreach (User u in users)
                    {
                        if (u.UserId.Equals(Int32.Parse(txt_userID.Text)))
                        {
                            userToRemove = u;
                            break;
                        }
                    }
                    if (userToRemove != null)
                    {
                        users.Remove(userToRemove);
                        txt_userID.Clear();
                        txt_firstName.Clear();
                        txt_lastName.Clear();
                        txt_email.Clear();
                        txt_phone.Clear();
                        lbl_errorUser.Text = "User removed with success";
                    }
                    else
                    {
                        lbl_errorUser.Text = "User not found";
                    }
                }
                else
                {
                    lbl_errorUser.Text = "Please, insert an ID";
                }
            }
            else
            {
                lbl_errorUser.Text = "Empty list. No users to remove";
            }
            lbx_display.Items.Clear();
        }

        private void btn_displayUser_Click(object sender, EventArgs e)
        {
            lbl_errorUser.Text = "";
            lbx_display.Items.Clear();
            if (users.Count > 0)
            {
                if (txt_userID.Text == "")
                {
                    lbx_display.Items.Clear();
                    foreach (User u in users)
                    {
                        lbx_display.Items.Add(u.ToString());
                    }
                }
                else if (txt_userID.Text != "")
                {
                    lbx_display.Items.Clear();
                    User userToDisplay = null;
                    foreach (User u in users)
                    {
                        if (u.UserId.Equals(Int32.Parse(txt_userID.Text)))
                        {
                            userToDisplay = u;
                            break;
                        }
                    }
                    if (userToDisplay != null)
                    {
                        lbx_display.Items.Add(userToDisplay.ToString());
                    }
                    else
                    {
                        lbl_errorUser.Text = "User ID not found";
                    }
                }
                else
                {
                    lbl_errorUser.Text = "No users to display";
                }
            }
            else
            {
                lbl_errorUser.Text = "No users to display";
            }
        }

        private void btn_clearUser_Click(object sender, EventArgs e)
        {
            lbl_errorUser.Text = "";
            if (users.Count > 0)
            {
                users.Clear();
                lbx_display.Items.Clear();
            }
            else
            {
                lbl_errorUser.Text = "List already empty";
            }
        }

        private void btn_AddBook_Click(object sender, EventArgs e)
        {
            lbl_errorUser.Text = "";

            if (string.IsNullOrWhiteSpace(txt_bookID.Text) || string.IsNullOrWhiteSpace(txt_title.Text) ||
                string.IsNullOrWhiteSpace(txt_year.Text) || string.IsNullOrWhiteSpace(txt_author.Text) ||
                string.IsNullOrWhiteSpace(txt_price.Text))
            {
                lbl_errorUser.Text = "Please, insert information";
                return;
            }

            int bookID;
            if (!Int32.TryParse(txt_bookID.Text, out bookID))
            {
                lbl_errorUser.Text = "Invalid book ID format";
                return;
            }

            int year;
            if (!Int32.TryParse(txt_year.Text, out year))
            {
                lbl_errorUser.Text = "Invalid year format";
                return;
            }

            double price;
            if (!double.TryParse(txt_price.Text, out price))
            {
                lbl_errorUser.Text = "Invalid price format";
                return;
            }

            Book newbook = new Book(Int32.Parse(txt_bookID.Text), txt_title.Text, Int32.Parse(txt_year.Text), txt_author.Text, 
                                    double.Parse(txt_price.Text));

            if (!books.Contains(newbook))
            {
                books.Add(newbook);
                txt_bookID.Clear();
                txt_title.Clear();
                txt_year.Clear();
                txt_author.Clear();
                txt_price.Clear();
                lbl_errorUser.Text = "Book added with success";
            }
            else
            {
                lbl_errorUser.Text = "Book already exists.";
            }
        }


        private void btn_removeBook_Click(object sender, EventArgs e)
        {
            lbl_errorUser.Text = "";
            if (books.Count > 0)
            {
                if (txt_bookID.Text != "")
                {
                    Book bookToRemove = null;
                    foreach (Book b in books)
                    {
                        if (b.BookId.Equals(Int32.Parse(txt_bookID.Text)))
                        {
                            bookToRemove = b;
                            break;
                        }
                    }
                    if (bookToRemove != null)
                    {
                        books.Remove(bookToRemove);
                        txt_bookID.Clear();
                        txt_title.Clear();
                        txt_year.Clear();
                        txt_author.Clear();
                        txt_price.Clear();
                        lbl_errorUser.Text = "Book removed with success";
                    }
                    else
                    {
                        lbl_errorUser.Text = "Book not found";
                    }
                }
                else
                {
                    lbl_errorUser.Text = "Please, insert an ID";
                }
            }
            else
            {
                lbl_errorUser.Text = "Empty list. No books to remove";
            }
            lbx_display.Items.Clear();
        }

        private void btn_displayBook_Click(object sender, EventArgs e)
        {
            lbl_errorUser.Text = "";
            lbx_display.Items.Clear();
            if (books.Count > 0)
            {
                if (txt_bookID.Text == "")
                {
                    lbx_display.Items.Clear();
                    foreach (Book b in books)
                    {
                        lbx_display.Items.Add(b.ToString());
                    }
                }
                else if (txt_bookID.Text != "")
                {
                    lbx_display.Items.Clear();
                    Book bookToDisplay = null;
                    foreach (Book b in books)
                    {
                        if (b.BookId.Equals(Int32.Parse(txt_bookID.Text)))
                        {
                            bookToDisplay = b;
                            break;
                        }
                    }
                    if (bookToDisplay != null)
                    {
                        lbx_display.Items.Add(bookToDisplay.ToString());
                    }
                    else
                    {
                        lbl_errorUser.Text = "Book ID not found";
                    }
                }
                else
                {
                    lbl_errorUser.Text = "No books to display";
                }
            }
            else
            {
                lbl_errorUser.Text = "No books to display";
            }
        }

        private void btn_clearBook_Click(object sender, EventArgs e)
        {
            lbl_errorUser.Text = "";
            if (books.Count > 0)
            {
                books.Clear();
                lbx_display.Items.Clear();
            }
            else
            {
                lbl_errorUser.Text = "List already empty";
            }
        }

        private void btn_addCat_Click(object sender, EventArgs e)
        {
            lbl_errorUser.Text = "";
            if (string.IsNullOrWhiteSpace(txt_categoryID.Text) || string.IsNullOrWhiteSpace(txt_catName.Text) ||
                string.IsNullOrWhiteSpace(txt_catDesc.Text) || string.IsNullOrWhiteSpace(txt_catType.Text) ||
                string.IsNullOrWhiteSpace(txt_catDisplayName.Text))
            {
                lbl_errorUser.Text = "Please, insert information";
                return;
            }

            int categoryID;
            if (!Int32.TryParse(txt_categoryID.Text, out categoryID))
            {
                lbl_errorUser.Text = "Invalid category ID format";
                return;
            }

            Category newcategory = new Category(categoryID, txt_catName.Text, txt_catDesc.Text, txt_catType.Text, txt_catDisplayName.Text);

            if (!categories.Contains(newcategory))
            {
                categories.Add(newcategory);
                txt_categoryID.Clear();
                txt_catName.Clear();
                txt_catDesc.Clear();
                txt_catType.Clear();
                txt_catDisplayName.Clear();
                lbl_errorUser.Text = "Category added with success";
            }
            else
            {
                lbl_errorUser.Text = "Category already exists.";
            }
        }

        private void btn_removeCat_Click(object sender, EventArgs e)
        {
            lbl_errorUser.Text = "";
            if (categories.Count > 0)
            {
                if (txt_catName.Text != "")
                {
                    Category categoryToRemove = null;
                    foreach (Category c in categories)
                    {
                        if (c.CategoryName.Equals(txt_catName.Text, StringComparison.OrdinalIgnoreCase))
                        {
                            categoryToRemove = c;
                            break;
                        }
                    }
                    if (categoryToRemove != null)
                    {
                        categories.Remove(categoryToRemove);
                        txt_categoryID.Clear();
                        txt_catName.Clear();
                        txt_catDesc.Clear();
                        txt_catType.Clear();
                        txt_catDisplayName.Clear();
                        lbl_errorUser.Text = "Category removed with success";
                    }
                    else
                    {
                        lbl_errorUser.Text = "Category not found";
                    }
                }
                else
                {
                    lbl_errorUser.Text = "Please, insert a name";
                }
            }
            else
            {
                lbl_errorUser.Text = "Empty list. No categories to remove";
            }
            lbx_display.Items.Clear();
        }

        private void btn_displayCat_Click(object sender, EventArgs e)
        {
            lbl_errorUser.Text = "";
            lbx_display.Items.Clear();
            if (categories.Count > 0)
            {
                if (txt_catName.Text == "")
                {
                    lbx_display.Items.Clear();
                    foreach (Category c in categories)
                    {
                        lbx_display.Items.Add(c.ToString());
                    }
                }
                else if (txt_catName.Text != "")
                {
                    lbx_display.Items.Clear();
                    Category categoryToDisplay = null;
                    foreach (Category c in categories)
                    {
                        if (c.CategoryName.Equals(txt_catName.Text, StringComparison.OrdinalIgnoreCase))
                        {
                            categoryToDisplay = c;
                            break;
                        }
                    }
                    if (categoryToDisplay != null)
                    {
                        lbx_display.Items.Add(categoryToDisplay.ToString());
                    }
                    else
                    {
                        lbl_errorUser.Text = "Category name not found";
                    }
                }
                else
                {
                    lbl_errorUser.Text = "No categories to display";
                }
            }
            else
            {
                lbl_errorUser.Text = "No categories to display";
            }

        }

        private void btn_clearCat_Click(object sender, EventArgs e)
        {
            lbl_errorUser.Text = "";
            if (categories.Count > 0)
            {
                categories.Clear();
                lbx_display.Items.Clear();
            }
            else
            {
                lbl_errorUser.Text = "List already empty";
            }
        }
    }
}
