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
    /// Interaction logic for AnimatedButton.xaml
    /// </summary>
    public partial class AnimatedButton : Window
    {
        public AnimatedButton()
        {
            InitializeComponent();
            Closing += AnimatedButton_Closing;

        }

        private void AnimatedButton_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void rct_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void mBtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
        }

        private void mBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
