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
using System.Windows.Media.Animation;
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
            if (isAuthorized())
            {
                var win = new MainWindow();
                win.Show();
            }
        }

        private bool isAuthorized()
        {
            var entityConn = new EntityConnectionStringBuilder(ConfigurationManager.ConnectionStrings["StaffEntities"].ConnectionString);
            var sqlConn = new SqlConnectionStringBuilder(entityConn.ProviderConnectionString);
            
            if (isAreasAreFiled())
            {
                if (serverTb.Text == sqlConn.DataSource
                    && databaseTb.Text == sqlConn.InitialCatalog
                    && loginTb.Text == sqlConn.UserID
                    && passTb.Password == sqlConn.Password)
                {
                    return true;
                }
                else
                {
                    ShowErrorMsg("Inputed data is wrong!");
                    return false;
                }
            } 
            else
            {
                ShowErrorMsg("Fill all areas!");
                return false;
            }
        }

        private bool isAreasAreFiled()
        {
            return !(string.IsNullOrEmpty(serverTb.Text)
                || string.IsNullOrEmpty(databaseTb.Text)
                || string.IsNullOrEmpty(loginTb.Text)
                || string.IsNullOrEmpty(passTb.Password));
        }

        private void ShowErrorMsg(string msg)
        {
            var anim = new ThicknessAnimationUsingKeyFrames();
            //anim.From = errorTb.Margin;
            errorTb.Text = msg;
            //anim.To = new Thickness(0, -20, 0, 0);
            anim.KeyFrames.Add(new LinearThicknessKeyFrame(new Thickness(0, -15, 0, 0), KeyTime.FromPercent(0.50)));
            anim.KeyFrames.Add(new LinearThicknessKeyFrame(new Thickness(0, -18, 0, 0), KeyTime.FromPercent(0.75)));
            anim.KeyFrames.Add(new LinearThicknessKeyFrame(new Thickness(0, -20, 0, 0), KeyTime.FromPercent(1.00)));
            anim.Duration = TimeSpan.FromSeconds(2);
            anim.AutoReverse = true;
            errorTb.BeginAnimation(TextBlock.MarginProperty, anim);
        }

        private void HideErrorMsg()
        {
            var anim = new ThicknessAnimation();
            anim.From = errorTb.Margin;
            anim.To = new Thickness(0, 60, 0, 0);
            anim.BeginTime = TimeSpan.FromSeconds(3);
            anim.Duration = TimeSpan.FromSeconds(0.3);
            errorTb.BeginAnimation(TextBlock.MarginProperty, anim);
        }
    }
}
