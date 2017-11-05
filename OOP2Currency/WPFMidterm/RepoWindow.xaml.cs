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
    /// Interaction logic for RepoWindow.xaml
    /// </summary>
    public partial class RepoWindow : Window
    {
        RepoViewModel viewModel;
        public RepoWindow(USCurrencyRepo repo)
        {
            InitializeComponent();
            viewModel = new RepoViewModel(repo);
        }

        private void ucRepo_Loaded(object sender, RoutedEventArgs e)
        {
            this.ucRepo.DataContext = viewModel;
            ucRepo.cbCoinName.SelectedIndex = 0;
        }
    }
}
