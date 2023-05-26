using System;
using System.Collections.Generic;
using System.Text;

namespace pz_8
{
    public class Company : Contact
    {
        public string CompanyName { get; set; }
        public string Position { get; set; }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Компания: {CompanyName}");
            Console.WriteLine($"Должность: {Position}");
        }
    }
}