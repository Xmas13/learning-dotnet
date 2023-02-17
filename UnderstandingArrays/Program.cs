namespace UnderstandingArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] numbers = new int[5];
            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;

            Console.Write(numbers[1]);
            Console.WriteLine(numbers.Length);
            */

            // More efficient way to create an array
            // int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };

            string[] names = new string[] { "Eddie", "Alex", "Michael", "David Lee" };

            /*
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            */

            /*
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            */

            string zig = "You can get what you want out of life" + 
                " if you help enough other people get what they want";

            char[] charArray = zig.ToCharArray();

            Array.Reverse(charArray);

            string charArray2 = new string(charArray);

            Console.WriteLine(charArray2);

            //foreach (char c in charArray)
            //{
            //    Console.WriteLine(c);
            //}

            Console.ReadLine();
        }
    }
}