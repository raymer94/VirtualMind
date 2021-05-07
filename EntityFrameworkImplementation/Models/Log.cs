using System;
using System.Collections.Generic;

#nullable disable

namespace EntityFrameworkImplementation.Models
{
    public partial class Log
    {
        public int Id { get; set; }
        public string LogDescription { get; set; }
        public string StackTrace { get; set; }
        public DateTime? Date { get; set; }
        public int? UserId { get; set; }
    }
}
