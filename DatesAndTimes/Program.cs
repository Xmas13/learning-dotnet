namespace DatesAndTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;

            // Console.WriteLine(myValue.ToString());

            // Console.WriteLine(myValue.ToShortDateString()); // Month/Day/Year
            // Console.WriteLine(myValue.ToShortTimeString()); // 00:00 AM/PM
            // Console.WriteLine(myValue.ToLongDateString()); // Day, Month 00, 0000
            // Console.WriteLine(myValue.ToLongTimeString()); // 00:00:00 AM/PM

            // Add Days
            /*
            Console.WriteLine(myValue
                .AddDays(3)
                .ToLongDateString());
            */

            // Add Hours
            /*
            Console.WriteLine(myValue
                .AddHours(3)
                .ToLongTimeString());
            */

            // Subtract Days (works the same for hours)
            /*
            Console.WriteLine(myValue
                .AddDays(-3)
                .ToLongDateString());
            */

            // Console.WriteLine(myValue.Month);

            // DateTime myBirthday = new DateTime(1991, 12, 25);
            // Console.WriteLine(myBirthday.ToShortDateString());

            DateTime myBirthday = DateTime.Parse("12/25/1991");
            TimeSpan myAge = DateTime.Now - myBirthday;
            Console.WriteLine(myAge.TotalDays);

            Console.ReadLine();
        }
    }
}