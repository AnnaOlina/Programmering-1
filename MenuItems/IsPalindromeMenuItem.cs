﻿namespace Programmering_1.MenuItems
{
    public class IsPalindromeMenuItem
    {
        static public void TestIsPalindrome()
        {
            Console.WriteLine("Er palindrom 456: " + IsPalindrome(456));
            Console.WriteLine("Er palindrom 1: " + IsPalindrome(1));
            Console.WriteLine("Er palindrom 132564721: " + IsPalindrome(132564721));
            Console.WriteLine("Er palindrom 9433: " + IsPalindrome(9433));
            Console.WriteLine("Er palindrom 55055: " + IsPalindrome(55055));
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
