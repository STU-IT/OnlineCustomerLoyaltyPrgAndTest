﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCustomerLoyaltyPrgAndTestNS
{
    public class Customer
    {
        public Guid Id { get; private set; }

        public Customer()
        {
            Id = new Guid();
        }
    }
}
