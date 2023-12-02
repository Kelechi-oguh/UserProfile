using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProfile.IRepository;
using UserProfile.Model;

namespace UserProfile.Repository
{
    public class UserService : IUser
    {
        List<User> _users;  // = new List<User>();

        public UserService(List<User> users) { _users = users; }
        public User Add(User user)
        {
            _users.Add(user);
            return user;
        }

        public List<User> AllUsers()
        {
            //make connection to db

            return _users;
        }

        public User Edit(User user)
        {
            if(_users != null && _users.Count > 0 )
            {
                return _users.Where(x => x.Id == user.Id).FirstOrDefault();
            }
            return null;
        }

        public User View(int userId)
        {
            if (_users != null && _users.Count > 0)
            {
                return _users.Where(x => x.Id == userId).FirstOrDefault();
            }
            return null;
        }
    }
}
