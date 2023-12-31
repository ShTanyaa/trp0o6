﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using trpo6.Windows;

namespace trpo6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ElementsBindingWindow b = new ElementsBindingWindow();
            b.ShowDialog();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ResourceBindingWindow r = new ResourceBindingWindow();
            r.ShowDialog();
            this.Hide();
        }
    }
}
