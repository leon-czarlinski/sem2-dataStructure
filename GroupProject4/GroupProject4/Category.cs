using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject4
{
    public class Category : IComparable<Category>
    {               
        public Category (string categoryName, string description, string type)
        {
            CategoryName = categoryName;
            CategoryDescription = description;
            CategoryType = type; /*Fiction and Non-fiction*/
        }

        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public string CategoryType { get; set; }

        public int CompareTo(Category other)
        {
            return string.Compare(this.CategoryName, other.CategoryName, StringComparison.OrdinalIgnoreCase);
        }
    }
}
