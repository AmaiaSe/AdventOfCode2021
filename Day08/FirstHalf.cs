using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08
{
    class FirstHalf
    {
        public static int numberOfUniques()
        {
            string data;
            int cont = 0;

            while ((data = Console.ReadLine()) != "")
            {
                string[] inAndOut = data.Split(" | ");

                string[] output = inAndOut[1].Split();

                for (int i = 0; i < output.Length; i++)
                {
                    if (output[i].Length == 2 || output[i].Length == 4 || output[i].Length == 3 || output[i].Length == 7)
                    {
                        cont++;
                    }
                }
            }

            return cont;
        }
    }
}
