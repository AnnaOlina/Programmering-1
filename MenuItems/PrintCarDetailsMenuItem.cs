using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering_1.MenuItems
{
    internal class PrintCarDetailsMenuItem
    {
        public static Car StartPrintCarDetailsMenu()
        {
            Console.WriteLine("Venligst giv mig oplysninger om din bil.\n");

            Car dinBil1 = new Car();
            dinBil1.PrintCarDetails();
            Console.WriteLine("Tak for oplysningerne om din bil.");

            Console.ReadKey();
            return dinBil1;
        }
    }
}
