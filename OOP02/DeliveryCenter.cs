using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    internal class DeliveryCenter
    {


        #region DeliveryCenter
        private string centerName = default!;

        public Driver Driver { get; set; }

        public string CenterName
        {
            get { return centerName; }
            set
            { 
                if(!string.IsNullOrWhiteSpace(value))
                {
                    centerName = value;
                }
            }
        }

        #endregion

        //1-he DeliveryCenter class should store up to 10 shipments using a private Shipment array.
        private Shipment[] shipments = new Shipment[20];
        //2- Add an integer indexer this[int index] to get or set a shipment by position.
        //3- If the integer index is invalid, the getter returns null and the setter does nothing.

        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                {
                    return shipments[index];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (index >= 0 && index < shipments.Length)
                {
                    shipments[index] = value;
                }
            }
        }

        // 4- Add a string indexer this[string trackingCode] that returns the first shipment with the matching tracking code.
        // 5-If no matching shipment is found, the string indexer returns null.
        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    Shipment shipment = shipments[i];
                    if (shipment != null && shipment.TrackingCode == trackingCode)
                    {
                        return shipments[i];
                    }
                }
                return null;
            }
        }

        // 6- Add bool AddShipment(Shipment shipment), which adds the shipment to the first empty position and returns true.
        // 7-Return false when the center is full.

        #region Methods 

        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }
            return false;
        }

        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                Shipment shipment = shipments[i];
                if (shipment != null && shipment.TrackingCode == trackingCode)
                {
                    shipments[i] = null;
                    return true;
                }
            }
            return false;
        }

        public void PrintAllShipments()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("Delivery Center");
            Console.WriteLine("========================================\n");

            if (Driver != null)
            {
                Console.WriteLine($"Driver : {Driver.FullName}\n");
            }

            Console.WriteLine("----------------------------------------\n");

            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null)
                {
                    shipments[i].PrintShipment();
                    Console.WriteLine("\n----------------------------------------\n");
                }
            }
        }

        #endregion
    }
}
