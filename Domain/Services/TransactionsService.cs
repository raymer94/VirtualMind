using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface TransactionsService
    {
        public IEnumerable<Transaction> GetTransactions();
        public Transaction GetTransactionById(int logId);

        public double GetTransactionsPerMonth(DateTime month);
        public bool CreateOrEditTransactions(Transaction transaction);
    }
}
