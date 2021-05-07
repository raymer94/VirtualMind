using System;
using System.Collections.Generic;

#nullable disable

namespace EntityFrameworkImplementation.Models
{
    public partial class CurrencyLimit
    {
        public int Id { get; set; }
        public string CurrencyCode { get; set; }
        public double Limit { get; set; }
    }
}
