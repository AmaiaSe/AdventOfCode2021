using System;

namespace Day05
{
    class Program
    {
        static void Main(string[] args)
        {
            string data;
            int[] coord1;
            int[] coord2;
            Dictionary<string, int> dangerPoints = new Dictionary<string, int>();

            Console.WriteLine(FirstHalf.HVDangerPoints());

            Console.WriteLine(SecondHalf.HVDDangerPoints());
        }
    }
}
