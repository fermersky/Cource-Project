using project.Helpers;
using project.Model;
using project.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;


namespace project.ViewModel
{
    class LoginUserViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        // 

        private string login;
        public string Login
        {
            get { return login; }
            set
            {
                NotifyPropertyChanged(nameof(Login));
                login = value;
            }
        }

        private RelayCommand loginCommand;
            
        public RelayCommand LoginCommand
        {
            get
            {
                return loginCommand ?? (loginCommand = new RelayCommand(pass => 
                {
                    string Password = (pass as PasswordBox).Password.ToString();

                    if (!string.IsNullOrEmpty(Password)) 
                    {
                        using (var db = new StaffEntities())
                        {
                            var user = db.Users.Where(u => u.Lgn == Login).FirstOrDefault();

                            if (user == null) // user doesn't exist
                                ((View.LoginUserWindow)Application.Current.MainWindow).ShowErrorMsg($"User with login \"{Login}\" not found!");
                            else
                            {
                                if (user.Pwd == Password)
                                    new MainWindow(Login).Show();
                                else
                                    ((View.LoginUserWindow)Application.Current.MainWindow).ShowErrorMsg($"Uncorrect password for login \"{Login}\"");
                            }
                        }
                    }
                    else
                        ((View.LoginUserWindow)Application.Current.MainWindow).ShowErrorMsg("Fill all areas!");
                }, obj => // can execute condition
                {
                    return !string.IsNullOrEmpty(Login);
                }));
            }
        }
    }
}
