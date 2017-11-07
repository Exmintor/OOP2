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
    public class MakeChangeViewModel : BaseViewModel
    {
        private USCurrencyRepo repository;
        public ObservableCollection<ICoin> Coins
        {
            get
            {
                return new ObservableCollection<ICoin>(repository.Coins);
            }
        }

        private MakeChangeCommand makeChangeCommand;
        public ICommand MakeChangeCommand
        {
            get
            {
                return makeChangeCommand;
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

        private double moneyAmount;
        public double MoneyAmount
        {
            get
            {
                return moneyAmount;
            }
            set
            {
                moneyAmount = value;
                RaisePropertyChangedEvent("MoneyAmount");
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

        public MakeChangeViewModel(USCurrencyRepo repo)
        {
            this.repository = repo;
            makeChangeCommand = new MakeChangeCommand(MakeChange);
            saveCommand = new SaveCommand(SaveRepo);
        }

        private void MakeChange()
        {
            repository = (USCurrencyRepo)repository.MakeChange(MoneyAmount);
            RaisePropertyChangedEvent("Coins");
        }

        private void SaveRepo ()
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

            if(dialog.ShowDialog() == true)
            {
                FilePath = dialog.FileName;
                SaveableUSCurrencyRepo repo = new SaveableUSCurrencyRepo(repository);
                repo.SaveRepo(FilePath);
            }
        }
    }
}
