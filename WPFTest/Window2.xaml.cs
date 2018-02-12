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

namespace WPFTest
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void btnSetBorder_Click(object sender, RoutedEventArgs e)
        {
            //Border myBorder1 = new Border();
            //myBorder1.Background = Brushes.SkyBlue;
            //myBorder1.BorderBrush = Brushes.Red;
            //myBorder1.BorderThickness = new Thickness(1);
            txtHelloXaml.BorderBrush = Brushes.Red;
            txtHelloXaml.BorderThickness = new Thickness(2);

        }
    }
}
