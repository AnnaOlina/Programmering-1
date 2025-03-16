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
        private int _odometer;
        private double _kmPrLiter;

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

        public int Odometer
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
    }
}
