using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurrencyLibrary.Interfaces;

namespace CurrencyLibrary.USCurrency
{
    public class USCurrencyRepo : CurrencyRepo
    {
        public USCurrencyRepo() : base()
        {

        }

        public static List<ICoin> GetCoinList()
        {
            ICoin nickel = new Nickel();
            ICoin penny = new Penny();
            ICoin dime = new Dime();
            ICoin quarter = new Quarter();
            ICoin halfDollar = new HalfDollar();
            ICoin dollar = new DollarCoin();

            List<ICoin> coinList = new List<ICoin>();
            coinList.Add(nickel);
            coinList.Add(penny);
            coinList.Add(dime);
            coinList.Add(quarter);
            coinList.Add(halfDollar);
            coinList.Add(dollar);

            return coinList.OrderByDescending(c => c.MonetaryValue).ToList();
            //return coinList;
        }

        public static ICurrencyRepo CreateChange(double amount)
        {
            USCurrencyRepo newRepo = new USCurrencyRepo();
            double currentAmount = amount;
            #region AddApropriateCoins
            while(currentAmount > 0)
            {
                if(currentAmount - 1 >= 0)
                {
                    DollarCoin dollar = new DollarCoin();
                    newRepo.AddCoin(dollar);
                    currentAmount -= dollar.MonetaryValue;
                }
                else if(currentAmount - 0.5 >= 0)
                {
                    HalfDollar halfDollar = new HalfDollar();
                    newRepo.AddCoin(halfDollar);
                    currentAmount -= halfDollar.MonetaryValue;
                }
                else if(currentAmount - 0.25 >= 0)
                {
                    Quarter quarter = new Quarter();
                    newRepo.AddCoin(quarter);
                    currentAmount -= quarter.MonetaryValue;
                }
                else if(currentAmount - 0.1 >= 0)
                {
                    Dime dime = new Dime();
                    newRepo.AddCoin(dime);
                    currentAmount -= dime.MonetaryValue;
                }
                else if(currentAmount - 0.05 >= 0)
                {
                    Nickel nickel = new Nickel();
                    newRepo.AddCoin(nickel);
                    currentAmount -= nickel.MonetaryValue;
                }
                else
                {
                    Penny penny = new Penny();
                    newRepo.AddCoin(penny);
                    currentAmount -= penny.MonetaryValue;
                }
            }
            #endregion
            return newRepo;
        }
        public static ICurrencyRepo CreateChange(double amountTendered, double totalCost)
        {
            //Not yet implemented
            //Not enough info from UML or Unit tests
            return null;
        }

        public override ICurrencyRepo MakeChange(double amount)
        {
            USCurrencyRepo change = new USCurrencyRepo();
            Decimal changeToMake = (Decimal)amount;

            List<ICoin> coinList = GetCoinList();
            foreach (USCoin coin in coinList)
            {
                while (changeToMake >= (Decimal)coin.MonetaryValue)
                {
                    change.AddCoin(coin);
                    changeToMake -= (Decimal)coin.MonetaryValue;
                }
            }
            return change;
        }

        public override ICurrencyRepo MakeChange(double amountTendered, double totalCost)
        {
            USCurrencyRepo change = new USCurrencyRepo();
            Decimal changeToMake = (Decimal)amountTendered - (Decimal)totalCost;

            List<ICoin> coinList = GetCoinList();
            foreach(USCoin coin in coinList)
            {
                while(changeToMake >= (Decimal)coin.MonetaryValue)
                {
                    change.AddCoin(coin);
                    changeToMake -= (Decimal)coin.MonetaryValue;
                }
            }
            return change;
        }

        public override ICurrencyRepo Reduce()
        {
            ICurrencyRepo reduced = this.MakeChange(this.TotalValue());
            return reduced;
        }
        public int CoinCount<T>()
        {
            int numCoins = 0;
            foreach (USCoin coin in Coins)
            {
                if (coin.GetType() == typeof(T))
                {
                    numCoins++;
                }
            }
            return numCoins;
        }  
    }
}
