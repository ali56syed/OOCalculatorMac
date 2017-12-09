using System;
namespace OOCalculatorMac
{
    public class Start
    {
        public static void Calculate()
        {
            Console.WriteLine("Enter the first number you want to equate");
            int x = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter the second number you want to equate");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("A. Add");
            Console.WriteLine("D. Divide");
            Console.WriteLine("S. Subtract");
            Console.WriteLine("M. Multiply");

            string function = Console.ReadLine();

            if (function == "A" || function == "a")
            {
                Compute.Add(x,y);
            }

            if (function == "D" || function == "d")
            {
                Compute.Divide(x,y);
            }

            if (function == "S" || function == "s")
            {
                Compute.Subtract(x,y);
            }

            if (function == "M" || function == "m")
            {
                Compute.Multiply(x,y);
            }
            return;
        }
    }
}
