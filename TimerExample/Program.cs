namespace TimerExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Timers.Timer timer = new System.Timers.Timer(2000);

            timer.Elapsed += Timer_Elapsed;
            timer.Elapsed += Timer_Elapsed1;

            timer.Start();

            Console.WriteLine("Press enter to remove the red event.");
            Console.ReadLine();
            timer.Elapsed -= Timer_Elapsed1;

            Console.ReadLine();
        }

        private static void Timer_Elapsed1(object? sender, System.Timers.ElapsedEventArgs e)
        {
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}", e.SignalTime);
        }

        private static void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}", e.SignalTime);
        }
    }
}