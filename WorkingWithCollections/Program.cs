﻿using System.Collections;

namespace WorkingWithCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Car car1 = new Car();
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlas Supreme";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";
            car2.VIN = "A2";

            Book b1 = new Book();
            b1.Author = "Robert Tabor";
            b1.Title = "Microsoft .NET XML Web Services";
            b1.ISBN = "0-000-00000-0";
            */

            // ArrayLists are dynamically sized,
            // cool features sorting, remove items
            // No way to limit the type of data in the ArrayList
            /*
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(b1); // you can add whatever type you want, this may not be desired
            myArrayList.Remove(b1);
            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make); // We will get an exception because we have a book in our ArrayList
            }
            */

            // List<T>
            /*
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            // myList.Add(b1); // This will not run because we cannot add a book to a car list
            foreach (Car car in myList)
            {
                Console.WriteLine(car.Model);
            }
            */

            // Dictionary<TKey, TValue>
            /*
             Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
             myDictionary.Add(car1.VIN, car1);
             myDictionary.Add(car2.VIN, car2);

             Console.WriteLine(myDictionary["A1"].Make);
            */

            // Object initializer syntax
            // No need for a Constructor
            /*
            Car car1 = new Car() 
            { 
              Make = "BMW", 
              Model = "750li", 
              VIN = "C3" 
            };

            Car car2 = new Car()
            {
                Make = "Toyota",
                Model = "4Runner",
                VIN = "D4"
            };
            */

            // Collection intializer
            List<Car> carList = new List<Car>()
            {
                new Car
                {
                    Make = "Oldsmobile",
                    Model = "Cutlas Supreme",
                    VIN = "E5"
                },
                new Car
                {
                    Make = "Nissan",
                    Model = "Altima",
                    VIN = "E6"
                }
            };

            // Dictionary Intializer
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>()
            {
                {"F5", new Car { Make = "VW", Model = "Bug", VIN = "F5"} }
            };

            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}