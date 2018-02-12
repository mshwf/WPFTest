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
    /// Interaction logic for Wnd_Styles.xaml
    /// </summary>
    public partial class Wnd_Styles : Window
    {
        public Wnd_Styles()
        {
            InitializeComponent();
            lstStyles.Items.Add("style1");
            lstStyles.Items.Add("style2");
            lstStyles.Items.Add("style3");
            lstStyles.Items.Add("style4");
        }

        private void lstStyles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var style = (Style)TryFindResource(lstStyles.SelectedValue.ToString());
            if (style != null)
                btnStylish.Style = style;
            else
                btnStylish.Style = null;
        }

        private void btnStylish_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
