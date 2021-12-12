using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    class FirstHalf
    {
        public static int After80Days()
        {
            List<int> listOfFish = new List<int>();
            string data = Console.ReadLine();
            listOfFish = data.Split(',').Select(int.Parse).ToList();

            for (int i = 0; i < 80; i++)
            {
                for (int j = 0; j < listOfFish.Count; j++)
                {
                    if (listOfFish[j] != 0)
                    {
                        listOfFish[j]--;
                    }
                    else
                    {
                        listOfFish[j] = 6;
                        listOfFish.Add(9);
                    }
                }
            }

            return listOfFish.Count;
        }
    }
}
