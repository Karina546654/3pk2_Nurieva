using System;

namespace pz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Origin origin = new Origin();
            Client client = new Client(origin);

            client.ClientDouble(7.41);
            client.ClientInt(10);
            client.ClientChar('a');
        }
    }
}