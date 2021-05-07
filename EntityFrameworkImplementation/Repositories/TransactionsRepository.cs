using EntityFrameworkImplementation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkImplementation.Repositories
{
        public class TransactionsRepository
    {
        private readonly test2Context transaction = new test2Context();
        public List<Transaction> GetTransactions() {

            return transaction.Transactions.ToList();
        }

        public Transaction GetTransactionById(int id)
        {
            var User = transaction.Transactions.Find(id);
            return User;
        }

        public void SaveTransaction(Transaction _transaction) {
            transaction.Add(_transaction);
        }        
    }
}
