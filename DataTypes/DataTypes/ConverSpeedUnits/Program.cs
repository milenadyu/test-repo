using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = int.Parse(Console.ReadLine());//in meters
            int hours = int.Parse(Console.ReadLine());//in hours
            int minutes = int.Parse(Console.ReadLine());//in minutes
            int seconds = int.Parse(Console.ReadLine());//in seconds

            double totalTimeSec = (double)(hours * 3600 + minutes * 60 + seconds);
            double totalTimeHours = (double)(hours + (minutes / 60.0) + (seconds / 3600.0));

            double velocityMetinSec = (distance / totalTimeSec);
            double velocityKminHours = (distance / 1000.0) / totalTimeHours;
            double velocityMilesinHour = (distance / 1609.0) / totalTimeHours;
            Console.WriteLine(Math.Round(velocityMetinSec, 6));
            Console.WriteLine(Math.Round(velocityKminHours, 6));
            Console.WriteLine(Math.Round(velocityMilesinHour, 6));
           

        }
    }
}
