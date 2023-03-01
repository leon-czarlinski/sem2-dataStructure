using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Design;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject4
{
    public class Category : IComparable<Category>
    {               
        public Category (int categoryID, string categoryName, string description, string type, string displayName)
        {
            CategoryID = categoryID;
            CategoryName = categoryName;
            CategoryDescription = description;
            CategoryType = type; /*Fiction and Non-fiction*/
            CategoryDisplayName = displayName;
        }

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public string CategoryType { get; set; }
        public string CategoryDisplayName { get; set; }

        public int CompareTo(Category other)
        {
            return string.Compare(this.CategoryName, other.CategoryName, StringComparison.OrdinalIgnoreCase);
        }
        public override string ToString()
        {
            return $"{CategoryID}: {CategoryName}, {CategoryDescription}, {CategoryType}. Abrev: {CategoryDisplayName}";
        }
    }
}
