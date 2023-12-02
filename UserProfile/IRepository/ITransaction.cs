using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProfile.Model;

namespace UserProfile.IRepository
{
    public interface ITransaction
    {
        Transaction Add(Transaction t);
        List<Transaction> AllTransactions();
        Transaction ViewTransaction(int id);
    }
}
