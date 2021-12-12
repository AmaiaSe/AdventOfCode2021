using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    class FirstHalf
    {
        public static int DepthIncrease()
        {
            string measurement = Console.ReadLine();
            string newMeasurement;

            int larger = 0;

            while ((newMeasurement = Console.ReadLine()) != "")
            {
                if (int.Parse(measurement) < int.Parse(newMeasurement))
                {
                    larger++;
                }
                measurement = newMeasurement;
            }

            return larger;
        }
    }
}
