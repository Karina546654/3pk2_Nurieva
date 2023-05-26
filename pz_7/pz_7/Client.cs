using System;
using System.Collections.Generic;
using System.Text;

namespace pz_7
{
    public class Client
    {
        public string Name { get; set; }
        public decimal AllPurchases { get; set; }

        public Client(string name)
        {
            Name = name;
        }
    }
}