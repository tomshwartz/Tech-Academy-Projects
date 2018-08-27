using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CsFinal.Models
{
    public class Business
    {
        public int BusinessId { get; set; }
        public string BusinessName { get; set; }
        public string Email { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}