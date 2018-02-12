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
    /// Interaction logic for FrmListBoxDataTemplate.xaml
    /// </summary>
    public partial class FrmListBoxDataTemplate : Window
    {
        private Book book;
        public Book SelectedBook
        {
            get { return book; }
            set { book = value; }
        }
        public FrmListBoxDataTemplate()
        {
            InitializeComponent();
            DataContext = new List<Book>
            {
                new Book{Color= "red", Title="ReReads"},
                new Book{Color= "blue", Title="HolyT"},
                new Book{Color= "black", Title="Zigzaging"},
            };
        }
    }
}
