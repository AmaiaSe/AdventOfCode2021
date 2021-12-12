using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    class FirstHalf
    {
        public static int ConstantFuelWaste()
        {
            string data = Console.ReadLine();

            List<int> listNums = data.Split(',').Select(int.Parse).ToList();
            listNums.Sort();
            int mediana = listNums[listNums.Count / 2];

            int fuel = 0;
            for (int i = 0; i < listNums.Count; i++)
            {
                fuel += Math.Abs(listNums[i] - mediana);
            }

            return fuel;
        }
    }
}
