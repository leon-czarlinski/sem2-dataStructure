using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject4
{
    class UserComparator : IEqualityComparer<User>
    {
        bool IEqualityComparer<User>.Equals(User x, User y)
        {
            return x.UserId == y.UserId;
        }

        int IEqualityComparer<User>.GetHashCode(User obj)
        {
            return obj.UserId.GetHashCode();
        }
    }
}
