using System;
using System.Collections.Generic;
using System.Text;

namespace pz_8
{
    public abstract class Contact : IContact
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public virtual void Display()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Номер: {Phone}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Адрес: {Address}");
        }
    }
}