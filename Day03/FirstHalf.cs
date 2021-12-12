using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    class FirstHalf
    {
        public static int GammaPerEpsilon()
        {
            string data;
            int[] count_0 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] count_1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            string gamma = "";
            string epsilon = "";
            while ((data = Console.ReadLine()) != "")
            {
                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i] == '0')
                    {
                        count_0[i]++;
                    }
                    else if (data[i] == '1')
                    {
                        count_1[i]++;
                    }
                }
            }
            for (int i = 0; i < count_0.Length; i++)
            {
                if (count_0[i] > count_1[i])
                {
                    gamma += "0";
                    epsilon += "1";
                }
                else
                {
                    gamma += "1";
                    epsilon += "0";
                }
            }
            int g = Convert.ToInt32(gamma, 2);
            int e = Convert.ToInt32(epsilon, 2);
            return g * e;
        }
    }
}
