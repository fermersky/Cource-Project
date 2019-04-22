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
            new AddWorkerWindow().ShowDialog();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            var item = ((sender as Button)?.Tag as ListViewItem)?.DataContext;
            var itemId = (item as Workers)?.Firstname;
            MessageBox.Show(itemId);
        }
    }
}
