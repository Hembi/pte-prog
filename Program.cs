using System;
using System.Collections.Generic;

namespace temperature
{   
    public class days
    {
        public double dayAvgTemp {get; set;}
        
        public static double setDayAvgTemp(double minTemp, double maxTemp)
        {
            return ((minTemp+maxTemp)/2);
        }
    }
    class Program
    {
        public const int MAX_DAYS = 10;
        static void Main(string[] args)
        {
            days[] day = new days[MAX_DAYS];
            for(int i = 0; i < MAX_DAYS; i++)
            {
                double minTemp = 0, maxTemp = 0;
                string minTempRead, maxTempRead;
                do
                {
                    Console.Write("Add meg az {0}. nap legalacsonyabb hőmérsékletét:\n", i+1);
                    minTempRead = Console.ReadLine();
                    Console.Write("Add meg a {0}. nap legmagasabb hőmérsékletét:\n", i+1);
                    maxTempRead = Console.ReadLine();
                }
                while(!Double.TryParse(minTempRead, out minTemp) || !Double.TryParse(maxTempRead, out maxTemp));

                day[i] = new days();
                day[i].dayAvgTemp = days.setDayAvgTemp(minTemp, maxTemp);
            }

            for(int i = 0; i < MAX_DAYS; i++)
            {
                Console.Write("{0}. nap átlaghőmérséklete: {1}\n", i+1, day[i].dayAvgTemp);
            }
        }
    }
}
