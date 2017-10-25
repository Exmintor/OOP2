using CurrencyLibrary.Interfaces;
using CurrencyLibrary.USCurrency;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public MakeChangeViewModel(USCurrencyRepo repo)
        {
            this.repository = repo;
        }

        public void MakeChange(double amount)
        {
            repository.MakeChange(amount);
            RaisePropertyChangedEvent("Coins");
        }
    }
}
