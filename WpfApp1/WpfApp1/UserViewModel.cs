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
    internal class UserViewModel
    {
        public ObservableCollection<User> Users { get; set; }

        private string _jsonFile = "users.json";

        public ICommand AddUsersCommand { get; set; }
       
        public UserViewModel()
        {
            Users = new ObservableCollection<User>();
            LoadUsers();

            AddUsersCommand = new RelayCommand(
                (parameter) =>
                {
                    var userRegistration = parameter as MainWindow;
                    string login = userRegistration.LogTB.Text;
                    string password = userRegistration.pass.Password;
                    string email = userRegistration.emailTB.Text;
                    if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password))
                    {
                        AddUser(login, password, email);
                        userRegistration.LogTB.Clear();
                        userRegistration.pass.Clear();
                        userRegistration.emailTB.Clear();

                    }
                });
        }

        private void SaveUsers()
        {
            var json = JsonConvert.SerializeObject(Users);
            File.AppendAllText(_jsonFile, json);
        }
        private void LoadUsers()
        {
            if (File.Exists(_jsonFile))
            {
                var json = File.ReadAllText(_jsonFile);
                var userList = JsonConvert.DeserializeObject<ObservableCollection<User>>(json);
                Users = userList;
            }
         
        }
        private void AddUser(string login, string pass, string email)
        {
            Users.Add(new User(login, pass, email));
            LoadUsers();
        }

    }
}
