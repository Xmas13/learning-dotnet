namespace ObjectLifetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car.myMethod();
            Car myCar = new Car();

            // myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";

            Car myOtherCar;
            myOtherCar = myCar;

            Car myThirdCar = new Car("Ford", "Escape", 2005, "White");


            Console.WriteLine("myOtherCar: {0} {1} {2} {3}", 
                myOtherCar.Make, 
                myOtherCar.Model, 
                myOtherCar.Year, 
                myOtherCar.Color);

            myOtherCar.Model = "98";

            Console.WriteLine("myCar: {0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            Console.WriteLine("myThirdCar: {0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            /*
            // This code would cause an error because it is trying to access an object that is no longer in memory.
            // We can remove objects from memory by setting them to null or by letting .net handle removing the object.
            // It is best practice for us to remove items from memory when they are no longer needed, because there isn't a deterministic way to know when .net will do it for us.
            myOtherCar = null;

            Console.WriteLine("myOtherCar: {0} {1} {2} {3}",
                myOtherCar.Make,
                myOtherCar.Model,
                myOtherCar.Year,
                myOtherCar.Color);
            */

            Console.ReadLine();
        }
    }

    internal class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        // Example of a constructor. We can use it to default properties or do things whenever a new instace of the object is created.
        // It is useful because it puts the object in a valid state upon creation. 
        // You could load from a configuration file, database, etc. in order to get those properties configured.
        // This is an instance member because it does not the static keyword
        public Car()
        {
            // this keyword is used to make sure it is only referencing the class. It is optional and not required.
            // this.Make = "Nissan";
            Make = "Nissan";
        }

        // Example of an overloaded constructor
        public Car(string make , string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        // Static methods do not need to be instantiated as an object in order to use them.
        // You can see above that I did not have to create a new car object in order to access this method.
        public static void myMethod()
        {
            Console.WriteLine("My Static method!");
            // This line would cause an error because static methods cannot access instance properties or objects in a class
            // static is useful if you have certain methods where it is true of all times for the object
            // or that your method does not care about the state of the application
            // Console.WriteLine(Make);
        }
        
    }
}