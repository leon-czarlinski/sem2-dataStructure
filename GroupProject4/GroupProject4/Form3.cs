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
        SortedSet<Category> categories;
        HashSet<Book> books;
        Category currentCategory;

        Form1 form1;
        public Form3(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        public void Show(SortedSet<Category> categories, HashSet<Book> books)
        {
            this.categories = categories;
            this.books = books;
            this.Show();
        }

        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            this.form1.Show();
            this.Hide();
            this.clearAll();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            String categoryName = tbx_name.Text.Trim();
            if (categoryName.Equals(""))
            {
                lbl_SearchError.Text = "Please provide the category name";
                tbx_name.Focus();
                return;
            }
            this.currentCategory = this.findCategoryByName(categoryName);
            if (this.currentCategory == null)
            {
                lbl_SearchError.Text = "Category with name " + categoryName + " not found";
                tbx_name.Focus();
                return;
            }
            tbx_categoryid.Text = "" + this.currentCategory.CategoryID;
            tbx_description.Text = this.currentCategory.CategoryDescription;
            this.populateAssignedBooks();
            this.populateUnassignedBooks();
            lbl_SearchError.Text = "";
        }

        private void btn_assigned_book_Click(object sender, EventArgs e)
        {
            if (this.currentCategory == null)
            {
                lbl_SearchError.Text = "Please search the category first";
                tbx_name.Focus();
                return;
            }
            Book selectedBook = (Book)lbx_unassigned_books.SelectedItem;
            if (selectedBook != null)
            {
                this.currentCategory.AssignBook(selectedBook);
                selectedBook.Category = this.currentCategory;
                this.populateAssignedBooks();
                this.populateUnassignedBooks();
            }
        }

        private void btn_unassigned_book_Click(object sender, EventArgs e)
        {
            if (this.currentCategory == null)
            {
                lbl_SearchError.Text = "Please search the category first";
                tbx_name.Focus();
                return;
            }
            Book selectedBook = (Book)lbx_unassigned_books.SelectedItem;
            if (selectedBook != null)
            {
                this.currentCategory.UnassignBook(selectedBook);
                selectedBook.Category = null;
                this.populateAssignedBooks();
                this.populateUnassignedBooks();
            }
        }

        private void clearAll()
        {
            tbx_categoryid.Text = "";
            tbx_name.Text = "";
            tbx_description.Text = "";
            lbl_SearchError.Text = "";
            lbx_assigned_books.Items.Clear();
            lbx_unassigned_books.Items.Clear();
            this.currentCategory = null;
        }

        private void populateAssignedBooks()
        {
            lbx_assigned_books.Items.Clear();
            if (this.currentCategory.AssignedBooks.Count() <= 0)
            {
                // show error message
                return;
            }
            foreach (Book book in this.currentCategory.AssignedBooks)
            {
                lbx_assigned_books.Items.Add(book);
            }
        }

        private void populateUnassignedBooks()
        {
            lbx_unassigned_books.Items.Clear();
            IEnumerable<Book> availableBooks = this.books
                .Where((Book book) => book.Category == null)
               .Except(this.currentCategory.AssignedBooks);
            if (availableBooks.Count() <= 0)
            {
                // show error message
                return;
            }
            foreach (Book book in availableBooks)
            {
                lbx_unassigned_books.Items.Add(book);
            }
        }

        private Category findCategoryByName(String categoryName)
        {
            foreach (Category category in categories)
            {
                if (category.CategoryName.Equals(categoryName))
                {
                    return category;
                }
            }
            return null;
        }
    }
}
