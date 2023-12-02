using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserProfile.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
    }

    public class Profile
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Address { get; set; }
        public string Phones { get; set; }
        public string FullName { get; set; }

    }

    public class Transaction
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public string TransactionType { get; set; }
    }

}
