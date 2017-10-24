using CurrencyLibrary.USCurrency;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFUSCurrency
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WPFUSCurrencyRepo repository;

        public MainWindow()
        {
            InitializeComponent();
            USCurrencyRepo repo = new USCurrencyRepo();
            repository = new WPFUSCurrencyRepo(repo);
            this.DataContext = repository;
        }

        private void btnPenny_Click(object sender, RoutedEventArgs e)
        {
            repository.Pennys++;
        }

        private void btnNickel_Click(object sender, RoutedEventArgs e)
        {
            repository.Nickels++;
        }

        private void btnDime_Click(object sender, RoutedEventArgs e)
        {
            repository.Dimes++;
        }

        private void btnQuarter_Click(object sender, RoutedEventArgs e)
        {
            repository.Quarters++;
        }

        private void btnHalfDollar_Click(object sender, RoutedEventArgs e)
        {
            repository.HalfDollars++;
        }

        private void btnDollar_Click(object sender, RoutedEventArgs e)
        {
            repository.Dollars++;
        }
    }
}
