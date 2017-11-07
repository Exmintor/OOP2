using CurrencyLibrary.Interfaces;
using CurrencyLibrary.USCurrency;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace WPFMidterm.ViewModels
{
    [Serializable]
    public class SaveableUSCurrencyRepo : USCurrencyRepo, ISerializable
    {
        public SaveableUSCurrencyRepo() : base()
        {

        }
        public SaveableUSCurrencyRepo(List<ICoin> coinList) : base(coinList)
        {

        }
        public SaveableUSCurrencyRepo(USCurrencyRepo repo)
        {
            this.Coins = repo.Coins;
        }
        public SaveableUSCurrencyRepo(SerializationInfo info, StreamingContext context)
        {
            Coins = (List<ICoin>)info.GetValue("CoinList", typeof(List<ICoin>));
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("CoinList", typeof(List<ICoin>));
        }

        public void SaveRepo(string filePath)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate);
            formatter.Serialize(stream, Coins);
        }

        public SaveableUSCurrencyRepo LoadRepo(string filePath)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(filePath, FileMode.Open);
            List<ICoin> coins = (List<ICoin>)formatter.Deserialize(stream);
            SaveableUSCurrencyRepo repo = new SaveableUSCurrencyRepo();
            repo.Coins = coins;
            return repo;
        }
    }
}
