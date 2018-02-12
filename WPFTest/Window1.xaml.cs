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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            //ucMbtn.AddHandler(MyBtn.SayHelloEvent, new RoutedEventHandler(SH));
        }

        private void UcMbtn_SayHello(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("I also can say it, Hello Mohamed Ahmed Hamed :)");
        }

        private void SH(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("I also can say it, Hello Mohamed :)");
        }

        private void ucMbtn_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
