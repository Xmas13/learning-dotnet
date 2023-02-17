using System.Text;

namespace WorkingWithStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string myString = "My \"so-called\" life"; // escaping " == \"
            // string myString = "What if I need a\nnew line?"; // creating a new line! == \n
            // string myString = "Go to your C:\\ Drive"; // escaping \ == \\
            // string myString = @"Go to your C:\ Drive"; // @ symbol at the beginning of the line will interpret backslashes as \

            // string myString = String.Format("{0} != {1}, {0} = {0}", "First", "Second"); // Codes can be used multiple times!

            // string myString = String.Format("{0:C}", 123.45); // Format like currency (uses the computer's native language to do formatting)
            // string myString = String.Format("{0:N}", 1234567890); // Add commas and decimal points
            // string myString = String.Format("Percentage: {0:P}", .123); // Format as percentage
            // string myString = String.Format("{0:(###) ###-####}", 1234567890); // Custom formatting for numbers. If you include more than your formatting allows, it will overflow and put the remaining numbers on the first digit of your format.

            // string myString = " That summer we took threes across the board  ";

            // myString = myString.Substring(6);
            // myString = myString.Substring(6, 14);
            // myString = myString.ToUpper();
            // myString = myString.Replace(" ", "--");
            // myString = myString.Remove(6, 14);
            // myString = myString.Trim();

            /*
            string myString = "";
            for (int i = 0; i < 100; i++)
            {
                myString +=  "--" + i.ToString();
            }
            */

            StringBuilder myString= new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }

            Console.Write(myString);
            Console.ReadLine();
        }
    }
}