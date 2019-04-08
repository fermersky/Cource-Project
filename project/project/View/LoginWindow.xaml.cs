using project.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace project
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var entityConn = new EntityConnectionStringBuilder(ConfigurationManager.ConnectionStrings["StaffEntities"].ConnectionString);
            var sqlConn = new SqlConnectionStringBuilder(entityConn.ProviderConnectionString);

            MessageBox.Show(sqlConn.DataSource);
            MessageBox.Show(sqlConn.InitialCatalog);
            MessageBox.Show(sqlConn.UserID);
            MessageBox.Show(sqlConn.Password);

            /*using (var db = new StaffEntities())
            {
                var win = new MainWindow();
                win.Show();
            }*/
        }
    }
}
