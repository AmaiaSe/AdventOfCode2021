using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09
{
    class SecondHalf
    {
        public static int BiggestBasins()
        {
            //--- NOT FINISHED ---

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

            List<int[]> lowestPointsList = new List<int[]>();

            for (int i = 0; i < matrix.Count; i++)
            {
                int num;
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    int[] coordinates = new int[2];
                    bool lowestPoint = false;
                    num = matrix[i][j];
                    if (num == 0)
                    {
                        lowestPoint = true;
                    }
                    else if (j == 0)
                    {
                        if (i == 0)
                        {
                            if (num < matrix[i + 1][j] && num < matrix[i][j + 1])
                            {
                                lowestPoint = true;
                            }
                        }
                        else if (i == matrix.Count - 1)
                        {
                            if (num < matrix[i - 1][j] && num < matrix[i][j + 1])
                            {
                                lowestPoint = true;
                            }
                        }
                        else
                        {
                            if (num < matrix[i - 1][j] && num < matrix[i][j + 1] && num < matrix[i + 1][j])
                            {
                                lowestPoint = true;
                            }
                        }
                    }
                    else if (j == matrix[i].Length - 1)
                    {
                        if (i == 0)
                        {
                            if (num < matrix[i + 1][j] && num < matrix[i][j - 1])
                            {
                                lowestPoint = true;
                            }
                        }
                        else if (i == matrix.Count - 1)
                        {
                            if (num < matrix[i - 1][j] && num < matrix[i][j - 1])
                            {
                                lowestPoint = true;
                            }
                        }
                        else
                        {
                            if (num < matrix[i - 1][j] && num < matrix[i][j - 1] && num < matrix[i + 1][j])
                            {
                                lowestPoint = true;
                            }
                        }
                    }
                    else if (i == 0)
                    {
                        if (num < matrix[i][j - 1] && num < matrix[i + 1][j] && num < matrix[i][j + 1])
                        {
                            lowestPoint = true;
                        }
                    }
                    else if (i == matrix.Count - 1)
                    {
                        if (num < matrix[i][j - 1] && num < matrix[i - 1][j] && num < matrix[i][j + 1])
                        {
                            lowestPoint = true;
                        }
                    }
                    else
                    {
                        if (num < matrix[i][j - 1] && num < matrix[i][j + 1] && num < matrix[i - 1][j] && num < matrix[i + 1][j])
                        {
                            lowestPoint = true;
                        }
                    }

                    if (lowestPoint)
                    {
                        coordinates[0] = j;
                        coordinates[1] = i;
                        lowestPointsList.Add(coordinates);
                    }
                }
            }

            Console.WriteLine();
            List<int> basinsDepth = new List<int>();
            foreach (var lowestPoint in lowestPointsList)
            {
                List<Coordinate> queue = new List<Coordinate>();
                List<Coordinate> alreadyChecked = new List<Coordinate>();
                Coordinate coord = new Coordinate(Convert.ToInt32(lowestPoint[0].ToString()), Convert.ToInt32(lowestPoint[1].ToString()));
                queue.Add(coord);
                int contDepthPoints = 0;
                while (queue.Count != 0)
                {
                    //lo q está mal es q al hacer las coords como xy, no he tenido en cuenta los que seon xxyy etc -.-

                    alreadyChecked.Add(queue[0]);
                    int j = Convert.ToInt32(coord.x.ToString());
                    int i = Convert.ToInt32(coord.y.ToString());
                    queue.RemoveAt(0);

                    int[] coordinates = new int[2];

                    contDepthPoints++;
                    if (j != 0)
                    {
                        if (matrix[i][j - 1] != 9 && !alreadyChecked.Contains((j - 1).ToString() + i.ToString()) && !queue.Contains((j - 1).ToString() + i.ToString()))
                        {
                            queue.Add((j - 1).ToString() + i.ToString());
                            //contDepthPoints++;

                        }
                    }

                    if (j != matrix[0].Length - 1)
                    {
                        if (matrix[i][j + 1] != 9 && !alreadyChecked.Contains((j + 1).ToString() + i.ToString()) && !queue.Contains((j + 1).ToString() + i.ToString()))
                        {
                            queue.Add((j + 1).ToString() + i.ToString());
                            //contDepthPoints++;
                        }
                    }
                    if (i != 0)
                    {
                        if (matrix[i - 1][j] != 9 && !alreadyChecked.Contains(j.ToString() + (i - 1).ToString()) && !queue.Contains(j.ToString() + (i - 1).ToString()))
                        {
                            queue.Add(j.ToString() + (i - 1).ToString());
                            //contDepthPoints++;
                        }
                    }
                    if (i != matrix.Count - 1)
                    {
                        if (matrix[i + 1][j] != 9 && !alreadyChecked.Contains(j.ToString() + (i + 1).ToString()) && !queue.Contains(j.ToString() + (i + 1).ToString()))
                        {
                            queue.Add(j.ToString() + (i + 1).ToString());
                            //contDepthPoints++;
                        }
                    }
                }
                basinsDepth.Add(contDepthPoints);
            }
            basinsDepth.Sort();

            Console.WriteLine(basinsDepth[basinsDepth.Count - 1] * basinsDepth[basinsDepth.Count - 2] * basinsDepth[basinsDepth.Count - 3]);
            return 0;
        }
    }
}
