using project.Model;
using project.ViewModel;
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

namespace project.View
{
    /// <summary>
    /// Interaction logic for WorkerInfoWindow.xaml
    /// </summary>
    public partial class WorkerInfoWindow : Window
    {
        public WorkerInfoWindow()
        {
            InitializeComponent();
        }

        public WorkerInfoWindow(Workers worker)
        {
            InitializeComponent();
            this.DataContext = new WorkerInfoViewModel(worker);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
