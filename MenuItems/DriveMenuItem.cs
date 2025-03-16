using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering_1.MenuItems
{
    public class DriveMenuItem
    {
        public static void StartDriveMenu()
        {
            Console.WriteLine("Opretter Aygo");
            Console.WriteLine();
            Car bil3 = new Car("Toyota", "Aygo", FuelType.Benzin, 'A', 2008, 180000, 21.0);
            bil3.PrintCarDetails();


            Trip tur1 = new Trip();
            tur1.Distance = 10;
            tur1.TripDate = DateTime.Now.Date;
            tur1.StartTime = (new DateTime()).AddHours(8);
            tur1.EndTime = (new DateTime()).AddHours(10);
            double fuelTur1 = tur1.CalculateFuelUsed(bil3.KmPrLiter);
            double TripPriceTur1 = tur1.CalculateTripPrice(bil3.KmPrLiter, 13.5);  // Man skal altid skrive double, når man vil lave en ny varieabel som f.eks. her.
            bil3.Drive(tur1);

            Trip tur2 = new Trip();
            tur2.ReadTripDetails();


            double fuelTur2 = tur2.CalculateFuelUsed(bil3.KmPrLiter);
            double TripPriceTur2 = tur2.CalculateTripPrice(bil3.KmPrLiter, 13.5);
            bil3.Drive(tur2);
            bil3.PrintAllTrips();
            bil3.PrintCarDetails();

            Console.WriteLine("Prisen for brændstof til tur1 køretur er: " + TripPriceTur1);
            Console.WriteLine("Prisen for brændstof til begge ture er: " + (TripPriceTur1 + TripPriceTur2));

            Console.ReadKey();
        }
    }
}
