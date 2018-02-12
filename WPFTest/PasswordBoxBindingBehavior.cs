using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Interactivity;

namespace WPFTest
{
    public class PasswordBoxBindingBehavior : Behavior<PasswordBox>
    {

        protected override void OnAttached()
        {
            AssociatedObject.PasswordChanged += OnPasswordBoxValueChanged;
        }

        public SecureString Passwordy
        {
            get { return (SecureString)GetValue(PasswordyProperty); }
            set { SetValue(PasswordyProperty, value); }
        }

        public static readonly DependencyProperty PasswordyProperty =
         DependencyProperty.Register("Passwordy", typeof(SecureString),
        typeof(PasswordBoxBindingBehavior), new PropertyMetadata(null));

        private void OnPasswordBoxValueChanged(object sender, RoutedEventArgs e)
        {
            var binding = BindingOperations.GetBindingExpression(this, PasswordyProperty);
            if (binding != null)
            {
                PropertyInfo property = binding.DataItem.GetType().GetProperty(binding.ParentBinding.Path.Path);

                if (property != null)
                    property.SetValue(binding.DataItem, AssociatedObject.SecurePassword, null);

            }
        }
    }
}
