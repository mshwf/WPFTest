using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
    /// Interaction logic for _DynamicWindow.xaml
    /// </summary>
    public partial class _DynamicWindow : Window
    {
        StackPanel stack = new StackPanel { };
        public _DynamicWindow()
        {
            InitializeComponent();
            RetrieveAll();
            Content = new ScrollViewer { Content = stack, Padding = new Thickness(3) };
        }

        private void RetrieveAll()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            foreach (var window in assembly.GetTypes().Where(x => typeof(Window).IsAssignableFrom(x)))
            {
                var type = window.GetType();
                CreateButton(window);
            }
        }

        private void CreateButton(Type window)
        {
            Button btnShow = new Button { Margin = new Thickness(0, 0, 0, 2) };
            btnShow.Click += delegate
            {
                var obj = Activator.CreateInstance(window) as Window;
                obj.Show();
            };
            btnShow.Content = window.Name;
            stack.Children.Add(btnShow);
        }
    }
}
