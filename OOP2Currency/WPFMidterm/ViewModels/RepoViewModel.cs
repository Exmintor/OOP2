 using CurrencyLibrary.Interfaces;
using CurrencyLibrary.USCurrency;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFMidterm.Commands;

namespace WPFMidterm.ViewModels
{
    public class RepoViewModel : BaseViewModel
    {
        private USCurrencyRepo repository;

        private double totalValue;
        public double TotalValue
        {
            get
            {
                totalValue = repository.TotalValue();
                return totalValue;
            }
        }

        private int coinNumber;
        public int CoinNumber
        {
            get
            {
                return coinNumber;
            }
            set
            {
                coinNumber = value;
                RaisePropertyChangedEvent("CoinNumber");
            }
        }

        private string coinName;
        public string CoinName
        {
            get
            {
                return coinName;
            }
            set
            {
                coinName = value;
                RaisePropertyChangedEvent("CoinName");
            }
        }

        private AddCoinCommand addCoinCommand;
        public ICommand AddCoinCommand
        {
            get
            {
                return addCoinCommand;
            }
        }

        private ObservableCollection<ICoin> coinsForComboBox;
        public ObservableCollection<ICoin> CoinsForComboBox
        {
            get
            {
                return coinsForComboBox;
            }
            set
            {
                coinsForComboBox = value;
            }
        }

        public RepoViewModel(USCurrencyRepo repo)
        {
            this.repository = repo;
            addCoinCommand = new AddCoinCommand(AddCoins);
            coinsForComboBox = new ObservableCollection<ICoin>(USCurrencyRepo.GetCoinList());
            CoinName = coinsForComboBox.First().ToString();
        }

        private void AddCoins()
        {
            for(int i = 0; i < coinNumber; i++)
            {
                repository.AddCoin(GetCoinByName(coinName));
            }
            RaisePropertyChangedEvent("TotalValue");
        }

        private ICoin GetCoinByName(string name)
        {
            var coin = from c in CoinsForComboBox where c.ToString() == name select c;
            return coin.First();
        }
    }
}
