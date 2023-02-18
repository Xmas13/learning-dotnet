namespace UnderstandingScope
{
    internal class Program
    {
        private static string k = "";
        
        static void Main(string[] args)
        {
            string j = "";
            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = i.ToString();
                }
                // Console.WriteLine(l); // Does not work because it exists outside the context of an if statement
            }
            // Console.WriteLine(i); // Will not be abled to access i since it is out of the scope of the code block
            Console.WriteLine("Outside of the for: " + j);
            Console.WriteLine("Outside of the for: " + k);

            HelperMethod();

            Car myCar = new Car();
            
            myCar.DoSomething();

            // myCar.helperMethod(); // This would not work because the helperMethod is not public

            Console.ReadLine();
        }

        static void HelperMethod()
        {
            Console.WriteLine("Value of k from the HelperMethod(): " + k);
        }
    }

    class Car
    {
        public void DoSomething()
        {
            Console.WriteLine(helperMethod());
        }

        private string helperMethod()
        {
            return "Hello World";
        }
    }
}