using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurrencyLibrary.Interfaces;

namespace CurrencyLibrary.UKCurrency
{
    public class UKCurrencyRepo : CurrencyRepo
    {
        public UKCurrencyRepo() : base()
        {

        }
        public UKCurrencyRepo(List<ICoin> coinList) : base(coinList)
        {

        }

        public static List<ICoin> GetCoinList()
        {
            ICoin onePence = new OnePence();
            ICoin twoPence = new TwoPence();
            ICoin fivePence = new FivePence();
            ICoin tenPence = new TenPence();
            ICoin twentyPence = new TwentyPence();
            ICoin fiftyPence = new FiftyPence();
            ICoin onePoundCoin = new OnePoundCoin();
            ICoin twoPoundCoin = new TwoPoundCoin();

            List<ICoin> coinList = new List<ICoin>();
            coinList.Add(onePence);
            coinList.Add(twoPence);
            coinList.Add(fivePence);
            coinList.Add(tenPence);
            coinList.Add(twentyPence);
            coinList.Add(fiftyPence);
            coinList.Add(onePoundCoin);
            coinList.Add(twoPoundCoin);

            return coinList.OrderByDescending(c => c.MonetaryValue).ToList();
            //return coinList;
        }

        public static ICurrencyRepo CreateChange(double amount)
        {
            //Not yet implemented. Using MakeChange instead
            return null;
        }
        public static ICurrencyRepo CreateChange(double amountTendered, double totalCost)
        {
            //Not yet implemented
            //Not enough info from UML or Unit tests
            return null;
        }

        public override ICurrencyRepo MakeChange(double amount)
        {
            UKCurrencyRepo change = new UKCurrencyRepo();
            Decimal changeToMake = (Decimal)amount;

            List<ICoin> coinList = GetCoinList();
            foreach (UKCoin coin in coinList)
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
            UKCurrencyRepo change = new UKCurrencyRepo();
            Decimal changeToMake = (Decimal)amountTendered - (Decimal)totalCost;

            List<ICoin> coinList = GetCoinList();
            foreach (UKCoin coin in coinList)
            {
                while (changeToMake >= (Decimal)coin.MonetaryValue)
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
            foreach (UKCoin coin in Coins)
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