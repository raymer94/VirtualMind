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
        private readonly CurrencyContext transactions = new CurrencyContext();

        public IEnumerable<Transaction> GetTransactions()
        {
            var transactionsList = transactions.Transactions.ToList();
            return transactionsList;
        }

        public IEnumerable<Transaction> GetTransactions(Expression<Func<Transaction, bool>> filter)
        {
            return transactions.Transactions.Where(filter).ToList();
        }
        public Transaction GetTransactionById(int id)
        {
            var User = transactions.Transactions.Find(id);
            return User;
        }

        public bool CreateOrEditTransactions(Transaction transaction) {
            transactions.Add(transaction);
            return true;
        }
    }
}
