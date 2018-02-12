using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFTest
{
    class ShowInDynamicWindow
    {
        public static bool GetShowInDynamic(DependencyObject obj)
        {
            return (bool)obj.GetValue(ShowInDynamicProperty);
        }

        public static void SetShowInDynamic(DependencyObject obj, bool value)
        {
            obj.SetValue(ShowInDynamicProperty, value);
        }

        // Using a DependencyProperty as the backing store for ShowInDynamic.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ShowInDynamicProperty =
            DependencyProperty.RegisterAttached("ShowInDynamic", typeof(bool), typeof(ShowInDynamicWindow), new PropertyMetadata(true));
    }
}
