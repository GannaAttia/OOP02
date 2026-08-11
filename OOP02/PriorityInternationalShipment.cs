using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    internal class PriorityInternationalShipment :InternationalShipment
    {
        public PriorityInternationalShipment(string trackingCode, string description, double weight, double deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee)
            : base(trackingCode, description, weight, deliveryFee, destination , destinationCountry, customsFee)
        {
        }

        public sealed override void GenerateCustomReport()
        {
            Console.WriteLine("Priority International Shipment Report");
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Delivery Fee: {DeliveryFee:C}");
            Console.WriteLine($"Destination Address: {Destination}");
            Console.WriteLine($"Destination Country: {DestinationCountry}");
            Console.WriteLine($"Customs Fee: {CustomsFee:C}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost:C}");
        }
    }
}
