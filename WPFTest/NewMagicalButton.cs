using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPFTest
{
    public class MyMagicalButton : ComboBox
    {

        public string SubTitle
        {
            get { return (string)GetValue(SubTitleProperty); }
            set { SetValue(SubTitleProperty, value); }
        }

        public static readonly DependencyProperty SubTitleProperty =
            DependencyProperty.Register("SubTitle", typeof(string), typeof(MyMagicalButton));

        public string DynamicText
        {
            get { return (string)GetValue(DynamicTextProperty); }
            set { SetValue(DynamicTextProperty, value); }
        }

        public static readonly DependencyProperty DynamicTextProperty =
            DependencyProperty.Register("DynamicText", typeof(string), typeof(MyMagicalButton));

    }
}
