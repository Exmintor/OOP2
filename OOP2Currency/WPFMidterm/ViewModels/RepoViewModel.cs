 using CurrencyLibrary.Interfaces;
using CurrencyLibrary.USCurrency;
using Microsoft.Win32;
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

        private string filePath = string.Empty;
        public string FilePath
        {
            get
            {
                return filePath;
            }
            private set
            {
                filePath = value;
            }
        }

        private NewCommand newCommand;
        public ICommand NewCommand
        {
            get
            {
                return newCommand;
            }
        }
        private OpenCommand openCommand;
        public ICommand OpenCommand
        {
            get
            {
                return openCommand;
            }
        }
        private SaveCommand saveCommand;
        public ICommand SaveCommand
        {
            get
            {
                return saveCommand;
            }
        }

        public RepoViewModel(USCurrencyRepo repo)
        {
            this.repository = repo;
            addCoinCommand = new AddCoinCommand(AddCoins);
            coinsForComboBox = new ObservableCollection<ICoin>(USCurrencyRepo.GetCoinList());
            CoinName = coinsForComboBox.First().ToString();

            newCommand = new NewCommand(NewRepo);
            openCommand = new OpenCommand(OpenRepo);
            saveCommand = new SaveCommand(SaveRepo);
        }

        private void AddCoins()
        {
            for(int i = 0; i < coinNumber; i++)
            {
                repository.AddCoin(GetCoinByName(coinName));
            }
            RaisePropertyChangedEvent("TotalValue");
        }

        private void NewRepo()
        {
            repository = new USCurrencyRepo();
            RaisePropertyChangedEvent("TotalValue");
            filePath = string.Empty;
        }
        private void SaveRepo()
        {
            if(string.IsNullOrEmpty(FilePath))
            {
                SaveAsRepo();
            }
            else
            {
                SaveableUSCurrencyRepo repo = new SaveableUSCurrencyRepo(repository);
                repo.SaveRepo(FilePath);
            }
        }
        private void SaveAsRepo()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Repository Files(*.repo)|*.repo";

            if (dialog.ShowDialog() == true)
            {
                FilePath = dialog.FileName;
                SaveableUSCurrencyRepo repo = new SaveableUSCurrencyRepo(repository);
                repo.SaveRepo(FilePath);
            }
        }
        private void OpenRepo()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Repository Files(*.repo)|*.repo";

            if(dialog.ShowDialog() == true)
            {
                SaveableUSCurrencyRepo repo = new SaveableUSCurrencyRepo();
                FilePath = dialog.FileName;
                repository = repo.LoadRepo(FilePath);
                RaisePropertyChangedEvent("TotalValue");
            }
        }

        private ICoin GetCoinByName(string name)
        {
            var coin = from c in CoinsForComboBox where c.ToString() == name select c;
            return coin.First();
        }
    }
}
