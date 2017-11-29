using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CurrencyWebApplication.Models
{
    public class HelloNinjectModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IHello>().To<TestHello>();
        }
    }
}