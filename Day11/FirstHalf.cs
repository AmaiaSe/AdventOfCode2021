using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11
{
    class FirstHalf
    {
        public static int After100Steps(List<int[]> matrix, int dimension)
        {
            int flashCont = 0;
            for (int k = 0; k < 100; k++)
            {
                List<Coordinate> queue = new List<Coordinate>();
                for (int i = 0; i < matrix.Count; i++)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        if (matrix[i][j] == 9)
                        {
                            matrix[i][j] = 0;
                            queue.Add(new Coordinate(j, i));
                            flashCont++;
                        }
                        else
                        {
                            matrix[i][j] += 1;
                        }
                    }
                }

                while (queue.Count > 0)
                {
                    Coordinate coord = queue[0];
                    queue.RemoveAt(0);
                    List<Coordinate> listNearOctopi = new List<Coordinate>();
                    if (coord.x != 0 && coord.y != 0)
                    {
                        listNearOctopi.Add(new Coordinate(coord.x - 1, coord.y - 1));
                    }
                    if (coord.x != dimension - 1 && coord.y != 0)
                    {
                        listNearOctopi.Add(new Coordinate(coord.x + 1, coord.y - 1));
                    }
                    if (coord.x != 0 && coord.y != dimension - 1)
                    {
                        listNearOctopi.Add(new Coordinate(coord.x - 1, coord.y + 1));
                    }
                    if (coord.x != dimension - 1 && coord.y != dimension - 1)
                    {
                        listNearOctopi.Add(new Coordinate(coord.x + 1, coord.y + 1));
                    }
                    if (coord.x != 0)
                    {
                        listNearOctopi.Add(new Coordinate(coord.x - 1, coord.y));
                    }
                    if (coord.x != dimension - 1)
                    {
                        listNearOctopi.Add(new Coordinate(coord.x + 1, coord.y));
                    }
                    if (coord.y != 0)
                    {
                        listNearOctopi.Add(new Coordinate(coord.x, coord.y - 1));
                    }
                    if (coord.y != dimension - 1)
                    {
                        listNearOctopi.Add(new Coordinate(coord.x, coord.y + 1));
                    }

                    for (int i = 0; i < listNearOctopi.Count; i++)
                    {
                        Coordinate nearOctopus = listNearOctopi[i];
                        if (matrix[nearOctopus.y][nearOctopus.x] == 0)
                        {
                            //no tocar
                        }
                        else if (matrix[nearOctopus.y][nearOctopus.x] == 9)
                        {
                            matrix[nearOctopus.y][nearOctopus.x] = 0;
                            queue.Add(new Coordinate(nearOctopus.x, nearOctopus.y));
                            flashCont++;
                        }
                        else
                        {
                            matrix[nearOctopus.y][nearOctopus.x] += 1;
                        }
                    }
                }
            }

            return flashCont;
        }
    }
}
