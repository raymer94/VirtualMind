using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomainBuilt_in.Services;
using Newtonsoft.Json;

namespace APIVirtualMind.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Produces("application/json")]
    public class CurrencyDay : ControllerBase
    {
        [HttpGet("{Currency}")]
        public async Task<IActionResult> GetCurrencyDay(string Currency)
        {              
            BuiltInCurrencyRateService Rate = new BuiltInCurrencyRateService();
            var RateCurrency = await Rate.ExchangeCurrencyRate(Currency);
            return Ok(RateCurrency);
        }

        //[HttpGet("{Currency}")]
        //public async Task<IActionResult> BuyCurrency(int UserId, float amount, string currency)
        //{
        //    var date = DateTime.Now;



        //    CreateOrEditTransactions Rate = new CreateOrEditTransactions();

        //    var BuyCurrencyByUser = await Rate.(UserId, amount, currency, date);
        //    // return Ok(RateCurrency);
        //}
    }
}
