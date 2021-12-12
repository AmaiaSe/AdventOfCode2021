using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    class SecondHalf
    {
        public static long After256Days()
        {
            List<int> listOfFish = new List<int>();
            string data = Console.ReadLine();
            listOfFish = data.Split(',').Select(int.Parse).ToList();

            Dictionary<int, long> fishDict = new Dictionary<int, long>()
            {
                {0,0 },
                {1,0 },
                {2,0 },
                {3,0 },
                {4,0 },
                {5,0 },
                {6,0 },
                {7,0 },
                {8,0 },
            };

            for (int i = 0; i < listOfFish.Count; i++)
            {
                if (fishDict.ContainsKey(listOfFish[i]))
                {
                    fishDict[listOfFish[i]] += 1;
                }
                else
                {
                    fishDict.Add(listOfFish[i], 1);
                }
            }

            for (int i = 0; i < 256; i++)
            {
                long zero = 0;

                for (int j = 0; j < fishDict.Count; j++)
                {
                    if (j == 0)
                    {
                        zero = fishDict[j];
                    }
                    else if (j == 8)
                    {
                        fishDict[j - 1] = fishDict[j];
                        fishDict[j] = zero;
                        fishDict[6] += zero;
                    }
                    else
                    {
                        fishDict[j - 1] = fishDict[j];
                    }
                }
            }

            long fishes = 0;
            for (int i = 0; i < fishDict.Count; i++)
            {
                fishes += fishDict[i];
            }

            return fishes;
        }
    }
}
