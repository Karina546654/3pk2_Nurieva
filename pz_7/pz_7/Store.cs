using System;
using System.Collections.Generic;
using System.Text;

namespace pz_7
{
    public class Store
    {
        public List<string> AllPurchases { get; set; }

        public Store()
        {
            AllPurchases = new List<string>();
        }

        public void SaveOrder(Product product, Client client)
        {
            decimal discount = product.GetDiscount(client);
            decimal priceWithDiscount = product.Price - product.Price * discount;
            string purchase = $"{DateTime.Now}: {client.Name} купил {product.Name} за {priceWithDiscount}";
            AllPurchases.Add(purchase);
            client.AllPurchases += priceWithDiscount;
        }
    }
}