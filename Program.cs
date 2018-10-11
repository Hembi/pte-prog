using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace leapyear
{
    class checkLeapYear
    {
        static void Main(string[] args)
        {
            List<int> imputYears = new List<int>();
            
            for(int i = 0; i < 2; i++)
            {
                int number;
                string textToRead;
                do
                {
                    Console.Write("Adj meg egy évszámot:\n");
                    textToRead = Console.ReadLine();
                }
                while(!Int32.TryParse(textToRead, out number));
                imputYears.Add(number);
            }
            
            List<int> betweenYears = new List<int>(); //Tömbbe szedve a feladat kérése alapján
            for( int i = imputYears[0]; i < imputYears[1]; i++ )
            {
                if(isLeapYear(i))
                    betweenYears.Add(i);
            }
            Console.Write("Szökőévek {0} és {1} között:\n", imputYears[0], imputYears[1]);

            if(betweenYears.Count > 0)
            for( int i = 0; i < betweenYears.Count; i++ )
            {
                if(i > 0)
                    Console.Write(", ");
                
                Console.Write("{0}", betweenYears[i]);
            }
            else
                Console.Write("Nem volt egy szökőév sem a kettő megadott év között.");
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