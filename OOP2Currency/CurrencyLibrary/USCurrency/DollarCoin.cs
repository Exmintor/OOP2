using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.USCurrency
{
    public class DollarCoin : USCoin
    {
        public DollarCoin() : base(USCoinMintMark.D)
        {
            this.MonetaryValue = 1;
        }

        public DollarCoin(USCoinMintMark mintMark) : base(mintMark)
        {
            this.MonetaryValue = 1;
        }
    }
}
