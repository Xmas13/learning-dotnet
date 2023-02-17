using Microsoft.VisualBasic;
using System.Runtime.InteropServices;

namespace HelperMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game");

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("In what city were you born?");
            string cityName = Console.ReadLine();


            DisplayResult(ReverseString(firstName), ReverseString(lastName), ReverseString(cityName));

            // This uses the overloaded method and adds the strings together with spaces to the overall single message parameter
            DisplayResult(ReverseString(firstName) + " " + ReverseString(lastName) + " " + ReverseString(cityName));

            Console.ReadLine();
        }

        private static string ReverseString(string s)
        {
            char[] chars = s.ToCharArray();
            Array.Reverse(chars);
            // Another way to do it
            // return String.Concat(chars);
            return new string(chars);
        }

        private static void DisplayResult(string reversedFirstName, string reversedLastName, string reversedCity)
        {
            Console.Write("Results: ");
            Console.Write(String.Format("{0} {1} {2}", reversedFirstName, reversedLastName, reversedCity));
        }



        // Example of an overloaded method. Where it is the same method, but it accepts a different amount of parameters or it can accept a different type of parameter
        private static void DisplayResult(string message)
        {
            Console.Write("Results: ");
            Console.Write(message);
        }

    }
}