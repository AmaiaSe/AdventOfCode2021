using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    class SecondHalf
    {
        public static int HVDDangerPoints()
        {
            string data;
            int[] coord1;
            int[] coord2;
            Dictionary<string, int> dangerPoints = new Dictionary<string, int>();

            while ((data = Console.ReadLine()) != "")
            {
                string[] d = data.Split(" -> ");

                coord1 = d[0].Split(',').Select(int.Parse).ToArray();
                coord2 = d[1].Split(',').Select(int.Parse).ToArray();

                if (coord1[0] == coord2[0])
                {
                    int[] coordPivot = coord1;
                    if (coord2[1] > coord1[1])
                    {
                        coord1 = coord2;
                        coord2 = coordPivot;
                    }
                    int to = Math.Abs(coord1[1] - coord2[1]) + 1;
                    for (int i = 0; i < to; i++)
                    {
                        string point = coord2[0] + "," + (coord2[1] + i);
                        if (dangerPoints.ContainsKey(point))
                        {
                            dangerPoints[point] += 1;
                        }
                        else
                        {
                            dangerPoints.Add(point, 1);
                        }
                    }
                }

                else if (coord1[1] == coord2[1])
                {
                    int[] coordPivot = coord1;
                    if (coord2[0] > coord1[0])
                    {
                        coord1 = coord2;
                        coord2 = coordPivot;
                    }
                    int to = Math.Abs(coord1[0] - coord2[0]) + 1;
                    for (int i = 0; i < to; i++)
                    {
                        string point = (coord2[0] + i) + "," + coord2[1];
                        if (dangerPoints.ContainsKey(point))
                        {
                            dangerPoints[point] += 1;
                        }
                        else
                        {
                            dangerPoints.Add(point, 1);
                        }
                    }
                }
                else if (coord1[0] - coord2[0] == coord1[1] - coord2[1])
                {
                    int[] coordPivot = coord1;
                    if (coord2[0] > coord1[0])
                    {
                        coord1 = coord2;
                        coord2 = coordPivot;
                    }
                    int to = Math.Abs(coord1[0] - coord2[0]) + 1;
                    for (int i = 0; i < to; i++)
                    {
                        string point = (coord2[0] + i) + "," + (coord2[1] + i);
                        if (dangerPoints.ContainsKey(point))
                        {
                            dangerPoints[point] += 1;
                        }
                        else
                        {
                            dangerPoints.Add(point, 1);
                        }
                    }
                }
                else if (Math.Abs(coord1[0] - coord2[0]) == Math.Abs(coord1[1] - coord2[1]))
                {
                    int[] coordPivot = coord1;
                    if (coord2[0] > coord1[0])
                    {
                        coord1 = coord2;
                        coord2 = coordPivot;
                    }
                    int to = Math.Abs(coord1[0] - coord2[0]) + 1;
                    for (int i = 0; i < to; i++)
                    {
                        string point = (coord2[0] + i) + "," + (coord2[1] - i);
                        if (dangerPoints.ContainsKey(point))
                        {
                            dangerPoints[point] += 1;
                        }
                        else
                        {
                            dangerPoints.Add(point, 1);
                        }
                    }
                }
            }

            int cont = 0;
            foreach (var item in dangerPoints)
            {
                if (item.Value > 1)
                {
                    cont++;
                }
            }

            return cont;
        }
    }
}
