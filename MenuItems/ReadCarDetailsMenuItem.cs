using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering_1.MenuItems
{
    internal class ReadCarDetailsMenuItem
    {
        public static Car StartReadCarDetailsMenu()
        {
            List<Car> biler = new List<Car>();  // Her laves en tom liste af bilobjekter.

            using (StreamReader sr = new StreamReader("biler.txt"))  // Her åbnes tekstfilen biler.txt i mappen på computeren. Metoden leder efter tekstfilen lokalt.
            {
                while (true)
                {
                    string line = sr.ReadLine();  // Her hentes næste linje i tekstfilen.

                    if (line == null)
                    {
                        break;  // Break ud af loopet, når linjen er null (ingen linje).
                    }

                    string[] lineParts = line.Split(",");  // Her splittes linjen i tekstfilen op i 3 dele.

                    if (lineParts.Length < 4)
                    {
                        continue;
                    }

                    Car bil = new Car(lineParts[0], lineParts[1], int.Parse(lineParts[2]), char.Parse(lineParts[3].Trim()));  // Her laves et bil-objekt ud fra de 4 dele.
                    biler.Add(bil);  // Her tilføjes bilen til listen.
                }
            }  // Her lukkes tekstfilen. Fordi man nu er ude af kodeblokken.

            foreach (Car bil in biler)
            {
                Console.WriteLine("Mærke: " + bil.Brand + ", Model: " + bil.Model + ", Årgang: " + bil.Year + ", Geartype: " + bil.Gear);  // Her skrives personinformationerne til konsollen.
            }

            Console.ReadKey();

            Console.WriteLine("Venligst giv mig oplysninger om din bil.\n");

            Car dinBil1 = new Car();
            dinBil1.ReadCarDetails();
            Console.WriteLine("Tak for oplysningerne om din bil.");

            Console.ReadKey();
            return dinBil1;
        }
    }
}
