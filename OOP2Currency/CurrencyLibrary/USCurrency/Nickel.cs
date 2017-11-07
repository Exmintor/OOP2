using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.USCurrency
{
    [Serializable]
    public class Nickel : USCoin
    {
        public Nickel() : base(USCoinMintMark.D)
        {
            this.MonetaryValue = 0.05;
        }

        public Nickel(USCoinMintMark mintMark) : base(mintMark)
        {
            this.MonetaryValue = 0.05;
        }

        public Nickel(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
