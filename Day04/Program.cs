using System;

namespace Day04
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            List<int> listNums = s.Split(',').Select(int.Parse).ToList();

            int[][] matrix = new int[5][];
            int[][] bestMatrix = new int[5][];
            for (int i = 0; i < bestMatrix.Length; i++)
            {
                bestMatrix[i] = new int[] { 0, 0, 0, 0, 0 };
            }

            //Console.WriteLine(WinBoard(listNums, matrix, bestMatrix));

            //Console.WriteLine(LoseBoard(listNums, matrix, bestMatrix));
        }
    }
}
