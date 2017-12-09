using System;

namespace OOCalculatorMac
{
    class MainClass
    {
        public static void Main()
        {
            Console.WriteLine("This is a calculator designed on the macbook pro");
            Console.WriteLine("Would you like to run this app? Y. Yes N. No");
            string inputSwitch = Console.ReadLine();

            if (inputSwitch == "Y" || inputSwitch == "y")
            {
                Start.Calculate();
                return;
            }
            if (inputSwitch == "N" || inputSwitch == "n")
            {
                Console.WriteLine("Thank you!");
                return;
            }
            else
            {
                Console.WriteLine("Please select either Y or N");
                Main();
            }


        }

    }
}
