using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.USCurrency
{
    [Serializable]
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

        public HalfDollar(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
