using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLibrary.Interfaces
{
    public interface ICurrency
    {
        string Name { get; }
        double MonetaryValue { get; }

        string About();
    }
}
