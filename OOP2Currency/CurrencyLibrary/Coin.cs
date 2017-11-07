using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurrencyLibrary.Interfaces;
using System.Runtime.Serialization;

namespace CurrencyLibrary
{
    [Serializable]
    public abstract class Coin : ICoin, ISerializable
    {
        public string Name { get; protected set; }
        public double MonetaryValue { get; protected set; }
        public int Year { get; protected set; }

        public Coin()
        {

        }
        public Coin(SerializationInfo info, StreamingContext context)
        {
            Name = (string)info.GetValue("Name", typeof(string));
            MonetaryValue = (double)info.GetValue("MonetaryValue", typeof(double));
            Year = (int)info.GetValue("Year", typeof(int));
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("MonetaryValue", MonetaryValue);
            info.AddValue("Year", Year);
        }

        public virtual string About()
        {
            return null;
        }

        public override bool Equals(object obj)
        {
            if(obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Coin coin = (Coin)obj;
            if(this.MonetaryValue == coin.MonetaryValue)
            {
                return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
