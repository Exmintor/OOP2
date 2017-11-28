using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.UKCurrency
{
    [Serializable]
    public class FivePence : UKCoin
    {
        public FivePence() : base()
        {
            this.MonetaryValue = 0.05;
        }

        public FivePence(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}