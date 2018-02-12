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
    /// Interaction logic for StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void Window2_Click(object sender, RoutedEventArgs e)
        {
            new Window2().Show();
        }

        private void Window1_Click(object sender, RoutedEventArgs e)
        {
            new Window1().Show();
        }

        private void MainWindow_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
        }

        private void AnimatedButton_window_Click(object sender, RoutedEventArgs e)
        {
            new AnimatedButton().Show();
        }

        private void Borders_KeyFrames_Click(object sender, RoutedEventArgs e)
        {
            new Wnd_Borders().Show();
        }

        private void Wnd_Styles_Click(object sender, RoutedEventArgs e)
        {
            new Wnd_Styles().Show();
        }

        private void WndCustomTemplateControls_Click(object sender, RoutedEventArgs e)
        {
            new CustomTemplateControls().Show();
        }

        private void WndDataContext_Click(object sender, RoutedEventArgs e)
        {
            new Wnd_DataContext().Show();

        }

        private void FrmDataContextChanged_Click(object sender, RoutedEventArgs e)
        {
            new FrmDataContextChanged().ShowDialog();
        }

        private void FrmMVLocator_Click(object sender, RoutedEventArgs e)
        {
            new SimpleView().Show();
        }

        private void FrmLisBox_Click(object sender, RoutedEventArgs e)
        {
            new FrmListBoxDataTemplate().ShowDialog();
        }

        private void FrmDP_Click(object sender, RoutedEventArgs e)
        {
            new WndDependencyProperty().Show();
        }

        private void PwdWindo_Click(object sender, RoutedEventArgs e)
        {
            new Password().Show();
        }

        private void wndBehavior_Click(object sender, RoutedEventArgs e)
        {
            new WndBehavior().ShowDialog();
        }

        private void wndAnimate_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
