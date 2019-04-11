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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace project.View
{
    /// <summary>
    /// Interaction logic for LoginUserWindow.xaml
    /// </summary>
    public partial class LoginUserWindow : Window
    {
        public LoginUserWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (isAuthorized())
            {
                MessageBox.Show("Ura");
            }
        }

        private bool isAuthorized()
        {
            if (isAreasAreFiled())
            {
                using (var db = new StaffEntities())
                {
                    var user = db.Users.Where(u => u.Lgn == loginTb.Text).FirstOrDefault();

                    if (user == null)
                        ShowErrorMsg($"User with login \"{loginTb.Text}\" not found!");
                    else
                    {
                        if (user.Pwd == passTb.Password.ToString())
                            return true;
                        else
                            ShowErrorMsg($"Uncorrect password for login \"{loginTb.Text}\"");
                    }
                }
            }
            else
                ShowErrorMsg($"Fill all areas!");
            return false;
        }

        private bool isAreasAreFiled()
        {
            return !(string.IsNullOrEmpty(loginTb.Text)
                || string.IsNullOrEmpty(passTb.Password));
        }

        private void ShowErrorMsg(string msg)
        {
            var anim = new ThicknessAnimationUsingKeyFrames();

            errorTb.Text = msg;

            anim.KeyFrames.Add(new LinearThicknessKeyFrame(new Thickness(0, -18, 0, 0), KeyTime.FromPercent(0.30)));
            anim.KeyFrames.Add(new LinearThicknessKeyFrame(new Thickness(0, -20, 0, 0), KeyTime.FromPercent(1.00)));
            anim.Duration = TimeSpan.FromSeconds(1);
            anim.AutoReverse = true;

            errorTb.BeginAnimation(TextBlock.MarginProperty, anim);
        }
    }
}
