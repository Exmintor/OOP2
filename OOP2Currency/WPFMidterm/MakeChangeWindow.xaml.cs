﻿using CurrencyLibrary.USCurrency;
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
using WPFMidterm.ViewModels;

namespace WPFMidterm
{
    /// <summary>
    /// Interaction logic for MakeChangeWindow.xaml
    /// </summary>
    public partial class MakeChangeWindow : Window
    {
        MakeChangeViewModel viewModel;
        public MakeChangeWindow(USCurrencyRepo repo)
        {
            InitializeComponent();
            viewModel = new MakeChangeViewModel(repo);
        }

        private void ucMakeChange_Loaded(object sender, RoutedEventArgs e)
        {
            this.ucMakeChange.DataContext = viewModel;
        }
    }
}
