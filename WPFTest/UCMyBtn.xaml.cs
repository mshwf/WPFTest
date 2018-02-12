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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFTest
{
    /// <summary>
    /// Interaction logic for MyBtn.xaml
    /// </summary>
    public partial class MyBtn : UserControl
    {
        public MyBtn()
        {
            InitializeComponent();
        }
        public static readonly RoutedEvent SayHelloEvent = EventManager.RegisterRoutedEvent("SayHello", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(MyBtn));

        public event RoutedEventHandler SayHello
        {
            add { AddHandler(SayHelloEvent, value); }
            remove { RemoveHandler(SayHelloEvent, value); }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(SayHelloEvent, this));
                
        }
    }
}
