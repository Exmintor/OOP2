using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurrencyLibrary.Interfaces;

namespace CurrencyLibrary
{
    public class CurrencyRepo : ICurrencyRepo
    {
        public List<ICoin> Coins { get; protected set; }
        public CurrencyRepo()
        {
            Coins = new List<ICoin>();
        }
        public CurrencyRepo(List<ICoin> coinList)
        {
            Coins = coinList;
        }

        public string About()
        {
            //Not yet implemented
            //Not enough info from UML or Unit tests
            return null;
        }
        public void AddCoin(ICoin coin)
        {
            Coins.Add(coin);
        }
        public int GetCoinCount()
        {
            int numCoins = Coins.Count();
            return numCoins;
        }
        public virtual ICurrencyRepo MakeChange(double amount)
        {
            //Not yet implemented
            //Not enough info from UML or Unit tests
            //Different from CreateChange?
            return null;
        }

        public virtual ICurrencyRepo MakeChange(double amountTendered, double totalCost)
        {
            //Not yet implemented
            //Not enough info from UML or Unit tests
            //Different from CreateChange?
            return null;
        }

        public ICoin RemoveCoin(ICoin coin)
        {
            ICoin foundCoin = null;
            int index = 0;
            for(; index < Coins.Count; index++)
            {
                if(Coins[index].GetType() == coin.GetType())
                {
                    foundCoin = Coins[index];
                    break;
                }
            }
            Coins.RemoveAt(index);
            return foundCoin;
        }

        public double TotalValue()
        {
            double totalValue = 0;
            foreach(ICoin coin in Coins)
            {
                totalValue += coin.MonetaryValue;
            }
            return totalValue;
        }

        public virtual ICurrencyRepo Reduce()
        {
            return null;
        }
    }
}
