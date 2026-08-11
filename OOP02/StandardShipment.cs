using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    internal class StandardShipment : Shipment
    {
        #region StandardShipment

        public StandardShipment(string trackingCode, string description, double weight, double deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }


        public override void PrintShipment()
        {
            base.PrintShipment();
        }
        public override decimal EstimatedCost => (decimal)(DeliveryFee + (Weight * 5));
        #endregion 
    }
}
