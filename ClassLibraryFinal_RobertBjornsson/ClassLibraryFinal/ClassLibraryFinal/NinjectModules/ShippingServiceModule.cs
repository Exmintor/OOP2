using Moq;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFinal.NinjectModules
{
    public class ShippingServiceModule : NinjectModule
    {
       
        public ShippingServiceModule()
        {
            
        }

        public override void Load()
        {
            this.Bind<IDeliveryService>().To<UnclesTruck>();
            this.Bind<IShippingService>().To<DefaultShippingService>();
            this.Bind<IShippingVehicle>().To<Truck>();

            this.Bind<IShippingVehicle>().To<Plane>().WhenInjectedInto<AirExpress>();
            this.Bind<IShippingVehicle>().To<Truck>().WhenInjectedInto<UnclesTruck>();
            this.Bind<IShippingVehicle>().To<ShippingSnail>().WhenInjectedInto<SnailService>();

            this.Bind<AirExpress>().ToSelf();
            this.Bind<UnclesTruck>().ToSelf();
            this.Bind<SnailService>().ToSelf();
        }
    }
}
