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

        public Transaction GetTransactionById(int id)
        {
            if (id == 0)
            {
                throw new Exception("Must provide a Transaction id");
            }

            var Transaction =  TransactionsRepository.GetTransactionById(id);
            if (Transaction == null)
            {
                throw new Exception("You must specify a valid Transaction id");
            }
            return Transaction;
        }
        public IEnumerable<Transaction> GetTransactions()
        {
            var transactions =  TransactionsRepository.GetTransactions();
            return transactions;
        }


        public bool CreateOrEditTransactions(Transaction transaction)
        {
             TransactionsRepository.CreateOrEditTransactions(transaction);
            throw new NotImplementedException();
        }

        public double GetTransactionsPerMonth(DateTime month) {
            var monthlyTransactions =  this.TransactionsRepository
                .GetTransactions(p => p.transactionDate == month && p.UserId == 2);

            var transactionsSumary = monthlyTransactions.Sum(x => x.Amount);

            return transactionsSumary;
        }
    }
}
