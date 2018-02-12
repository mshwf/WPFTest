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
using WPFTest.Models;

namespace WPFTest
{
    /// <summary>
    /// Interaction logic for WndDependencyProperty.xaml
    /// </summary>
    public partial class WndDependencyProperty : Window
    {
        static Dictionary<string, Control> controls;

        public Book BookLog
        {
            get { return (Book)GetValue(BookLogProperty); }
            set { SetValue(BookLogProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BookLogProperty =
            DependencyProperty.Register("BookLog", typeof(Book), typeof(WndDependencyProperty), new PropertyMetadata(null, Changed));

        private static void Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var newVal = e.NewValue;
            var oldVal = e.OldValue;
            if (oldVal != null && newVal != null)
            {
                foreach (var newProperty in newVal.GetType().GetProperties())
                {
                    foreach (var oldProperty in oldVal.GetType().GetProperties())
                    {
                        if (newProperty.Name == oldProperty.Name)
                        {
                            if (controls.Keys.Any(x => x == newProperty.Name))
                            {
                                if (newProperty.GetValue(newVal) != (oldProperty.GetValue(oldVal)))
                                {
                                    var isValueExist = controls.TryGetValue(newProperty.Name, out Control ctrl);
                                    if (isValueExist && ctrl != null)
                                    {
                                        ctrl.Foreground = Brushes.Red;
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }

        public WndDependencyProperty()
        {
            InitializeComponent();
            controls = new Dictionary<string, Control>
            {
                { "Title", txtTitle },
                { "Color", txtColor },
                { "PagesCount", txtCount }
            };
            var book = new Book { Color = "Red", Title = "Haza Al-Masaa", PagesCount = "111" };
            BookLog = book;
            grdBook.DataContext = BookLog;
        }
        public int MyProperty { get; set; }
        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            BookLog = new Book { Color = "Pink", Title = "God is there", PagesCount = "111" };
            grdBook.DataContext = BookLog;
        }
    }
}
