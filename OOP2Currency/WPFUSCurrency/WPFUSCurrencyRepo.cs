using CurrencyLibrary.USCurrency;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUSCurrency
{
    class WPFUSCurrencyRepo : INotifyPropertyChanged
    {
        private USCurrencyRepo repository;

        public int Pennys
        {
            get
            {
                return repository.CoinCount<Penny>();
            }
            set
            {
                int amount = value - Pennys;
                for(int i = 0; i < amount; i++)
                {
                    Penny penny = new Penny();
                    repository.AddCoin(penny);
                }
                RaisePropertyChanged("Pennys");
                UpdateTotalValue();
            }
        }
        public int Nickels
        {
            get
            {
                return repository.CoinCount<Nickel>();
            }
            set
            {
                int amount = value - Nickels;
                for (int i = 0; i < amount; i++)
                {
                    Nickel nickel = new Nickel();
                    repository.AddCoin(nickel);
                }
                RaisePropertyChanged("Nickels");
                UpdateTotalValue();
            }
        }
        public int Dimes
        {
            get
            {
                return repository.CoinCount<Dime>();
            }
            set
            {
                int amount = value - Dimes;
                for (int i = 0; i < amount; i++)
                {
                    Dime dime = new Dime();
                    repository.AddCoin(dime);
                }
                RaisePropertyChanged("Dimes");
                UpdateTotalValue();
            }
        }
        public int Quarters
        {
            get
            {
                return repository.CoinCount<Quarter>();
            }
            set
            {
                int amount = value - Quarters;
                for (int i = 0; i < amount; i++)
                {
                    Quarter quarter = new Quarter();
                    repository.AddCoin(quarter);
                }
                RaisePropertyChanged("Quarters");
                UpdateTotalValue();
            }
        }
        public int HalfDollars
        {
            get
            {
                return repository.CoinCount<HalfDollar>();
            }
            set
            {
                int amount = value - HalfDollars;
                for (int i = 0; i < amount; i++)
                {
                    HalfDollar halfDollar = new HalfDollar();
                    repository.AddCoin(halfDollar);
                }
                RaisePropertyChanged("HalfDollars");
                UpdateTotalValue();
            }
        }
        public int Dollars
        {
            get
            {
                return repository.CoinCount<DollarCoin>();
            }
            set
            {
                int amount = value - Dollars;
                for (int i = 0; i < amount; i++)
                {
                    DollarCoin dollar = new DollarCoin();
                    repository.AddCoin(dollar);
                }
                RaisePropertyChanged("Dollars");
                UpdateTotalValue();
            }
        }
        public string TotalValue
        {
            get
            {
                return repository.TotalValue() + "$";
            }
        }

        public WPFUSCurrencyRepo(USCurrencyRepo repo)
        {
            repository = repo;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        private void UpdateTotalValue()
        {
            RaisePropertyChanged("TotalValue");
        }
    }
}
