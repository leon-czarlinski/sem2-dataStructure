using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GroupProject4
{
    public class Book
    {
        public Book (int id, string title, int year, string author, double price)
        {
            BookId = id;
            BookTitle = title;
            BookYear = year;
            BookAuthor = author;
            BookPrice = price;
        }

        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public int BookYear { get; set; }
        public string BookAuthor { get; set; }
        public double BookPrice { get; set; }

        public override string ToString()
        {
            return $"{BookId}: {BookTitle}, {BookYear}, {BookAuthor}. Price: ${BookPrice}";
        }

    }
}
