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
        private ITransactionsRepository TransactionsRepository;

        public BuiltInTransactionService(ITransactionsRepository _TransactionsRepository)
        {
            this.TransactionsRepository = _TransactionsRepository;
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


        public Task CreateOrEditTransactions(Transactions transaction)
        {
            throw new NotImplementedException();
        }

        public async Task<double> GetTransactionsPerMonth(DateTime month) {
            var monthlyTransactions = await this.TransactionsRepository
                .GetTransactions(p => p.transactionDate == month && p.UserId == 2);

            var transactionsSumary = monthlyTransactions.Sum(x => x.Amount);

            return transactionsSumary;
        }



    }
}
