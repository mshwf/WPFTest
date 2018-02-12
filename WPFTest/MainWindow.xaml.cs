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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public static string xcv = "";
        public MainWindow()
        {
            DependencyProperty.Register("Mshwf", typeof(ClassDP), typeof(Grid));

            InitializeComponent();
            //ucMbtn.AddHandler(MyBtn.SayHelloEvent, new RoutedEventHandler(SayHello));
            Polygon poly = new Polygon
            {
                Height = 100,
                Width = 100,
                StrokeThickness = 2,
                Stroke = Brushes.Red,
                Fill = Brushes.Green
            };
            grd.Children.Add(poly);
            Grid.SetColumn(poly, 0);
            Grid.SetRow(poly, 1);
            Grid.SetRowSpan(poly, 2);
        }

        private void SayHello(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("I can speak, Hello :)");
        }

        string _mouseActivity = string.Empty;
        private void Comm_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = false;
        }

        private void Ding_Click(object sender, RoutedEventArgs e)
        {


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello, Fuc*ing World");
        }

        private void BtnHello_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            this.Title = e.GetPosition(this).ToString();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnClickMe_Clicked(object sender, RoutedEventArgs e)
        {
            AddEventInfo(sender, e);
            MessageBox.Show(_mouseActivity, "Your Event Info");
            // Clear string for next round.
            _mouseActivity = "";
        }
        private void AddEventInfo(object sender, RoutedEventArgs e)
        {
            _mouseActivity += string.Format(
            "{0} sent a {1} event named {2}.\n", sender,
            e.RoutedEvent.RoutingStrategy,
            e.RoutedEvent.Name);
        }
        private void InnerBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("INNER BUTTON");
        }

        private void OuterEllipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            AddEventInfo(sender, e);
        }

        private void OuterEllipse_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            AddEventInfo(sender, e);
        }

        private void Button_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Button_PreviewMouseDown");
        }

        private void Btn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("btn_MouseDown");

        }

        private void StackPanel_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("StackPanel_PreviewMouseDown");

        }

        private void Grid_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Grid_PreviewMouseDown");
        }

        private void Btn_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("btn_PreviewMouseDown");
        }

        private void CommonClickHandler(object sender, RoutedEventArgs e)
        {
            FrameworkElement feSource = e.Source as FrameworkElement;
            switch (feSource.Name)
            {
                case "YesButton":
                    // do something here ...
                    break;
                case "NoButton":
                    // do something ...
                    break;
                case "CancelButton":
                    // do something ...
                    break;
            }
            e.Handled = true;
        }

        private void MyBtn_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("MyBtn_MouseDoubleClick");
        }

        private void Window_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Window_MouseDoubleClick");

        }

        private void Grd_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("grd_MouseDown");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new Window1().Show();
        }

        private void Window_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Window_PreviewMouseDown");

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Window_MouseDown");

        }

        private void ColorChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}
