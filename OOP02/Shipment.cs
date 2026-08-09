using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    internal class Shipment
    {
        private string trackingCode;
        private String description;
        private double weight;
        private double deliveryFee;
        private DeliveryAddress destination;
        #region Q4) :Apply proper encapsulation using private fields and public properties with the following rules:
        // a)TrackingCode cannot be null, empty, or whitespace.
        //public string TrackingCode
        //{
        //    get { return trackingCode; }
        //    set
        //    {
        //        if (! string.IsNullOrWhiteSpace(value))
        //        {
        //            trackingCode = value;

        //        }
        //    }
        //}

        //// b)Description cannot be null, empty, or whitespace.
        //public string Description
        //{
        //    get { return description; }
        //    set
        //    {
        //        if (!string.IsNullOrWhiteSpace(value))
        //        {
        //            description = value;
        //        }
        //    }
        //}

        //// c)Weight must be greater than 0.
        //public double Weight
        //{
        //    get { return weight; }
        //    set
        //    {
        //        if (value > 0)
        //        {
        //            weight = value;
        //        }
        //    }
        //}
        //// d)DeliveryFee must be greater than 0.
        //public double DeliveryFee
        //{
        //    get { return deliveryFee; }
        //    set
        //    {
        //        if (value > 0)
        //        {
        //            deliveryFee = value;
        //        }
        //    }
        //}
        #endregion

        #region Q5: Add the following properties:
        // a)TrackingCode: read-only from outside the class.
        public string TrackingCode
        {
            get { return trackingCode; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    trackingCode = value;
                }
            }
        }

        //b)Description: read/write property with validation.
        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }
            }
        }
        // c)Weight: read/write property with validation.
        public double Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }
        }
        // d)DeliveryFee: public getter and private setter.
        public double DeliveryFee
        {
            get { return deliveryFee; }
            private set
            {
                if (value > 0)
                {
                    deliveryFee = value;
                }
            }
        }

        //e)Destination: public read/write property.
        public DeliveryAddress Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        // f) EstimatedCost: calculated property that returns DeliveryFee + (Weight * 5).

        public double EstimatedCost => DeliveryFee + (Weight * 5);
        #endregion



        #region Q6: Add constructor overloading to Shipment:
        // a) The first constructor receives only trackingCode.
        // b)•The first constructor uses default values: Description = "Unknown", Weight = 1, DeliveryFee = 50, and a default destination.
        public Shipment(string trackingCode)
        {
            TrackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress("Unknown City", "Unknown Street", 0);
        }

        //c) The second constructor receives trackingCode, description, weight, deliveryFee, and destination.
        public Shipment(string trackingCode, string description, double weight, double deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }

        #endregion

        #region Q7:Add the following methods to Shipment:
        // A)UpdateDeliveryFee(decimal newFee): updates the fee only when newFee is greater than 0.
        public void UpdateDeliveryFee(double newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
        }

        // B)PrintShipment(): prints all shipment information, including the estimated cost.

        public void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} KG");
            Console.WriteLine($"Delivery Fee: {DeliveryFee} EGP");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }

        #endregion
    }
}
