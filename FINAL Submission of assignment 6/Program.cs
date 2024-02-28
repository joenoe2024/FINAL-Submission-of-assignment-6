namespace FINAL_Submission_of_assignment_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintSeparator("vehicle1");
            // the line below is one way you can instantiate a class
            Vehicle vehicle1 = new Car();
            vehicle1.Brand = "tesla"; // you can access its properties to get/set its value by using the syntax <variable name>. <property>
            vehicle1.Model ="Model X";
            vehicle1.NumberOfWheels = 4;
            vehicle1.GetInfo();

            PrintSeparator("vehicle2");
            // if the class you are instantiating has a constructor that does not take any parameteres
            // then you can simplify the value asssignment using the syntax below 
            Vehicle vehicle2 = new Car()
            {
                Brand = "Toyota",
                Model = "supra",
                NumberOfWheels = 4,
            };
            vehicle2.GetInfo();
            Console.WriteLine("But you can still access my properties.");
            Console.WriteLine($"{vehicle2.Brand} {vehicle2.Model} {vehicle2.NumberOfWheels}");

            PrintSeparator("vehicle3");
            // if the class you are instantiating has constructor that takes parameters
            // then you can simplify the value assignment by passsing those values 
            // using the syntax below
            Vehicle vehicle = new Truck("GMC", "Sierra 1500 AT4", 6, 5);
            vehicle.GetInfo();

            PrintSeparator("vehicle4");
            // alternatively, you may use the syntac below, if for some reason your arguments are not in the spefific sequenece
            // use the syntax below
            Vehicle vehicle4 = new Truck(truckNumberOfWheels: 4, truckBrand: "Ford", truckModel: "f-150 Raptor", sizeOfTruckBed: 5);
            vehicle4.GetInfo();
        }
        ////<summary>
        ///just a section separator
        ///</summar>
        ///<param name="sectionName">String input for section name</param>
        static void PrintSeparator(string sectionName)
        {
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine($"\t{sectionName} Section");
            Console.WriteLine("".PadRight(50, '*'));
        }
    }
}
