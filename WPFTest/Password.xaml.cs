using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
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
            IntPtr passwordBSTR = default(IntPtr);
            string insecurePassword = "";
            passwordBSTR = Marshal.SecureStringToBSTR(pas.Password);
            insecurePassword = Marshal.PtrToStringBSTR(passwordBSTR);
        }
    }
}
