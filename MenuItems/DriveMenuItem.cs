using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering_1.MenuItems
{
    public class DriveMenuItem
    {
        public static void StartDriveMenu()
        {
            Console.WriteLine("Opretter Aygo\n");
           
            /* Instantiere (lave) et Car-objekt (ellers findes det ikke)
             * Hvad er hvad på følgende linje, hvor Car-objekt instantieres?
             * - Car = klasse (her en datatype til vores variabel bil1)
             * - bil1 = instans (her en lokal variabel, en referencevariabel med bilklassen som reference)
             * - = betyder sæt (sæt bil1 til at være ny bil med disse oplysninger)
             * - new = operator 
             * - new Car() = her laver vi et nyt objekt ud af bilklassen/-skabelonen.
             * - Car() = (objekt af?) en Car-konstruktør med 7 parametre/argumenter.
            */
            Car bil1 = new Car("Toyota", "Aygo", FuelType.Benzin, 'A', 2008, 180000, 21.0); 
            
            /* Vi kalder metode ved at skrive navn på variablen, punktum, 
             * navn på metoden og parenteser.
             * Så vil vores program gå ind og udføre kroppen på metoden.
             */
            bil1.PrintCarDetails();

            // Her instantierer vi en køretur:
            Trip tur1 = new Trip();
            // Vi sætter distance og tidspunkt for køreturen:
            tur1.Distance = 10;
            tur1.TripDate = DateTime.Now.Date;
            tur1.StartTime = (new DateTime()).AddHours(8);
            tur1.EndTime = (new DateTime()).AddHours(10);

            // Her laver vi en beregning af turen (fuelUsed + tripPrice)
            double fuelTur1 = tur1.CalculateFuelUsed(bil1.KmPrLiter); // Her tages km/l fra bil1
            double TripPriceTur1 = tur1.CalculateTripPrice(bil1.KmPrLiter, 13.5);  // Man skal altid skrive double, når man vil lave en ny varieabel som f.eks. her.
            
            // Vi starter bilen (bil1) og kører en tur (bil1, tur1).
            bil1.TurnEngineOn();
            bil1.Drive(tur1);
            Console.WriteLine();
            
            // Her laver vi en ny køretur, tur2.
            Trip tur2 = new Trip();
            tur2.ReadTripDetails();
            Console.WriteLine();

            // Vi laver en beregning af tur2 med bil1:
            double fuelTur2 = tur2.CalculateFuelUsed(bil1.KmPrLiter);
            double TripPriceTur2 = tur2.CalculateTripPrice(bil1.KmPrLiter, 13.5);
            bil1.Drive(tur2);
            bil1.PrintAllTrips();
            bil1.PrintCarDetails();
            Console.WriteLine();

            Console.WriteLine("Prisen for brændstof til første køretur med din " + bil1.Model + " er: " + TripPriceTur1);
            Console.WriteLine("Prisen for brændstof til begge ture er: " + (TripPriceTur1 + TripPriceTur2));

            Console.WriteLine();

            Car bil2 = new Car("VW", "Up!", FuelType.Benzin, 'M', 2016, 212000, 20.5);
            bil2.Drive(tur1);

            Console.ReadKey();
        }
    }
}
