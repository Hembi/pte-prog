using System;

namespace leapyear
{
    class checkLeapYear
    {
        static void Main(string[] args)
        {
            string textToRead = Console.ReadLine();
            int number;
            if(Int32.TryParse(textToRead, out number))
            {
                if(isLeapYear(number))
                    Console.Write("Ez bizony egy szökőév volt");
                else
                    Console.Write("Nem szökőév.");
            }
        }
        static bool isLeapYear(int year)
        {
            const int fouryear = 4;
            const int onehundredyear = 4;
            const int fourhundredyear = 4;
            if((year % fouryear == 0) && ((year % onehundredyear != 0) || year % fourhundredyear == 0))
            {
                return true;
            }
            return false;
        }
    }
}