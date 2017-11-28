using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.UKCurrency
{
    [Serializable]
    public class TwoPoundCoin : UKCoin
    {
        public TwoPoundCoin() : base()
        {
            this.MonetaryValue = 2.0;
        }

        public TwoPoundCoin(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}