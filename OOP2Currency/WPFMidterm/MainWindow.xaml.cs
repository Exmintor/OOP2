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
using WPFMidterm.ViewModels;

namespace WPFMidterm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        USCurrencyRepo repo;

        public MainWindow()
        {
            InitializeComponent();
            repo = new USCurrencyRepo();
        }

        private void btnMakeChange_Click(object sender, RoutedEventArgs e)
        {
            MakeChangeWindow makeChange = new MakeChangeWindow(repo);
            makeChange.Show();
        }

        private void btnRepo_Click(object sender, RoutedEventArgs e)
        {
            RepoWindow repoWindow = new RepoWindow(repo);
            repoWindow.Show();
        }
    }
}
