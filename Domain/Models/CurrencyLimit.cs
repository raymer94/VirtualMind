using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class CurrencyLimit
    {
        public int Id { get; set; }
        public string CurrencyCode { get; set; }
        public float Limit { get; set; }
    }
}
