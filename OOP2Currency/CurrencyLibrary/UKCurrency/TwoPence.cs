using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.UKCurrency
{
    [Serializable]
    public class TwoPence : UKCoin
    {
        public TwoPence() : base()
        {
            this.MonetaryValue = 0.02;
        }

        public TwoPence(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}