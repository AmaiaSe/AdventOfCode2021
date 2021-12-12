using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    class FirstHalf
    {
        public static int CorruptedLines()
        {
            string data;
            int cont = 0;
            while ((data = Console.ReadLine()) != "")
            {
                List<char> brackets = new List<char>();
                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i] == '(' || data[i] == '[' || data[i] == '{' || data[i] == '<')
                    {
                        brackets.Add(data[i]);
                    }
                    else if (data[i] == ')')
                    {
                        if (brackets[brackets.Count - 1] == '(')
                        {
                            brackets.RemoveAt(brackets.Count - 1);
                        }
                        else
                        {
                            //corrupted
                            cont += 3;
                            break;
                        }
                    }
                    else if (data[i] == ']')
                    {
                        if (brackets[brackets.Count - 1] == '[')
                        {
                            brackets.RemoveAt(brackets.Count - 1);
                        }
                        else
                        {
                            //corrupted
                            cont += 57;
                            break;
                        }
                    }
                    else if (data[i] == '}')
                    {
                        if (brackets[brackets.Count - 1] == '{')
                        {
                            brackets.RemoveAt(brackets.Count - 1);
                        }
                        else
                        {
                            //corrupted
                            cont += 1197;
                            break;
                        }
                    }
                    else if (data[i] == '>')
                    {
                        if (brackets[brackets.Count - 1] == '<')
                        {
                            brackets.RemoveAt(brackets.Count - 1);
                        }
                        else
                        {
                            //corrupted
                            cont += 25137;
                            break;
                        }
                    }
                }
            }
            return cont;
        }
    }
}
