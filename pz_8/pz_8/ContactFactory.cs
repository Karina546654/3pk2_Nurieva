using System;
using System.Collections.Generic;
using System.Text;

namespace pz_8
{
    public static class ContactFactory
    {
        public static IContact CreateContact(string category)
        {
            switch (category.ToLower())
            {
                case "person":
                    return new Person();
                case "company":
                    return new Company();
                case "school":
                    return new School();
                default:
                    throw new ArgumentException("Invalid category");
            }
        }
    }
}