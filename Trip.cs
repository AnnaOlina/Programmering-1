using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering_1
{
    internal class Trip
    {
        private double _distance;   // Attributter, private.
        private DateTime _tripDate;
        private DateTime _startTime;
        private DateTime _endTime;

        public double Distance  // property/attribut med overskrevet get og set funktionalitet.
        {
            get { return _distance; }
            set
            {
                if (double.IsPositive(value))
                {
                    _distance = value;
                }
                else
                {
                    Console.WriteLine("Distance cannot be negative");
                }

            }
        }

        public DateTime TripDate
        {
            get { return _tripDate; }
            set { _tripDate = value; }
        }

        public DateTime StartTime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }

        public DateTime EndTime
        {
            get { return _endTime; }
            set { _endTime = value; }
        }

        public TimeSpan CalculateDuration()
        {
            TimeSpan duration = _endTime.Subtract(_startTime);
            return duration;
        }

        public double CalculateFuelUsed(double kmPrLiter)

        {
            /*double fuelUsed = 0;
            if (distance > 0)
            {
                fuelUsed = distance / kmPrLiter;
            }
            else 
            {
                Console.WriteLine("Fejl. Distance skal være over 0. Prøv igen.");
            }
            return fuelUsed;
            */

            /* Her tjekker koden først om køreturen er over 0 
             * inden den laver beregning af brændstofforbrug
             */
            if (Distance <= 0)
            {
                Console.WriteLine("Fejl. Distance skal være over 0. Prøv igen.");
                return 0;
            }

            if (kmPrLiter <= 0)
            {
                Console.WriteLine("Fejl. Km/l skal være over 0. Prøv igen.");
                return 0;
            }

            double fuelUsed = Distance / kmPrLiter;
            return fuelUsed;
        }

        public double CalculateTripPrice(double kmPrLiter, double literPrice)
        {
            /*Calculate Trip Price: En metode, CalculateTripPrice(double distance, double literPrice), 
             * der beregner prisen for en tur på en given distance. 
             * Tjek om bilens kmPerLiter ikke er 0 for at undgå en division med 0. 
             * Returner den samlede pris.
             */

            double tripPrice = 0;  // Lav lokale variabler på tripPrice og literUsed, fordi ellers eksisterer de ikke.
            double literUsed = 0;

            if (Distance > 0)
            {
                literUsed = Distance / kmPrLiter;
                tripPrice = literPrice * literUsed;
            }
            else
            {
                Console.WriteLine("Fejl. Distance skal være over 0. Prøv igen.");
            }

            return tripPrice;

        }

        public void ReadTripDetails()
        {
            Console.WriteLine("Hvor mange km skal du køre?");
            Distance = double.Parse(Console.ReadLine());

            Console.WriteLine("Oplys dato for køretur. Eksempel på dato: 28-02-25");
            string dato = Console.ReadLine();
            TripDate = DateTime.Parse(dato);

            Console.WriteLine("Oplys starttidspunkt for køreturen. Eksempelvis: 12:30");
            string start = Console.ReadLine();
            StartTime = DateTime.Parse(start);

            Console.WriteLine("Oplys sluttidspunkt for din køretur. Eksempelvis: 13:00");
            string slut = Console.ReadLine();
            EndTime = DateTime.Parse(slut);
        }

        public void PrintTripDetails()
        {
            Console.WriteLine("Turens afstand er: " + Distance);
            Console.WriteLine("Hvilken dato er køreturen: " + TripDate.ToString("dd:MM:yyyy")); // Her udvælges, at kun datoen fremgår, ikke klokkeslæt.
            Console.WriteLine("Hvornår startede køreturen? " + StartTime.ToString("HH:mm")); // Her udvælges, at kun klokkeslæt skal stå.
            Console.WriteLine("Hvornår sluttede køreturen? " + EndTime.ToString("HH:mm")); // Husk: Skriv klokkeslæt med kolon, ellers meldes der fejl.
        }
    }
}
