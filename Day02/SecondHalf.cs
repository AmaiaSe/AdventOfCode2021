using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    class SecondHalf
    {
        public static int AimDepthMult()
        {
            string data = Console.ReadLine();
            int forward = 0;
            int depth = 0;
            int aim = 0;
            do
            {
                string[] dataArray = data.Split(' ');
                if (dataArray[0].Equals("forward"))
                {
                    forward += int.Parse(dataArray[1]);
                    depth += aim * int.Parse(dataArray[1]);
                }
                else if (dataArray[0].Equals("down"))
                {
                    aim += int.Parse(dataArray[1]);
                }
                else if (dataArray[0].Equals("up"))
                {
                    aim -= int.Parse(dataArray[1]);
                }
                
            } while ((data = Console.ReadLine()) != "");

            return forward * depth;
        }
    }
}
