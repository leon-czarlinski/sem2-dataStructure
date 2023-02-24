using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject4
{
    public class Book 
    {
        public Book (int id, string title, int year, string author, string category)
        {
            BookId = id;
            BookTitle = title;
            BookYear = year;
            BookAuthor = author;
            BookCategory = category;
        }

        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public int BookYear { get; set; }
        public string BookAuthor { get; set; }
        public string BookCategory { get; set; }

        public int CompareTo (Book other)
        {
            return this.BookId.CompareTo (other.BookId);
        }

    }
}
