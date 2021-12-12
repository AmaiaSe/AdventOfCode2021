using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    class SecondHalf
    {
        public static int DepthIncreaseSum()
        {
            string measurement1 = Console.ReadLine();
            string measurement2 = Console.ReadLine();
            string measurement3 = Console.ReadLine();
            int measurementSum = int.Parse(measurement1) + int.Parse(measurement2) + int.Parse(measurement3);

            string newMeasurement;

            int newMeasurementSum;

            int larger = 0;

            while ((newMeasurement = Console.ReadLine()) != "")
            {
                newMeasurementSum = int.Parse(measurement2) + int.Parse(measurement3) + int.Parse(newMeasurement);
                if (measurementSum < newMeasurementSum)
                {
                    larger++;
                }

                measurementSum = newMeasurementSum;
                measurement2 = measurement3;
                measurement3 = newMeasurement;
            }

            return larger;
        }
    }
}
