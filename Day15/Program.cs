using System;
using System.Collections.Generic;

namespace Day15
{
    class Program
    {
        public static long bestPath { get; set; }
        static void Main(string[] args)
        {
            string data;
            List<string> matrix = new List<string>();

            while ((data = Console.ReadLine()) != "")
            {
                matrix.Add(data);
            }

            bestPath = 100;
            Console.WriteLine(FindBestPath(matrix, bestPath, matrix[0].Length - 1, matrix.Count - 1));
            Console.WriteLine(bestPath);
        }

        //--- NOT FINISHED ---
        public static long FindBestPath(List<string> matrix, long bestPath, int x, int y)
        {
            if (x <= 1)
            {
                return Convert.ToInt32(Convert.ToString(matrix[x][y]));
            }
            else if (y <= 1)
            {
                return Convert.ToInt32(Convert.ToString(matrix[x][y]));
            }
            else
            {
                long pasoDerecha = FindBestPath(matrix, bestPath, x - 1, y);
                long pasoAbajo = FindBestPath(matrix, bestPath, x, y - 1);
                if (bestPath > (pasoAbajo + pasoDerecha))
                {
                    bestPath = pasoAbajo + pasoDerecha;
                }
                return pasoDerecha + pasoAbajo;
            }
        }
    }
}
