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
using WpfTests;

namespace WPFTest
{
    /// <summary>
    /// Interaction logic for Wnd_Random.xaml
    /// </summary>
    public partial class Wnd_Random : Window
    {
        public Wnd_Random()
        {
            InitializeComponent();
            DataContext = new MagicButtonVM();
        }
    }
}
