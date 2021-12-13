using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class SecondHalf
    {
        public static int LoseBoard(List<int> listNums, int[][] matrix, int[][] bestMatrix)
        {
            string d;
            int cont = 0;
            int biggestCont = 0;
            bool bingo = false;
            bool encontrado = false;
            int winNum = 0;
            int bestWinNum = 0;

            while ((d = Console.ReadLine()) == "")
            {
                for (int i = 0; i < matrix.Length; i++)
                {
                    d = Console.ReadLine();
                    if (!d.Equals(""))
                    {
                        int[] ar = d
                            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
                        matrix[i] = ar;
                    }
                }

                for (int i = 0; i < listNums.Count; i++)
                {
                    for (int j = 0; j < matrix.Length; j++)
                    {
                        for (int k = 0; k < matrix[j].Length; k++)
                        {
                            if (listNums[i] == matrix[j][k])
                            {
                                matrix[j][k] = -1;
                                if (matrix[j][0] == -1 && matrix[j][1] == -1 && matrix[j][2] == -1 && matrix[j][3] == -1 && matrix[j][4] == -1)
                                {
                                    bingo = true;
                                    winNum = listNums[i];
                                    break;
                                }
                                if (matrix[0][k] == -1 && matrix[1][k] == -1 && matrix[2][k] == -1 && matrix[3][k] == -1 && matrix[4][k] == -1)
                                {
                                    bingo = true;
                                    winNum = listNums[i];
                                    break;
                                }
                                encontrado = true;
                                break;
                            }
                        }
                        if (encontrado || bingo)
                        {
                            encontrado = false;
                            break;
                        }
                    }
                    if (bingo)
                    {
                        bingo = false;
                        cont = i;
                        break;
                    }
                }
                if (cont >= biggestCont)
                {
                    biggestCont = cont;
                    bestWinNum = winNum;
                    for (int i = 0; i < matrix.Length; i++)
                    {
                        for (int j = 0; j < matrix[i].Length; j++)
                        {
                            bestMatrix[i][j] = matrix[i][j];
                        }
                    }
                }
                cont = 0;
            }

            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (bestMatrix[i][j] != -1)
                    {
                        sum += bestMatrix[i][j];
                    }
                }
            }
            return sum * bestWinNum;
        }
    }
}
