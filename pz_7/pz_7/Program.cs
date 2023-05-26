using System;

namespace pz_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            Client client1 = new Client("Сэм");
            Client client2 = new Client("Кейт");

            Product1 product1 = new Product1("Продукт 1", 100, "Type1");
            Product2 product2 = new Product2("Продукт 2", 200, "Brand1");
            Product3 product3 = new Product3("Продукт 3", 300, "Material1");

            store.SaveOrder(product1, client1);
            store.SaveOrder(product2, client1);
            store.SaveOrder(product3, client2);

            foreach (string purchase in store.AllPurchases)
            {
                Console.WriteLine(purchase);
            }
        }
    }
}