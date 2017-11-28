using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.UKCurrency
{
    [Serializable]
    public class OnePoundCoin : UKCoin
    {
        public OnePoundCoin() : base()
        {
            this.MonetaryValue = 1.0;
        }

        public OnePoundCoin(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
