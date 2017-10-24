using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.USCurrency
{
    public class Dime : USCoin
    {
        public Dime() : base(USCoinMintMark.D)
        {
            this.MonetaryValue = 0.1;
        }

        public Dime(USCoinMintMark mintMark) : base(mintMark)
        {
            this.MonetaryValue = 0.1;
        }
    }
}
