using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.UKCurrency
{

    [Serializable]
    public abstract class UKCoin : Coin
    {
        public UKCoin()
        {
            this.Year = DateTime.Now.Year;
            this.Name = $"UK {this.GetType().Name}";
        }

        public UKCoin(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }

        public override string About()
        {
            string aboutString = $"{this.Name} is from {this.Year}. It is worth £{this.MonetaryValue}.";
            return aboutString;
        }
    }
}
