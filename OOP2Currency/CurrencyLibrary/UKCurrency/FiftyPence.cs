using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.UKCurrency
{
    [Serializable]
    public class FiftyPence : UKCoin
    {
        public FiftyPence() : base()
        {
            this.MonetaryValue = 0.5;
        }

        public FiftyPence(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}