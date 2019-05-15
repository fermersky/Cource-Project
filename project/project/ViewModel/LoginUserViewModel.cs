using project.Helpers;
using project.Model;
using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;


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

        //

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
                        using (var db = new StaffContext())
                        {
                            var user = db.Users.Where(u => u.Lgn == Login).FirstOrDefault();

                            if (user == null) // user doesn't exist
                                ShowErrorMsg?.Invoke($"User with login \"{Login}\" not found!");
                            else
                            {
                                if (user.Pwd == Password)
                                    new MainWindow(Login).Show();
                                else
                                    ShowErrorMsg?.Invoke($"Uncorrect password for login \"{Login}\"");
                            }
                        }

                    }
                    else
                        ShowErrorMsg?.Invoke("Fill all areas!");
                }, obj => // can execute condition
                {
                    return !string.IsNullOrEmpty(Login);
                }));
            }
        }

        public Action<string> ShowErrorMsg { get; internal set; }
    }
}
