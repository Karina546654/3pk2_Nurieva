using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_11
{
    class Book
    {
        public string NameBook { get; set; }
        public string YearOfPublication { get; set; }
        public string Author { get; set; }
        public Book(string nameBook, string yearOfPublication, string author)
        {
            NameBook = nameBook;
            YearOfPublication = yearOfPublication;
            Author = author;
        }
    }
}