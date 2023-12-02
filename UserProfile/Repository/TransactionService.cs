using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProfile.IRepository;
using UserProfile.Model;

namespace UserProfile.Repository
{
    public class TransactionService : ITransaction
    {
        public Transaction Add(Transaction t)
        {
            throw new NotImplementedException();
        }

        public List<Transaction> AllTransactions()
        {
            throw new NotImplementedException();
        }

        public Transaction ViewTransaction(int id)
        {
            throw new NotImplementedException();
        }
    }
}
