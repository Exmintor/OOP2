using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.UKCurrency
{
    [Serializable]
    public class OnePence : UKCoin
    {
        public OnePence() : base()
        {
            this.MonetaryValue = 0.01;
        }

        public OnePence(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
