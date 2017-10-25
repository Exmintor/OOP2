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
    public class RepoViewModel : BaseViewModel
    {
        USCurrencyRepo repository;

        public double TotalValue
        {
            get
            {
                return repository.TotalValue();
            }
        }

        public RepoViewModel(USCurrencyRepo repo)
        {
            this.repository = repo;
        }

        public void AddCoins(USCoin coin)
        {
            repository.AddCoin(coin);
            RaisePropertyChangedEvent("TotalValue");
        }
    }
}
