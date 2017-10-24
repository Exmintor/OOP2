using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.USCurrency
{
    public class Quarter : USCoin
    {
        public Quarter() : base(USCoinMintMark.D)
        {
            this.MonetaryValue = 0.25;
        }

        public Quarter(USCoinMintMark mintMark) : base(mintMark)
        {
            this.MonetaryValue = 0.25;
        }
    }
}
