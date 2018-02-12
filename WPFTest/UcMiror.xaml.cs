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
    /// Interaction logic for Miror.xaml
    /// </summary>
    public partial class Miror : UserControl
    {
        public Miror()
        {
            InitializeComponent();
        }


        public int Number
        {
            get { return (int)GetValue(NumberProperty); }
            set { SetValue(NumberProperty, value); }
        }

        public ValidateValueCallback He { get; private set; }

        // Using a DependencyProperty as the backing store for Number.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NumberProperty =
            DependencyProperty.Register("Number", typeof(int), typeof(Miror), new UIPropertyMetadata(1, Changed), Validate);

        private static bool Validate(object value)
        {
            return (int)value > 0 && (int)value < 50;
        }

        private static void Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Miror mrr = (Miror)d;
            mrr.lbl.Content = "New: " + e.NewValue.ToString();
            mrr.lbl2.Content = "Old: " + e.OldValue.ToString();
        }

        private void Txt_KeyDown(object sender, KeyEventArgs e)
        {
            He = TextBox.TextProperty.ValidateValueCallback;
            Number = int.Parse(txt.Text);
        }

      
    }
}
