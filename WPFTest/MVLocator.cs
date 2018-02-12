using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFTest
{
    class MVLocator
    {


        public static bool GetAutoEire(DependencyObject obj)
        {
            return (bool)obj.GetValue(AutoEireProperty);
        }

        public static void SetAutoEire(DependencyObject obj, bool value)
        {
            obj.SetValue(AutoEireProperty, value);
        }

        // Using a DependencyProperty as the backing store for AutoEire.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AutoEireProperty =
            DependencyProperty.RegisterAttached("AutoEire", typeof(bool), typeof(MVLocator), new PropertyMetadata(false, Changed));

        private static void Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var viewType = d.GetType();
            var vtName = viewType.FullName;
            var vmNam = vtName + "Model";
            var t = Type.GetType(vmNam);
            var myT = Activator.CreateInstance(t);
            ((FrameworkElement)d).DataContext = myT;
        }
    }
}
