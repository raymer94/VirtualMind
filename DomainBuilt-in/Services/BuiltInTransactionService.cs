using Domain.Models;
using Domain.Repositories;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainBuilt_in.Services
{
    class BuiltInTransactionService : TransactionsService
    {
        private TransactionsRepository TransactionsRepository;

        public BuiltInTransactionService(TransactionsRepository _TransactionsRepository)
        {
            this.TransactionsRepository = _TransactionsRepository;
        }

        public Task CreateOrEditTransactions(Log log)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteTransaction(int id)
        {
            if (id == 0)
            {
                throw new Exception("Must provide a Transaction id");
            }

            var CurrencyLimit = await TransactionsRepository.GetTransactionById(id);
            if (CurrencyLimit == null)
            {
                throw new Exception("You must specify a valid Transaction id");
            }
        }

        public async Task<Transactions> GetTransactionById(int id)
        {
            if (id == 0)
            {
                throw new Exception("Must provide a Transaction id");
            }

            var Transaction = await TransactionsRepository.GetTransactionById(id);
            if (Transaction == null)
            {
                throw new Exception("You must specify a valid Transaction id");
            }
            return Transaction;
        }

        public async Task<IEnumerable<Transactions>> GetTransactions()
        {
            var transactions = await TransactionsRepository.GetTransactions();
            return transactions;
        }
    }
}
