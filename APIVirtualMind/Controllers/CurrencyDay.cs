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

       // [HttpGet("{Currency}")]
        //public async Task<IActionResult> GetCurrencyDay(int UserId, float amount, string currency)
        //{
        //    BuiltInCurrencyRateService Rate = new BuiltInCurrencyRateService();
        //    var BuyCurrencyByUser = await Rate.BuyCurrency(UserId, amount, currency);
        //   // return Ok(RateCurrency);
        //}
    }
}
