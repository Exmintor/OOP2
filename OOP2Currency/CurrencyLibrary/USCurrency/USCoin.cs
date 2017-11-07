﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.USCurrency
{
    //[Serializable]
    public enum USCoinMintMark { D, P, S, W }
    [Serializable]
    public abstract class USCoin : Coin
    {
        public USCoinMintMark MintMark { get; private set; }

        public USCoin() : this(USCoinMintMark.D)
        {

        }

        public USCoin(USCoinMintMark mintMark)
        {
            this.MintMark = mintMark;
            this.Year = DateTime.Now.Year;
            this.Name = $"US {this.GetType().Name}";
        }
        public USCoin(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            //MintMark = (USCoinMintMark)info.GetValue("MintMark", typeof(USCoinMintMark));
        }

        //public void GetObjectData(SerializationInfo info, StreamingContext context)
        //{
        //    info.AddValue("MintMark", MintMark);
        //    base.GetObjectData(info, context);
        //}

        public override string About()
        {
            string aboutString = $"{this.Name} is from {this.Year}. It is worth ${this.MonetaryValue}. It was made in {USCoin.GetMintNameFromMark(this.MintMark)}.";
            return aboutString;
        }

        public static string GetMintNameFromMark(USCoinMintMark mintMark)
        {
            switch(mintMark)
            {
                case USCoinMintMark.D:
                    return "Denver";
                case USCoinMintMark.P:
                    return "Philadelphia";
                case USCoinMintMark.S:
                    return "San Francisco";
                case USCoinMintMark.W:
                    return "West Point";
                default:
                    return null;
            }
        }
    }
}
