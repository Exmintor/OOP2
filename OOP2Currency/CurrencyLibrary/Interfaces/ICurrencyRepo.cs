using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.Interfaces
{
    public interface ICurrencyRepo
    {
        List<ICoin> Coins { get; }

        string About();
        void AddCoin(ICoin coin);
        int GetCoinCount();
        ICurrencyRepo MakeChange(double amount);
        ICurrencyRepo MakeChange(double amountTendered, double totalCost);
        ICoin RemoveCoin(ICoin coin);
        double TotalValue();

    }
}
