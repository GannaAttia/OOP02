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

        StandardShipment(string trackingCode, string description, double weight, double deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }
        #endregion 
    }
}
