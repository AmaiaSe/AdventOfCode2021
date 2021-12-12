using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    class SecondHalf
    {
        public static long CloseBrackets()
        {
            string data;
            List<long> contList = new List<long>();
            while ((data = Console.ReadLine()) != "")
            {
                List<char> brackets = new List<char>();
                bool isCorrupted = false;
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
                            isCorrupted = true;
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
                            isCorrupted = true;
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
                            isCorrupted = true;
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
                            isCorrupted = true;
                            break;
                        }
                    }
                }
                if (!isCorrupted)
                {
                    long contLine = 0;
                    for (int i = brackets.Count - 1; i >= 0; i--)
                    {
                        contLine *= 5;
                        if (brackets[i] == '(')
                        {
                            contLine += 1;
                        }
                        else if (brackets[i] == '[')
                        {
                            contLine += 2;
                        }
                        else if (brackets[i] == '{')
                        {
                            contLine += 3;
                        }
                        else if (brackets[i] == '<')
                        {
                            contLine += 4;
                        }
                    }
                    contList.Add(contLine);
                }
            }
            contList.Sort();
            return contList[contList.Count / 2];
        }
    }
}
