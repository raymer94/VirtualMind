using Domain.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DomainBuilt_in.Services
{
    public class BuiltInCurrencyRateService : CurrencyRateService
    {
        static readonly HttpClient client = new HttpClient();
        public BuiltInCurrencyRateService()
        {
           

        }
        //public async Task<> BuyCurrency(int UserId, float amount, string currency)
        //{
            
        //}

        public async Task<string> ExchangeCurrencyRate(string Currency)
        {
            var valueCurrency = await GetCurrencyByName(Currency);

            if (valueCurrency[0] != "Error") { 
            var sale = Currency== "Real" 
                ?  (float.Parse(valueCurrency[0])/4).ToString() 
                : valueCurrency[0];

            var Buy = Currency == "Real"
                ? (float.Parse(valueCurrency[1]) / 4).ToString()
                : valueCurrency[1];

            var responseCurrency = new
            {
                Sale = sale,
                Buy = Buy
            };
                return JsonConvert.SerializeObject(responseCurrency);
            }

            return JsonConvert.SerializeObject(valueCurrency); 
        }

        public async Task<string[]> GetCurrencyByName(string Name)
        {
            try
            {
                if (Name == "Real" || Name == "DolarCanadiense") Name = "Dolar";
                var response = await client.GetAsync("https://www.bancoprovincia.com.ar/Principal/" + Name);
                string[] GetResponseString = JsonConvert.DeserializeObject<string[]>(response.Content.ReadAsStringAsync().Result);
                return GetResponseString;
            }
            catch (Exception)
            {
                string[] Ex = { "Error", "message:You must enter another type of currency" };
                return Ex;
            }            
        }
    }
}
