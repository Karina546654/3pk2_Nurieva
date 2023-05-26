using System;

namespace pz_8
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                IContact person = ContactFactory.CreateContact("person");
                person.Name = "Иванов Иван";
                person.Phone = "89878288280";
                person.Email = "ivan@mail.ru";
                person.Address = "Чкалова, 7";
                ((Person)person).Birthday = "10.10.2004";
                person.Display();
            }
        }
    }
}
