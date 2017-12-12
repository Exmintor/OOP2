using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryFinal
{
    public class DefaultShippingService : IShippingService
    {

        public IShippingLocation ShippingLocation { get; protected set; }

        public uint ShippingDistance
        {
            get => CalculateShippingDistance();
        }

        public uint NumRefuels
        {
            get => CalculateNumRefuels();
        }

        public IDeliveryService DeliveryService { get; set; }

        List<IProduct> Products { get; set; }

        public DefaultShippingService(IDeliveryService Service,  List<IProduct> Products, IShippingLocation Location)
        {
            ShippingLocation = Location;
            this.Products = Products;
            DeliveryService = Service;
        }

        protected uint CalculateShippingDistance()
        {
            //terrible way to determine distance isn't real
            //even worse than originally thought because it underflows unless you cast it to an int beforehand
            return (uint)Math.Abs((int)this.ShippingLocation.DestinationZipCode - (int)this.ShippingLocation.StartZipCode);
        }

        private uint CalculateNumRefuels()
        {
            return (uint)this.ShippingDistance / (uint)this.DeliveryService.ShippingVehicle.MaxDistancePerRefuel;
        }

        public double ShippingCost()
        {
            return 0;
        }

        

        
    }
}