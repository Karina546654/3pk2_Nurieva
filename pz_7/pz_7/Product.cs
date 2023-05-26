using System;
using System.Collections.Generic;
using System.Text;

namespace pz_7
{
    public abstract class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public virtual decimal GetDiscount(Client client)
        {
            decimal discount = client.AllPurchases >= 1000 ? 0.1M : 0;
            return discount;
        }
    }

    public class Product1 : Product
    {
        public string Type { get; set; }

        public Product1(string name, decimal price, string type) : base(name, price)
        {
            Type = type;
        }

        public override decimal GetDiscount(Client client)
        {
            decimal discount = base.GetDiscount(client);
            if (Type == "Type1")
            {
                discount += 0.05M;
            }
            return discount;
        }
    }

    public class Product2 : Product
    {
        public string Brand { get; set; }

        public Product2(string name, decimal price, string brand) : base(name, price)
        {
            Brand = brand;
        }
    }

    public class Product3 : Product
    {
        public string Material { get; set; }

        public Product3(string name, decimal price, string material) : base(name, price)
        {
            Material = material;
        }
    }
}