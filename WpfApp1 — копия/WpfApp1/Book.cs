using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Book
    {
        public string Name { get; set; }
        public string Year { get; set; }
        public string Author { get; set; }


        public Book (string name, string year, string auth)
        {
            Name = name;
            Year = year;
            Author = auth;
        }
    }
}
