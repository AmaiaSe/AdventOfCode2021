using System;
using System.Collections.Generic;

namespace Day11
{
    class Program
    {
        static void Main(string[] args)
        {
            string data;
            List<int[]> matrix = new List<int[]>();
            int dimension = 10;

            while ((data = Console.ReadLine()) != "")
            {
                int[] row = new int[dimension];
                for (int i = 0; i < dimension; i++)
                {
                    row[i] = Convert.ToInt32(Convert.ToString(data[i]));
                }
                matrix.Add(row);
            }

            //Console.WriteLine(FirstHalf.After100Steps(matrix, dimension));

            Console.WriteLine(SecondHalf.AllFlash(matrix,dimension));
        }


        public static void PrintMatrix(List<int[]> matrix)
        {
            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
