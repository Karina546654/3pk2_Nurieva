using System;
using System.Collections.Generic;
using System.Text;

namespace pz_8
{
    public interface IContact
    {
        string Name { get; set; }
        string Phone { get; set; }
        string Email { get; set; }
        string Address { get; set; }

        void Display();
    }
}