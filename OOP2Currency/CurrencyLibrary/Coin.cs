using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurrencyLibrary.Interfaces;

namespace CurrencyLibrary
{
    public abstract class Coin : ICoin
    {
        public string Name { get; protected set; }
        public double MonetaryValue { get; protected set; }
        public int Year { get; protected set; }

        public Coin()
        {

        }

        public virtual string About()
        {
            return null;
        }

    }
}
