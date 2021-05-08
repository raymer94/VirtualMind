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

        public Task<IEnumerable<Transactions>> GetTransactions();
        public Task<IEnumerable<Transactions>> GetTransactions(Expression<Func<Transactions, bool>> filter);
        public Task<Transactions> GetTransactionById(int id);
        public Task CreateOrEditTransactions(Transactions transaction);
    }
}
