using ScrapeLibrary;

namespace ScrapeClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Scrape myScrape = new Scrape();
            string value = myScrape.ScrapeWebpage("https://google.com");
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}