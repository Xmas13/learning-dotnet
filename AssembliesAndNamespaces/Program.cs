using System.Net;

namespace AssembliesAndNamespaces
{
    internal class Program
    {
        private static string address;

        static void Main(string[] args)
        {
            string text = "A class is the most powerful data type in C#. Like a structure, " + 
                "a class defines the data and behavior of the data type. ";
            System.IO.File.WriteAllText(@"C:\Users\noelm\WriteText.txt", text); // includes the full namespace, but it is already imported by the template

            address = "https://raw.githubusercontent.com/ppy/osu/master/.gitignore";

            WebClient client = new WebClient();
            string reply = client.DownloadString(address);

            Console.WriteLine(reply);
            File.WriteAllText(@"C:\Users\noelm\osu_.gitignore", reply);

            System.Console.WriteLine("Hello, World!"); // System is the namespace for the Console Class
            Console.ReadLine();
        }
    }
}