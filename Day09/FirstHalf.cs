using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09
{
    class FirstHalf
    {
        public static int LowestLocations()
        {
            string data = Console.ReadLine();

            //int[][] matrix = new int[data.Length][];
            List<int[]> matrix = new List<int[]>();
            do
            {
                int[] line = new int[data.Length];
                for (int i = 0; i < data.Length; i++)
                {
                    line[i] = int.Parse(data[i].ToString());
                }
                matrix.Add(line);
            } while ((data = Console.ReadLine()) != "");

            int cont = 0;
            for (int i = 0; i < matrix.Count; i++)
            {
                int num;
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    num = matrix[i][j];
                    if (num == 0)
                    {
                        cont++;
                    }
                    else if (j == 0)
                    {
                        if (i == 0)
                        {
                            if (num < matrix[i + 1][j] && num < matrix[i][j + 1])
                            {
                                cont += num;
                            }
                        }
                        else if (i == matrix.Count - 1)
                        {
                            if (num < matrix[i - 1][j] && num < matrix[i][j + 1])
                            {
                                cont += num + 1;
                            }
                        }
                        else
                        {
                            if (num < matrix[i - 1][j] && num < matrix[i][j + 1] && num < matrix[i + 1][j])
                            {
                                cont += num + 1;
                            }
                        }
                    }
                    else if (j == matrix[i].Length - 1)
                    {
                        if (i == 0)
                        {
                            if (num < matrix[i + 1][j] && num < matrix[i][j - 1])
                            {
                                cont += num + 1;
                            }
                        }
                        else if (i == matrix.Count - 1)
                        {
                            if (num < matrix[i - 1][j] && num < matrix[i][j - 1])
                            {
                                cont += num + 1;
                            }
                        }
                        else
                        {
                            if (num < matrix[i - 1][j] && num < matrix[i][j - 1] && num < matrix[i + 1][j])
                            {
                                cont += num + 1;
                            }
                        }
                    }
                    else if (i == 0)
                    {
                        if (num < matrix[i][j - 1] && num < matrix[i + 1][j] && num < matrix[i][j + 1])
                        {
                            cont += num + 1;
                        }
                    }
                    else if (i == matrix.Count - 1)
                    {
                        if (num < matrix[i][j - 1] && num < matrix[i - 1][j] && num < matrix[i][j + 1])
                        {
                            cont += num + 1;
                        }
                    }
                    else
                    {
                        if (num < matrix[i][j - 1] && num < matrix[i][j + 1] && num < matrix[i - 1][j] && num < matrix[i + 1][j])
                        {
                            cont += num + 1;
                        }
                    }
                }
            }

            return cont;
        }
    }
}
