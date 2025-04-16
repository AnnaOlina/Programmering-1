using Programmering_1.MenuItems;

namespace Programmering_1
{
    internal class Program
    {
        /* Lav et privat felt, hvor jeg kan gemme en bil
         * private static Car bil
         */
        // Klasseniveau variabel til at gemme biler
        private static List<Car> cars = new List<Car>();


        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("---Hovedmenu---\nTast relevant tal og tryk enter for at valg af nedenstående: \n");
                Console.WriteLine("1. Tilføj bil: \n");
                Console.WriteLine("2. Tilføj køretur til en bil: \n");
                //Console.WriteLine("1. Read Car Details.\n");
                //Console.WriteLine("2. Drive.\n");
                Console.WriteLine("3. IsPalindrome.\n");
                Console.WriteLine("4. Print Car Details.\n");
                Console.WriteLine("5. Print All Trips for a Car.\n");
                Console.WriteLine("6. Afslut programmet.\n");

                int værdi = int.Parse(Console.ReadLine());

                switch (værdi)
                {
                    case 1:
                        Console.WriteLine("\nReadCarDetails.");
                        ReadCarDetailsMenuItem.StartReadCarDetailsMenu();
                        break;

                    case 2:
                        Console.WriteLine("\nDrive");
                        DriveMenuItem.StartDriveMenu();
                        break;

                    case 3:
                        Console.WriteLine("\nIsPalindrome.");
                        IsPalindromeMenuItem.StartIsPalindromeMenu();
                        break;

                    case 4:
                        Console.WriteLine("\nPrint Car Details.");
                        PrintCarDetailsMenuItem.StartPrintCarDetailsMenu();
                        break;

                    case 5:
                        Console.WriteLine("\nPrint alle køreture for en bil.");
                        break;

                    case 6:
                        Console.WriteLine("\nAfslut programmet.");
                        return;

                    default:
                        Console.WriteLine(værdi + " er ikke en mulighed. Vælg et tal mellem 1 og 5.");
                        break;
                }

                Console.WriteLine("Tryk på en tast for at fortsætte...");
                Console.ReadKey();
            }
        }
    }
}
