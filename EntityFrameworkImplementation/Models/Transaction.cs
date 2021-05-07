using System;
using System.Collections.Generic;

#nullable disable

namespace EntityFrameworkImplementation.Models
{
    public partial class Transaction
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string CurrencyId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public double? Amount { get; set; }
    }
}
