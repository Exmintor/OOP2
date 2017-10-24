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
using CurrencyLibrary.USCurrency;

namespace WPFMakeChangeUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WPFUSCurrencyRepo viewRepo;
        public MainWindow()
        {
            InitializeComponent();
            USCurrencyRepo repo = new USCurrencyRepo();
            viewRepo = new WPFUSCurrencyRepo(repo);
            this.DataContext = viewRepo;
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            viewRepo.MakeChange(Convert.ToDouble(txtboxAmount.Text));
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
