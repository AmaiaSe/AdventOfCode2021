using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    class SecondHalf
    {
        public static int OxygenPerCO2()
        {
            string data;
            List<string> dataList = new List<string>();
            List<string> List_0 = new List<string>();
            List<string> List_1 = new List<string>();

            string O2 = "";
            string CO2 = "";
            while ((data = Console.ReadLine()) != "")
            {
                dataList.Add(data);
            }

            int pos = 0;
            //Oxygen
            List<string> dataListCopy = new List<string>(dataList);
            for (int i = 0; i < dataListCopy.Count; i++)
            {
                if (dataListCopy.Count == 1)
                {
                    break;
                }
                if (dataListCopy[i][pos] == '0')
                {
                    if (!List_0.Contains(dataListCopy[i]))
                    {
                        List_0.Add(dataListCopy[i]);
                    }
                }
                else if (dataListCopy[i][pos] == '1')
                {
                    if (!List_1.Contains(dataListCopy[i]))
                    {
                        List_1.Add(dataListCopy[i]);
                    }
                }
                if (i == dataListCopy.Count - 1)
                {
                    if (List_0.Count > List_1.Count)
                    {
                        dataListCopy = List_0;
                    }
                    else
                    {
                        dataListCopy = List_1;
                    }
                    List_0 = new List<string>();
                    List_1 = new List<string>();
                    i = -1;
                    pos++;
                }
            }
            O2 = dataListCopy[0];

            List_0 = new List<string>();
            List_1 = new List<string>();
            pos = 0;
            //CO2
            for (int i = 0; i < dataList.Count; i++)
            {
                if (dataList.Count == 1)
                {
                    break;
                }
                if (dataList[i][pos] == '0')
                {
                    if (!List_0.Contains(dataList[i]))
                    {
                        List_0.Add(dataList[i]);
                    }
                }
                else if (dataList[i][pos] == '1')
                {
                    if (!List_1.Contains(dataList[i]))
                    {
                        List_1.Add(dataList[i]);
                    }
                }
                if (i == dataList.Count - 1)
                {
                    if (List_0.Count <= List_1.Count)
                    {
                        dataList = List_0;
                    }
                    else
                    {
                        dataList = List_1;
                    }
                    List_0 = new List<string>();
                    List_1 = new List<string>();
                    i = -1;
                    pos++;
                }
            }
            CO2 = dataList[0];

            int o2 = Convert.ToInt32(O2, 2);
            int co2 = Convert.ToInt32(CO2, 2);
            return o2 * co2;
        }
    }
}
