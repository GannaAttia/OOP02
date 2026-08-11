using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    internal class InternationalShipment : Shipment
    {
        #region InternationalShipment
        private string destinationCountry =default!;
        private decimal customsFee;

        public decimal CustomsFee
        {
            get { return customsFee; }
            set
            {
                if (value >= 0)
                {
                    customsFee = value;
                }
            }
        }

        public string DestinationCountry
        {
            get { return destinationCountry; }
            set
            { 
                if(!string.IsNullOrWhiteSpace(value))
                {
                    destinationCountry = value;
                }
            }
        }
        public override decimal EstimatedCost
        {
            get { return (decimal)base.EstimatedCost + customsFee; }
        }

        public InternationalShipment(string trackingCode, string description, double weight, double deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }

        public override void PrintShipment()
        {
            
            base.PrintShipment();
            Console.WriteLine($"Destination Country: {DestinationCountry}");
            Console.WriteLine($"Customs Fee: {CustomsFee:C}");
        }
        #endregion
        #region GenerateReport
        public virtual void GenerateCustomReport()
        {
            Console.WriteLine("International Shipment Report");
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Delivery Fee: {DeliveryFee:C}");
            Console.WriteLine($"Destination Address: {Destination}");
            Console.WriteLine($"Destination Country: {DestinationCountry}");
            Console.WriteLine($"Customs Fee: {CustomsFee:C}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost:C}");
        }
        #endregion
    }
}
