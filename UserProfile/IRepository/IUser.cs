using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProfile.Model;

namespace UserProfile.IRepository
{
    public interface IUser
    {
        User Add(User user);
        User Edit(User user);
        List<User> AllUsers();
        User View(int userId);
    }
}
