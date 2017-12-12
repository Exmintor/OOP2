using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryFinal
{
    public abstract class MotorVehicle : IShippingVehicle
    {
        private uint topSpeed;
        public uint TopSpeed
        { get => topSpeed; set => topSpeed = value; }

        private uint maxDistancePerRefuel;
        public uint MaxDistancePerRefuel
        { get => maxDistancePerRefuel; set => maxDistancePerRefuel = value; }

        private uint maxWeight;
        public uint MaxWeight
        { get => maxWeight; set => maxWeight = value; }
    }

    
}