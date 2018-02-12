using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfTests
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MagicButton : Window
    {
        public MagicButton()
        {
            InitializeComponent();
            var isChkd = togg.IsChecked;
            togg.SizeChanged += Togg_SizeChanged;
        }

        private void Togg_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //DoubleAnimation anim = new DoubleAnimation();
            //anim.From = e.PreviousSize.Width;
            //anim.To = e.NewSize.Width;
            //anim.Duration = new Duration(TimeSpan.FromMilliseconds(200));
            //Storyboard.SetTarget(anim, togg);
            //Storyboard.SetTargetProperty(anim, new PropertyPath(WidthProperty));
            //Storyboard st = new Storyboard();
            //st.Children.Add(anim);
            //st.Completed += St_Completed;
            //togg.SizeChanged -= Togg_SizeChanged;

            //st.Begin();
        }

        private void St_Completed(object sender, EventArgs e)
        {
            togg.SizeChanged += Togg_SizeChanged;
        }

        private void MagicalButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
