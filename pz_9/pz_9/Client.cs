using System;
using System.Collections.Generic;
using System.Text;

namespace pz_9
{
    public class Client
    {
        private readonly Origin origin;

        public Client(Origin origin)
        {
            this.origin = origin;
        }

        public void ClientDouble(double value)
        {
            origin.OriginDouble(value);
        }

        public void ClientInt(int value)
        {
            origin.OriginInt(value * 2);
        }

        public void ClientChar(char value)
        {
            for (int i = 0; i < 5; i++)
            {
                origin.OriginChar(value);
            }
        }
    }
}

