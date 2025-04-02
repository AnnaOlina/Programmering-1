namespace Programmering_1
{
    public enum FuelType
    {
        Benzin,
        Diesel,
        Electric,
        Hybrid
    }

    internal class Car
    {
        //Jeg starter med at lave konstruktører. En med parametre og en uden.
        public Car(
           string brand,
           string model,
           FuelType fuelType,
           char gear,
           int year,
           int odometer,
           double kmPrLiter)
        {
            _brand = brand;
            _model = model;
            _fuelType = fuelType;
            _gear = gear;
            _year = year;
            _odometer = odometer;
            _kmPrLiter = kmPrLiter;
            _isEngineOn = true;
        }

        public Car(
          string brand,
          string model,
          int year,
          char gear)
          //int odometer,
          //double kmPrLiter)
        {
            _brand = brand;
            _model = model;
            _year = year;
            _gear = gear;
            //_odometer = odometer;
            //_kmPrLiter = kmPrLiter;
            //_isEngineOn = true;
        }

        public Car()
        {

        }

        /* Jeg laver flere attributter/felter i bilklassen Car. 
         * Første attribut er bilmærke (brand).
         * De sættes til "private", så man kun kan tilgå dem inde i denne her Car-klasse.
         * Navnet skrives med underscore_ for at skelne mellem private og public. 
         * Navn på public attribut skrives med stort begyndelsesbogstav.
         */

        private string _brand;              // Attribut, private.
        private string _model;
        private FuelType _fuelType;  // Her er typen en bestemt enum som oprettes længere nede i klassen.
        private char _gear;
        private int _year;
        private double _odometer;
        private double _kmPrLiter;
        private bool _isEngineOn;
        List<Trip> _trips = new List<Trip>();

        public string Brand // Det er en public property, hvor man har overskrevet get og set funktionaliteten.
        {
            get { return _brand; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _brand = value;
                }
                else
                {
                    Console.WriteLine("Name cannot be empty");
                }
            }
        }

        public string Model // Igen: property/attribut, med overskrevet get og set funktionalitet.
        {
            get { return _model; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _model = value;
                }
                else
                {
                    Console.WriteLine("Name cannot be empty");
                }
            }
        }

        public FuelType FuelType
        {
            get { return _fuelType; }
            set { _fuelType = value; }
        }

        public char Gear
        {
            get { return _gear; }
            set
            {
                if (!char.IsWhiteSpace(value))
                {
                    _gear = value;
                }
                else
                {
                    Console.WriteLine("Gear cannot be empty");
                }

            }
        }

        public int Year
        {
            get { return _year; }
            set
            {
                if (value >= 1900)
                {
                    _year = value;
                }
                else
                {
                    Console.WriteLine("Year cannot be empty");
                }

            }
        }

        public double Odometer
        {
            get { return _odometer; }
            set
            {
                if (value >= 0)
                {
                    _odometer = value;
                }
                else
                {
                    Console.WriteLine("Odometer cannot be empty");
                }

            }
        }

        public double KmPrLiter
        {
            get { return _kmPrLiter; }
            set
            {
                if (double.IsPositive(value))
                {
                    _kmPrLiter = value;
                }
                else
                {
                    Console.WriteLine("Km pr./liter cannot be empty");
                }

            }
        }

        public bool IsEngineOn
        {
            get { return _isEngineOn; }
            set { _isEngineOn = value; }
        }

        public void ReadCarDetails()
        {
            Console.WriteLine("Hvilket mærke er din bil?");
            Brand = Console.ReadLine();

            Console.WriteLine("Hvilken model er din bil?");
            Model = Console.ReadLine();

            Console.WriteLine("Hvad er brændstoftypen? OBS! Vælg et af følgende:\nBenzin, Diesel, Electric, Hybrid\nStart ordet med stort. ");
            FuelType = (FuelType)Enum.Parse(typeof(FuelType), Console.ReadLine());

            Console.WriteLine("Hvilket årstal er din bil fra?");
            Year = int.Parse(Console.ReadLine());

            Console.WriteLine("Har din bil automatiske eller manuelle gear?");
            Gear = Console.ReadLine()[0];

            Console.WriteLine("Hvad er kilometerstanden på bilen? ");
            Odometer = double.Parse(Console.ReadLine());

            Console.WriteLine("Hvor mange km kører bilen pr. liter?");
            KmPrLiter = double.Parse(Console.ReadLine());
        }

        public void PrintCarDetails()
        {
            Console.WriteLine("Bilen er bilmærke: " + Brand);
            Console.WriteLine("Dens model er: " + Model);
            Console.WriteLine("Brændstoftypen er: " + FuelType);
            Console.WriteLine("Den er fra årgang: " + Year);
            Console.WriteLine("Den har geartype: " + Gear);
            Console.WriteLine("Bilens kilometerstand er: " + Odometer);
            Console.WriteLine("Den kører " + KmPrLiter + " km/liter.");
        }

        // Lav en liste over køreture (listen kaldes trips):

        /* Opret metoden Drive() med et Trip-objekt som parameter
         * som opdaterer bilens odometer
         * og tilføjer turen til trips-listen.
         * Det vil sige, at her gemmes de ture bilen har kørt.
         */

        public void Drive(Trip nyKøretur)
        {
            if (IsEngineOn  == false)
            {
                Console.WriteLine("Du skal starte din " + Brand + " " + Model + " inden du kan køre en tur med den.");
                return;
            }
            Odometer += nyKøretur.Distance;
            _trips.Add(nyKøretur);
            Console.WriteLine("Nu har du kørt en tur med din " + Brand + " " + Model + ".");
        }

        public void TurnEngineOn()
        {
            IsEngineOn = true;
        }

        public void TurnEngineOff()
        {
            IsEngineOn = false;
        }

        // Opret metode PrintAllTrips() som lægger turene sammen.

        public void PrintAllTrips()
        {
            for (int i = 0; i < _trips.Count; i++)
            {
                _trips[i].PrintTripDetails();
            }
        }
    }
}
