using System;

namespace Task1_FizzBuzz
{
    public class StartUp
    {
        static void Main()
        {
            for (int i = 1; i <= 100; i++)
            {
                string result = String.Empty;

                if (i % 3 == 0)
                {
                    result += "Fizz";

                    if (i % 5 == 0)
                    {
                        result += " Buzz";
                    }
                }
                else if (i % 5 == 0)
                {
                    result += "Buzz";
                }
                else
                {
                    result = i.ToString();
                }

                Console.WriteLine(result);
            }
        }
    }
}
