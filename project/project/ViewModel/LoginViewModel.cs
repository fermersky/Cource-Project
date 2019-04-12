using project.Helpers;
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
    class LoginViewModel : DependencyObject, INotifyPropertyChanged
    {
        public LoginViewModel(Window win)
        {
            this.ownedWindow = win as LoginWindow;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        private Window ownedWindow;

        //

        private string serverName;
        public string ServerName
        {
            get { return serverName; }
            set
            {
                NotifyPropertyChanged(nameof(ServerName));
                serverName = value;
            }
        }

        // 

        private string databseName;
        public string DatabseName
        {
            get { return databseName; }
            set
            {
                NotifyPropertyChanged(nameof(DatabseName));
                databseName = value;
            }
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

                    if (isAreasAreFiled(Password))
                    {
                        var entityConn = new EntityConnectionStringBuilder(ConfigurationManager.ConnectionStrings["StaffEntities"].ConnectionString);
                        var sqlConn = new SqlConnectionStringBuilder(entityConn.ProviderConnectionString);


                        if (ServerName == sqlConn.DataSource
                            && DatabseName == sqlConn.InitialCatalog
                            && Login == sqlConn.UserID
                            && Password == sqlConn.Password)
                        {
                            var win = new LoginUserWindow();
                            win.Show();
                        }
                        else
                        {
                            ((LoginWindow)Application.Current.MainWindow).ShowErrorMsg("Inputed data is wrong!");
                        }
                    }
                    else
                        ((LoginWindow)Application.Current.MainWindow).ShowErrorMsg("Fill all areas!");
                }));
            }
        }

        private bool isAreasAreFiled(string Pass)
        {
            return !(string.IsNullOrEmpty(ServerName)
                || string.IsNullOrEmpty(DatabseName)
                || string.IsNullOrEmpty(Login)
                || string.IsNullOrEmpty(Pass));
        }
    }

    
}
