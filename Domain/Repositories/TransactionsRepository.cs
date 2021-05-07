using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface TransactionsRepository
    {
        public Task<IEnumerable<Transactions>> GetTransactions();
        public Task<Transactions> GetTransactionById(int logId);
        public Task CreateOrEditTransactions(Log log);
        public Task DeleteTransaction(int logId);
    }
}
