using System;
using System.Collections.Generic;
using System.Text;

namespace pz_8
{
    public class School : Contact
    {
        public string SchoolName { get; set; }
        public string Department { get; set; }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Школа: {SchoolName}");
            Console.WriteLine($"Номер: {Department}");
        }
    }
}