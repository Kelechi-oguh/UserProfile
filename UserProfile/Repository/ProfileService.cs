using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProfile.IRepository;
using UserProfile.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UserProfile.Repository
{
    public class ProfileService : IProfile
    {
        List<Profile> _profile;  // = new List<User>();
        List<User> _user;  // = new List<User>();

        public ProfileService(List<Profile> profile, List<User> user) 
        { 
            _profile = profile; 
            _user = user;

            _user = new List<User>
            {
                new User()
                {
                    Id = 1,
                    Email = "johndoe@email.com"
                }
            };
        }
        public Profile Update(Profile p)
        {
            if (p != null)
            {
                if(_user != null && _user.Count() >0)
                {
                    var u = _user.Where(x => x.Id == p.UserId).FirstOrDefault();

                    p.UserId = u.Id;

                    _profile.Add(p);

                    return p;
                }
            }

            return null;
            
        }

        public Profile View(Profile profile)
        {
            throw new NotImplementedException();
        }
    }
}
