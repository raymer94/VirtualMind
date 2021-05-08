using Domain.Repositories;
using EntityFrameworkImplementation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkImplementation.Repositories
{
    public class TransactionsRepository: ITransactionsRepository
    {
        private readonly test2Context transaction = new test2Context();

        public Task<IEnumerable<Transaction>> GetTransactions()
        {
            var transactions = transaction.Transactions.ToList();
            return transactions;
        }

        public Task<IEnumerable<Transaction>> GetTransactions(Expression<Func<Transaction, bool>> filter)
        {
            return transaction.Transactions.Where(filter).ToList();
        }
        public Task<Transaction> GetTransactionById(int id)
        {
            var User = transaction.Transactions.Find(id);
            return User;
        }

        public Task CreateOrEditTransactions(Transaction _transaction)
        {
            transaction.Add(_transaction);
        }
    }
}
