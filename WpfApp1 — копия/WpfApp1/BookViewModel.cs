using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Input;
using System.Reflection.Metadata;

namespace WpfApp1
{
    internal class BookViewModel
    {
        public ObservableCollection<Book> Books { get; set; }

        private string _jsonFile = "book.json";

        public ICommand AddUsersCommand { get; set; }
       
        public BookViewModel()
        {
            Books = new ObservableCollection<Book>();
            LoadBooks();

            AddUsersCommand = new RelayCommand(
                (parameter) =>
                {
                    var bookRegistration = parameter as MainWindow;
                    string name = bookRegistration.NameTB.Text;
                    string year = bookRegistration.YearTB.Text;
                    string auth = bookRegistration.authTB.Text;
                    if (!string.IsNullOrEmpty(year) && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(auth))
                    {
                        AddBook(name, auth, year);
                        bookRegistration.NameTB.Clear();
                        bookRegistration.YearTB.Clear();
                        bookRegistration.authTB.Clear();

                    }
                });
        }

        private void SaveBooks()
        {
            var json = JsonConvert.SerializeObject(Books);
            File.AppendAllText(_jsonFile, json);
        }
        private void LoadBooks()
        {
            if (File.Exists(_jsonFile))
            {
                var json = File.ReadAllText(_jsonFile);
                var bookList = JsonConvert.DeserializeObject<ObservableCollection<Book>>(json);
                Books = bookList;
            }
         
        }
        private void AddBook(string name, string year, string auth)
        {
            Books.Add(new Book(name, year, year));
            LoadBooks();
        }

    }
}
