using System;
using System.Collections.Generic;
using System.Text;

namespace pz_8
{
    public class Person : Contact
    {
        public string Birthday { get; set; }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"День Рождение: {Birthday}");
        }
    }
}