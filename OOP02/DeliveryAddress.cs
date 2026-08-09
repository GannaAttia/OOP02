using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    internal struct DeliveryAddress
    {
        private String City;
        private String Street;
        private int BuildingNumber;

        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            this.City = city;
            this.Street = street;
            this.BuildingNumber = buildingNumber;
        }

        public string GetFullAddress()
        {
            return $"{BuildingNumber} {Street}, {City}";
        }
    }
}
