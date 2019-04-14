using project.Model;
using project.View;
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

namespace project
{
    /// <summary>
    /// Interaction logic for ConcreteSpec.xaml
    /// </summary>
    public partial class ConcreteSpec : Window
    {
        public ConcreteSpec()
        {
            InitializeComponent();
        }

        public ConcreteSpec(ConcreteSpecViewModel vm)
        {
            InitializeComponent();
            this.DataContext = vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new WorkerInfoWindow(WorkersListView.SelectedItem as Workers).Show();
        }

        private void WorkersListView_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var listView = sender as ListView;
            var worker = listView.SelectedItem as Workers;
            MessageBox.Show(worker.Firstname);
        }
    }
}
