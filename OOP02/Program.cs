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
        }
    }
}
