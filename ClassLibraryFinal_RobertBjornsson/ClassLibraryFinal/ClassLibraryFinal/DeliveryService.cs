using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryFinal
{
    public abstract class DeliveryService : IDeliveryService
    {
        private IShippingVehicle shippingVehicle;
        public IShippingVehicle ShippingVehicle { get => shippingVehicle; set => shippingVehicle = value; }

        private double costPerRefuel;
        public double CostPerRefuel { get => costPerRefuel; set => costPerRefuel = value; }

        public DeliveryService(IShippingVehicle vehicle)
        {
            ShippingVehicle = vehicle;
        }

    }

    
}