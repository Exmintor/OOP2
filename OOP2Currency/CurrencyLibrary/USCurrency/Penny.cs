using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.USCurrency
{
    [Serializable]
    public class Penny : USCoin
    {

        public Penny() : base(USCoinMintMark.D)
        {
            this.MonetaryValue = 0.01;
        }

        public Penny(USCoinMintMark mintMark) : base(mintMark)
        {
            this.MonetaryValue = 0.01;
        }

        public Penny(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
