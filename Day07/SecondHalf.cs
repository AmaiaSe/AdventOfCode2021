using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    class SecondHalf
    {
        public static long ExponentialFuelWaste()
        {
            string data = Console.ReadLine();

            List<int> listNums = data.Split(',').Select(int.Parse).ToList();
            listNums.Sort();

            double sum=0;
            for (int i = 0; i < listNums.Count; i++)
            {
                sum += listNums[i];
            }
            
            double mean = sum / listNums.Count;
            if (mean%1>=0.6)
            {
                mean = Math.Round(mean);
            }
            else
            {
                mean = Math.Floor(mean);
            }

            long fuel = 0;
            int selfFuel = 0;
            for (int i = 0; i < listNums.Count; i++)
            {
                selfFuel = Math.Abs(listNums[i] - Convert.ToInt32(mean));
                for (int j = 0; j < selfFuel; j++)
                {
                    fuel += 1+j;
                }
            }

            return fuel;
        }
    }
}
