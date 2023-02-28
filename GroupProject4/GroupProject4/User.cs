using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject4
{
    public class User : IComparable<User>
    {
        public User (int id, string firstName, string lastName, string email, string phone)
        {
            UserId = id;
            UserFirstName = firstName;
            UserLastName = lastName;
            UserEmail = email;
            UserPhone = phone;
        }

        public int UserId { get; set; }
        public string UserFirstName { get; set; }

        public string UserLastName { get; set; }

        public string UserEmail { get; set; }

        public string UserPhone { get; set; }

        public int CompareTo(User other)
        {
            return this.UserId.CompareTo(other.UserId);
        }
    }
}
