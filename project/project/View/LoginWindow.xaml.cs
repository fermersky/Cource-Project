using project.Model;
using project.View;
using project.ViewModel;
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
            this.DataContext = new LoginViewModel();
        }


        public void ShowErrorMsg(string msg)
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
