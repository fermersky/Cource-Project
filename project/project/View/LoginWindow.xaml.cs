using project.Model;
using System;
using System.Collections.Generic;
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
using System.Configuration;
using System.Data.SqlClient;

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
            string connString = ConfigurationManager.ConnectionStrings["StaffEntities"].ConnectionString;

            var conn = new SqlConnectionStringBuilder(connString);
            MessageBox.Show(conn.DataSource);
            MessageBox.Show(conn.InitialCatalog);
            MessageBox.Show(conn.DataSource);
            MessageBox.Show(conn.DataSource);

            /*using (var db = new StaffEntities())
            {
                var win = new MainWindow();
                win.Show();
            }*/
        }
    }
}
