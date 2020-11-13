using System;
using System.Collections.Generic;

namespace Task2_HappyYear
{
    public class StartUp
    {
        static void Main()
        {
            Greet(2018);

            Greet(2019);

            Greet(9999);
        }

        private static void Greet(int givenYear)
        {
            long year = givenYear;
            bool isHappyYear = false;

            while (!isHappyYear)
            {
                year++;
                isHappyYear = FindIfYearIsHappy(year);
            }

            if (isHappyYear)
            {
                Console.WriteLine($"Good Bye, {givenYear}! See you in {year}!");
            }
        }

        private static bool FindIfYearIsHappy(long year)
        {
            long temp = year;
            HashSet<int> digits = new HashSet<int>();

            while (temp > 0)
            {
                int lastDigit = (int)(temp % 10);
                temp /= 10;

                if (digits.Contains(lastDigit))
                {
                    return false;
                } 

                digits.Add(lastDigit);
            }

            return true;
        }
    }
}
