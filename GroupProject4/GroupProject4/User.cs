﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject4
{
    public class User
    {
        public User(int id, string firstName, string lastName, string email, string phone)
        {
            UserId = id;
            UserFirstName = firstName;
            UserLastName = lastName;
            UserEmail = email;
            UserPhone = phone;
            BorrowedBooks = new List<Book>();
        }

        public int UserId { get; set; }
        public string UserFirstName { get; set; }

        public string UserLastName { get; set; }

        public string UserEmail { get; set; }

        public string UserPhone { get; set; }

        public List<Book> BorrowedBooks { get; }

        public void AddBook(Book book)
        {
            if (book != null && !BorrowedBooks.Contains(book))
            {
                this.BorrowedBooks.Add(book);
            }
        }
        public void RemoveBook(Book book)
        {
            if (book != null && BorrowedBooks.Contains(book))
            {
                this.BorrowedBooks.Remove(book);
            }
        }

        public override string ToString()
        {
            return $"{UserId}: {UserFirstName} {UserLastName}, email: {UserEmail}, phone: {UserPhone}";
        }

        public override bool Equals(object obj)
        {
            User other = (User)obj;
            return this.UserId.Equals(other.UserId);
        }
    }
}
