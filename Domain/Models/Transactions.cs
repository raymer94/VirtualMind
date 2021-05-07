using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Transactions
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CurrencyId { get; set; }

        public DateTime transactionDate { get; set; }

        public float Amount { get; set; }
    }
}
