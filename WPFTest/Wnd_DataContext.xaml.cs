using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Wnd_DataContext.xaml
    /// </summary>
    /// 
    public class Data
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public partial class Wnd_DataContext : Window
    {
        public ObservableCollection<Book> books;
        public Wnd_DataContext()
        {
            InitializeComponent();
            books = new ObservableCollection<Book>
            {
                new Book { Id = 10, IsPublished = true, Title = "Pro WPF", PagesCount = "310", Color="Black", IsChanged=false },
                new Book { Id = 20, IsPublished = true, Title = "Hundred Years of Solitude", PagesCount = "200", Color="Blue", IsChanged=false },
                new Book { Id = 30, IsPublished = false, Title = "Seeing Art", PagesCount = "510", Color="Red", IsChanged=false }
        };
            cmbBooks.ItemsSource = books;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            //txtId.Text = txtPCount.Text = txtTitle.Text = "";
            //chkPblshd.IsChecked = false;
            cmbBooks.SelectedItem = null;
        }

        private void btnAddBook_Click(object sender, RoutedEventArgs e)
        {
            Book book = new Book
            {
                Id = int.Parse(txtId.Text),
                Title = txtTitle.Text,
                PagesCount = txtPCount.Text,
                IsPublished = (bool)chkPblshd.IsChecked
            };
            books.Add(book);
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            //ChangeBinding(txtId, TextBox.TextProperty);
            //ChangeBinding(txtPCount, TextBox.TextProperty);
            //ChangeBinding(txtTitle, TextBox.TextProperty);
            //ChangeBinding(chkPblshd, CheckBox.IsCheckedProperty);

        }
        static void ChangeBinding(FrameworkElement f, DependencyProperty d)
        {
            //try
            //{
            //    BindingExpression be = f.GetBindingExpression(d);
            //    if (be != null)
            //    {
            //        Binding b = be.ParentBinding;
            //        BindingOperations.ClearBinding(f, d);
            //        b.Mode = BindingMode.OneWay;
            //        BindingOperations.SetBinding(f, d, b);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnChangeColor_Click(object sender, RoutedEventArgs e)
        {
            if (cmbBooks.SelectedItem is Book book)
                book.Color = "Orange";
        }

        private void chkNewChanged(object sender, RoutedEventArgs e)
        {
            if (chkNew.IsChecked == true)
                (cmbBooks.SelectedItem as Book).ReadOnly = true;
            else
                (cmbBooks.SelectedItem as Book).ReadOnly = false;
        }
    }
}
