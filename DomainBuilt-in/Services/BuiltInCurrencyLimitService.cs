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
    class BuiltInCurrencyLimitService : CurrencyLimitService
    {
        private ICurrencyLimitRepository currencyLimitRepository;

        public BuiltInCurrencyLimitService(ICurrencyLimitRepository _currencyLimitRepository) 
        {
            this.currencyLimitRepository = _currencyLimitRepository;
        }

        public Task CreateOrEditCurrencyLimit(CurrencyLimit CurrencyLimit)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteCurrencyLimit(int id)
        {
            if (id == 0)
            {
                throw new Exception("Must provide a CurrencyLimit id");
            }

            var CurrencyLimit = await currencyLimitRepository.GetCurrencyLimitById(id);
            if (CurrencyLimit == null)
            {
                throw new Exception("You must specify a valid CurrencyLimit id");
            }
            
        }

        public Task<IEnumerable<CurrencyLimit>> GetCurrencyLimit()
        {
            throw new NotImplementedException();
        }

        public async Task<CurrencyLimit> GetCurrencyLimitById(int id)
        {
            if (id == 0)
            {
                throw new Exception("Must provide a CurrencyLimit id");
            }

            var CurrencyLimit = await currencyLimitRepository.GetCurrencyLimitById(id);
            if (CurrencyLimit == null)
            {
                throw new Exception("You must specify a valid CurrencyLimit id");
            }
            return CurrencyLimit;
        }
    }
}
