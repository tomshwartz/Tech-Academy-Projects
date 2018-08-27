using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CsFinal.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public int Amount { get; set; }
        public int BusinessId { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Business Business { get; set; }
    }
}