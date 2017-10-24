using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.USCurrency
{
    public class HalfDollar : USCoin
    {
        public HalfDollar() : base(USCoinMintMark.D)
        {
            this.MonetaryValue = 0.5;
        }

        public HalfDollar(USCoinMintMark mintMark) : base(mintMark)
        {
            this.MonetaryValue = 0.5;
        }
    }
}
