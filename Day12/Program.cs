using System;
using System.Collections.Generic;

namespace Day12
{
    class Program
    {
        static void Main(string[] args)
        {
            string data;
            List<string[]> connections = new List<string[]>();

            while ((data=Console.ReadLine())!="")
            {
                string[] connection = data.Split('-');
                connections.Add(connection);
            }

            Console.WriteLine();
        }
    }
}
