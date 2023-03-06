using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject4
{
    class BookComparator : IEqualityComparer<Book>
    {
        bool IEqualityComparer<Book>.Equals(Book x, Book y)
        {
            return x.BookId == y.BookId;
        }

        int IEqualityComparer<Book>.GetHashCode(Book obj) 
        {
            return obj.BookId.GetHashCode();
        }
    }
}
