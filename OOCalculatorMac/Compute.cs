using System;
namespace OOCalculatorMac
{
    public class Compute
    {
        public static void Add(int x, int y)
        {
            Console.WriteLine(x + y);
            return;
        }

        public static void Subtract(int x, int y)
        {
            Console.WriteLine(x - y);
            return;
        }

        public static void Divide(int x, int y)
        {
            Console.WriteLine(x / y);
            return;
        }

        public static void Multiply(int x, int y)
        {
            Console.WriteLine(x * y);
            return;
        }
    }
}
