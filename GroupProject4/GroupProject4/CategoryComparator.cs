using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject4
{
    class CategoryComparator : IComparer<Category>
    {
        public int Compare(Category x, Category y)
        {
            return string.Compare(x.CategoryName, y.CategoryName, StringComparison.OrdinalIgnoreCase);
        }
    }
}
