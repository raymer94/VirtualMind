using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface ITransactionsRepository
    {
        public List<Transaction> GetTransactions();
        public IEnumerable<Transaction> GetTransactions(Expression<Func<Transaction, bool>> filter);
        public Transaction GetTransactionById(int id);
        public bool CreateOrEditTransactions(Transaction transaction);
    }
}
