using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFClassLibraryFinal.ViewModel;

namespace WPFClassLibraryFinal.NinjectModules
{
    public class ShippingViewmodelModule : NinjectModule
    {
        public ShippingViewmodelModule()
        {

        }

        public override void Load()
        {
            this.Bind<ShippingViewModel>().ToSelf();
        }
    }
}
