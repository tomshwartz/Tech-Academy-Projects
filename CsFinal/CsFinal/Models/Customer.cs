﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CsFinal.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}