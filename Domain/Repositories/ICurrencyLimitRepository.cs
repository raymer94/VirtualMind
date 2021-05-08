using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface ICurrencyLimitRepository
    {
        public Task<IEnumerable<CurrencyLimit>> GetCurrencyLimit();
        public Task<CurrencyLimit> GetCurrencyLimitById(int logId);
        public Task CreateOrEditCurrencyLimit(CurrencyLimit log);
        public Task DeleteCurrencyLimit(int logId);
    }
}
