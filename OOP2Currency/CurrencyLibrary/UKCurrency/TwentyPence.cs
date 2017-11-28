using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.UKCurrency
{
    [Serializable]
    public class TwentyPence : UKCoin
    {
        public TwentyPence() : base()
        {
            this.MonetaryValue = 0.2;
        }

        public TwentyPence(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}