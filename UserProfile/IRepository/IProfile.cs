using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProfile.Model;

namespace UserProfile.IRepository
{
    public interface IProfile
    {
        Profile Update(Profile profile);
        Profile View(Profile profile);
    }
}
