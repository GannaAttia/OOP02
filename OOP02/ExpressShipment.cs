using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    internal class ExpressShipment : Shipment
    {
        #region ExpressShipment
        private decimal extraFee;

        public decimal ExtraFee
        {
            get { return extraFee; }
            set 
            { 
                if (value >= 0)
                {
                    extraFee = value;
                }
            }
        }

        public override decimal EstimatedCost
        {
            get { return base.EstimatedCost + ExtraFee; }
        }

        public ExpressShipment(string trackingCode, string description, double weight, double deliveryFee, DeliveryAddress destination, decimal extraFee)
        : base(trackingCode, description, weight, deliveryFee, destination)
            {
                ExtraFee = extraFee;
            }

        public override void PrintShipment()
        {
            base.PrintShipment();
            Console.WriteLine($"Extra Fee: {ExtraFee:C}");
        }

        #endregion
    }
}
