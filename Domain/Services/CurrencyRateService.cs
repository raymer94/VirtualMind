using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface CurrencyRateService
    {
        public Task<string[]> GetCurrencyByName(string Name);
        public Task<string> ExchangeCurrencyRate(string Currency);
        //public void BuyCurrency();
    }
}
