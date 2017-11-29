using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CurrencyWebApplication.Models
{
    public interface IHello
    {
        string Hello { get; }
        string SayHello();
    }
}