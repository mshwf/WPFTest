using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows;

namespace WPFTest
{
    class LoginVM
    {
        public string UserName { get; set; }
        public SecureString Password { get; set; }
    }
    /// <summary>
    /// Interaction logic for Password.xaml
    /// </summary>
    public partial class Password : Window
    {
        public Password()
        {
            InitializeComponent();
            DataContext = new LoginVM();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var pas = DataContext as LoginVM;
            if (pas.Password == null) return;
            IntPtr passwordBSTR = Marshal.SecureStringToBSTR(pas.Password);
            string insecurePassword = Marshal.PtrToStringBSTR(passwordBSTR);
        }
    }
}
