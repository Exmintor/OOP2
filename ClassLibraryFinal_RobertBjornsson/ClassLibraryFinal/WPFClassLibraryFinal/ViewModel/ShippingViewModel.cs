using ClassLibraryFinal;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFClassLibraryFinal.ViewModel
{
    public class ShippingViewModel : BaseViewModel
    {
        // The model
        private IShippingService shippingService;

        // The current destination zip code
        private uint destinationZip;
        public uint DestinationZip
        {
            get
            {
                return destinationZip;
            }
            set
            {
                destinationZip = value;
                // Make sure to update the model when a change is made in the UI
                UpdateModelDestination();
                RaisePropertyChangedEvent("DestinationZip");
            }
        }

        // For the combo box. Also reflects available delivery services
        private ObservableCollection<IDeliveryService> serviceForComboBox;
        public ObservableCollection<IDeliveryService> ServiceForComboBox
        {
            get
            {
                return serviceForComboBox;
            }
            set
            {
                serviceForComboBox = value;
            }
        }

        // Name of the currently selected service
        private string serviceName;
        public string ServiceName
        {
            get
            {
                return serviceName;
            }
            set
            {
                serviceName = value;
                // Make sure to update the model when a change is made in the UI
                UpdateService(serviceName);
                RaisePropertyChangedEvent("ServiceName");
            }
        }

        // Calculated number of refuels needed to complete the trip
        public uint NumRefuels
        {
            get
            {
                return shippingService.NumRefuels;
            }
        }

        // Calculated distance between Start Zip Code and Destination Zip Code
        public uint Distance
        {
            get
            {
                return shippingService.ShippingDistance;
            }
        }

        public ShippingViewModel(IShippingService ShippingService, AirExpress air, UnclesTruck truck, SnailService snail)
        {
            // Dependency Injection preferred for the model
            shippingService = ShippingService;
            // Declare variables for Combo box
            ServiceForComboBox = new ObservableCollection<IDeliveryService>(GetServicesForComboBox(air, truck, snail));
            // The combo box needs an initial value so that it is not empty when the application is started
            ServiceName = ServiceForComboBox.First().ToString();
            // Make sure that the UI is refreshed to reflect the initial destination zip code
            DestinationZip = shippingService.ShippingLocation.DestinationZipCode;
        }

        /// <summary>
        /// Updates the model to reflect a change in which delivery service has been selected
        /// </summary>
        /// <param name="serviceName">Name of the new service</param>
        private void UpdateService(string serviceName)
        {
            shippingService.DeliveryService = GetServiceFromName(serviceName);
            UpdateValues();
        }

        /// <summary>
        /// Updates the model to reflect a change in destination zip code
        /// </summary>
        private void UpdateModelDestination()
        {
            shippingService.ShippingLocation.DestinationZipCode = DestinationZip;
            UpdateValues();
        }

        /// <summary>
        /// Refreshes "Number of Refuels" and "Distance" after a change in the Delivery Service or the Delivery Zip Code
        /// </summary>
        private void UpdateValues()
        {
            RaisePropertyChangedEvent("NumRefuels");
            RaisePropertyChangedEvent("Distance");
        }

        /// <summary>
        /// Method for populating View service combo box
        /// </summary>
        /// <param name="air">AirExpress service</param>
        /// <param name="truck">UnclesTruck service</param>
        /// <param name="snail">SnailService service</param>
        /// <returns></returns>
        private List<IDeliveryService> GetServicesForComboBox(AirExpress air, UnclesTruck truck, SnailService snail)
        {
            AirExpress newAir = air;
            UnclesTruck newTruck = truck;
            SnailService newSnail = snail;

            List<IDeliveryService> services = new List<IDeliveryService>();
            services.Add(newAir);
            services.Add(newTruck);
            services.Add(newSnail);

            return services;
        }

        /// <summary>
        /// Look inside available delivery services for one that matches the given parameter
        /// </summary>
        /// <param name="name">Name of the service to find</param>
        /// <returns></returns>
        private IDeliveryService GetServiceFromName(string name)
        {
            var service = from serv in ServiceForComboBox where serv.ToString() == name select serv;
            return service.First();
        }
    }
}
