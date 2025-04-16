namespace Programmering_1.MenuItems
{
    public class IsPalindromeMenuItem
    {
        static public void StartIsPalindromeMenu()
        {
            Console.WriteLine("Er palindrom 456: " + IsPalindrome(456));
            Console.WriteLine("Er palindrom 1: " + IsPalindrome(1));
            Console.WriteLine("Er palindrom 132564721: " + IsPalindrome(132564721));
            Console.WriteLine("Er palindrom 9433: " + IsPalindrome(9433));
            Console.WriteLine("Er palindrom 55055: " + IsPalindrome(55055));
            /* Jeg laver en WriteLine, hvor jeg beder brugeren indtaste km-stand i konsollen.
             * Jeg kalder metoden IsPalindrome(), og parameteren heri skal være en int (heltal). 
             * Det er ligemeget, om tallet skrives direkte ind som parameter,
             * eller om det skrives ind med ReadLine.
             * Man skal bare huske at "parse" ReadLine til int,
             * fordi ReadLine ellers er en streng.
             */
            Console.WriteLine("Indtast din kilomterstand (eller et stort tal), så ser vi om det er et Palindrom: ");
            Console.WriteLine(IsPalindrome(int.Parse(Console.ReadLine())));
        }

        static private bool IsPalindrome(int kilometerstand)
        {
            string tekst = kilometerstand.ToString();

            for (int i = 0; i < tekst.Length; i++)
            {

                if (tekst[i] != tekst[tekst.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
