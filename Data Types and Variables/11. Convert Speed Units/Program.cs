using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input Values from console

            float distaMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            // Speed converter in m/s

            float totlaInseconds = (hours * 3600) + (minutes * 60) + (seconds);
            float metersPersec = distaMeters / totlaInseconds;

            // Speed converter in km/h

            float totalInhours = hours + (minutes / 60) + (seconds / 3600);
            float kmInhour = (distaMeters / 1000) / totalInhours;

            // Speed converter in mph

            float milesInhour = (distaMeters / 1609) / totalInhours;

            //Print
            Console.WriteLine("{0}\n{1}\n{2}\n",metersPersec,kmInhour,milesInhour);
        }
    }
}
