using System;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;

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
        protected override void OnContentRendered(EventArgs e)
        {
            string nspace = "WPFTest";

            var windows = (from t in Assembly.GetExecutingAssembly().GetTypes()
                           where t.IsClass && t.Namespace == nspace && t.BaseType == typeof(Window)
                           select t).Select(x => x.Name).ToList().OrderBy(x => x);

            foreach (var windowName in windows)
            {
                Button btn = new Button { Content = windowName };
                btn.Click += (s, r) =>
                {
                    var window = (Window)Application.LoadComponent(new Uri($"{windowName}.xaml", UriKind.Relative));
                    window.ShowDialog();
                };
                stk.Children.Add(btn);
            }
            base.OnContentRendered(e);
        }
    }
}
