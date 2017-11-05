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

        public MakeChangeViewModel(USCurrencyRepo repo)
        {
            this.repository = repo;
            makeChangeCommand = new MakeChangeCommand(MakeChange);
        }

        private void MakeChange()
        {
            repository = (USCurrencyRepo)repository.MakeChange(MoneyAmount);
            RaisePropertyChangedEvent("Coins");
        }
    }
}
