using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.UKCurrency
{
    [Serializable]
    public class TenPence : UKCoin
    {
        public TenPence() : base()
        {
            this.MonetaryValue = 0.1;
        }

        public TenPence(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
