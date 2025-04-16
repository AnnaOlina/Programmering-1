using Programmering_1;

namespace Unittest
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldDriveWhenEngineIsOn()
        {
            // Opsætning
            Car bil = new Car();
            bil.IsEngineOn = true;
            bil.Odometer = 0;

            Trip tur = new Trip();
            tur.Distance = 10;

            // Udførsel
            bil.Drive(tur);

            // Tjek
            Assert.Equal(10, bil.Odometer);
        }

        [Fact]
        public void ShouldNotDriveWhenEngineIsOff()
        {
            Car bil = new Car();
            bil.IsEngineOn = false;
            bil.Odometer = 0;

            Trip tur = new Trip();
            tur.Distance = 10;

            bil.Drive(tur);

            Assert.Equal(0, bil.Odometer);
        }
    }
}