namespace OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1:
            //a) What is the difference between a class and a struct?
            // A class is a reference type, while a struct is a value type.
            //This means that when you create an instance of a class,
            //it is stored on the heap and accessed through a reference,
            //while an instance of a struct is stored on the stack and accessed directly.
            //Classes can have inheritance and polymorphism, while structs cannot.
            //Structs are typically used for small data structures that do not require inheritance or complex behavior.

            //b) Why are classes more suitable than structs for large applications?
            // Classes are more suitable for large applications because they support inheritance,
            // polymorphism, and encapsulation, which are essential for building complex systems.
            #endregion

            #region Q2:
            //a) Which class is the parent class?
            // Class Shipment is the parent class, and ExpressShipment is the child class.

            //b) Which class is the child class?
            // Class ExpressShipment is the child class, and Shipment is the parent class.

            //c) What members are inherited by ExpressShipment?
            // TrackingCode

            //d) Why is inheritance better than duplicating the same code in multiple classes?
            // Inheritance promotes code reusability and maintainability.
            // By defining common functionality in a parent class,
            // child classes can inherit and extend that functionality without duplicating code.
            // This reduces redundancy.
            #endregion

            #region Q5:
            // 1- Create a DeliveryCenter
                DeliveryCenter deliveryCenter = new DeliveryCenter();
            // 2- Ask the user to enter the name of the delivery center 
                Console.Write("Enter the name of the delivery center: ");
                deliveryCenter.CenterName = Console.ReadLine();
                Console.WriteLine();
                String city = default!, street = default!;
                Console.Write("Enter the city: ");
                city = Console.ReadLine();
                Console.Write("Enter the street: ");
                street = Console.ReadLine();
                int buildingNumber;
                Console.Write("Enter the building number: ");
                buildingNumber = int.Parse(Console.ReadLine());
                DeliveryAddress deliveryAddress = new DeliveryAddress(city, street , buildingNumber);

            // 3- Create one StandardShipment.
                String trackingCode = default!, description = default!;
                Console.Write("Enter the tracking code for StandardShipment: ");
                trackingCode = Console.ReadLine();
                Console.Write("Enter the description for StandardShipment: ");
                description = Console.ReadLine();
                double weight, cost;
                Console.Write("Enter the weight for StandardShipment: ");
                weight = double.Parse(Console.ReadLine());
                Console.Write("Enter the cost for StandardShipment: ");
                cost = double.Parse(Console.ReadLine());
                StandardShipment standardShipment = new StandardShipment(trackingCode, description, weight, cost, deliveryAddress);
            // 4- Create one ExpressShipment.
                Console.Write("Enter the tracking code for ExpressShipment: ");
                trackingCode = Console.ReadLine();
                Console.Write("Enter the description for ExpressShipment: ");
                description = Console.ReadLine();
                Console.Write("Enter the weight for ExpressShipment: ");
                weight = double.Parse(Console.ReadLine());
                Console.Write("Enter the cost for ExpressShipment: ");
                cost = double.Parse(Console.ReadLine());
                decimal extraFee;
                Console.Write("Enter the extra fee for ExpressShipment: ");
                extraFee = decimal.Parse(Console.ReadLine());
                ExpressShipment expressShipment = new ExpressShipment(trackingCode, description, weight, cost, deliveryAddress, extraFee);
            // 5- Create one InternationalShipment.
                Console.Write("Enter the tracking code for InternationalShipment: ");
                trackingCode = Console.ReadLine();
                Console.Write("Enter the description for InternationalShipment: ");
                description = Console.ReadLine();
                Console.Write("Enter the weight for InternationalShipment: ");
                weight = double.Parse(Console.ReadLine());
                Console.Write("Enter the cost for InternationalShipment: ");
                cost = double.Parse(Console.ReadLine());
                string originCountry;
                Console.Write("Enter the origin country for InternationalShipment: ");
                originCountry = Console.ReadLine();
                decimal customsFee;
                Console.Write("Enter the customs fee for InternationalShipment: ");
                customsFee = decimal.Parse(Console.ReadLine());
                InternationalShipment internationalShipment = new InternationalShipment(trackingCode, description, weight, cost, deliveryAddress, originCountry, customsFee);
            // 7- Add the shipments to the delivery center.
                if(deliveryCenter.AddShipment(standardShipment))
                {
                    Console.WriteLine("StandardShipment added successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to add StandardShipment.");
                }
                Console.WriteLine();
                if(deliveryCenter.AddShipment(expressShipment))
                {
                    Console.WriteLine("ExpressShipment added successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to add ExpressShipment.");
                }
                Console.WriteLine();
                if(deliveryCenter.AddShipment(internationalShipment))
                {
                    Console.WriteLine("InternationalShipment added successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to add InternationalShipment.");
                } 
                Console.WriteLine();
            // 8-Print all shipments.
                deliveryCenter.PrintAllShipments();
            //9-Search for a shipment using the existing tracking code indexer.
                Console.Write("Enter the tracking code to search for a shipment: ");
                string trackingCodeSearch = Console.ReadLine();
                if(deliveryCenter[trackingCodeSearch] != null)
                {
                    Console.WriteLine("Shipment found:");
                    deliveryCenter[trackingCodeSearch].PrintShipment();
                }
                else
                {
                    Console.WriteLine("Shipment not found.");
                }
            // 10-Remove one shipment using its tracking code.
                Console.Write("Enter the tracking code to remove a shipment: ");
                string trackingCodeRemove = Console.ReadLine();
                if(deliveryCenter.RemoveShipment(trackingCodeRemove))
                {
                    Console.WriteLine("Shipment removed successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to remove shipment.");
                }
            //  11-Print the remaining shipments.
                Console.WriteLine("Remaining shipments:");
                deliveryCenter.PrintAllShipments();

            #endregion
        }
    }
}
