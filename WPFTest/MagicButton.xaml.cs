﻿using System;
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
            ListBox list = new ListBox();
            ContentControl cc = new ContentControl();
            ToggleButton tg = new ToggleButton();
            //tg.IsChecked = true;
            Button btn = new Button();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //togg.IsChecked = true;

        }
    }
}
