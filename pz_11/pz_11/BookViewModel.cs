using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Input;

namespace pz_11
{
        internal class BookViewModel
        {
            public ObservableCollection<Book> Books { get; set; }
            private string _jsonFile = "books.json";

            public ICommand AddBookCommand { get; set; }

            public BookViewModel()
            {
                Books = new ObservableCollection<Book>();
                LoadBooks();

                AddBookCommand = new RelayCommand
                (
                    //execute
                    (parameter) =>
                    {
                        var bookSave = parameter as MainWindow;
                        string nameBook = bookSave.NameBookNB.Text;
                        string yearOfPublication = bookSave.YearOfPubYP.Text;
                        string author = bookSave.AuthorTB.Text;
                        if (!string.IsNullOrEmpty(nameBook) && !string.IsNullOrEmpty(yearOfPublication) && !string.IsNullOrEmpty(author))
                        {
                            AddBooks(nameBook, yearOfPublication, author);
                            bookSave.NameBookNB.Clear();
                            bookSave.YearOfPubYP.Clear();
                            bookSave.AuthorTB.Clear();
                        }
                    },
                    //canExecute
                    (parameter) => true
                );

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

            private void AddBooks(string nameBook, string yearOfPublication, string author)
            {
                Books.Add(new Book(nameBook, yearOfPublication, author));
                LoadBooks();
            }
        }
    }