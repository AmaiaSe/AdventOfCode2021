using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08
{
    class SecondHalf
    {
        public static int Decodification()
        {
            //--- NOT FINISHED ---

            string data;

            string letras = "abcdefg";
            string number9 = "";
            int sum = 0;

            while ((data = Console.ReadLine()) != "")
            {
                char[] codification = new char[7];

                string[] inAndOut = data.Split(" | ");

                string[] input = inAndOut[0].Split().OrderBy(x => x.Length).ToArray();

                for (int i = 0; i < input.Length; i++)
                {
                    //take number 1 and save the values on c & f position (may change later)
                    if (input[i].Length == 2)
                    {
                        codification[2] = input[i][0];
                        codification[5] = input[i][1];
                        continue;
                    }
                    //take number 7 and save the value on a
                    else if (input[i].Length == 3)
                    {
                        for (int j = 0; j < input[i].Length; j++)
                        {
                            if (!codification.Contains(input[i][j]))
                            {
                                codification[0] = input[i][j];
                                break;
                            }
                        }
                        continue;
                    }
                    //take number 4 and save the values on b & d position (may change later)
                    else if (input[i].Length == 4)
                    {
                        for (int j = 0; j < input[i].Length; j++)
                        {
                            if (!codification.Contains(input[i][j]))
                            {
                                if (codification[1] == 0)
                                {
                                    codification[1] = input[i][j];
                                }
                                else
                                {
                                    codification[3] = input[i][j];
                                }
                            }
                        }
                        continue;
                    }
                    //take number 0, 6 or 9
                    else if (input[i].Length == 6)
                    {
                        int contFaltan = 0;
                        //char letraG=' ';
                        for (int j = 0; j < input[i].Length; j++)
                        {
                            if (!codification.Contains(input[i][j]))
                            {
                                contFaltan++;
                                //letraG = input[i][j];
                            }
                        }

                        //here input[i] must be 9
                        if (contFaltan == 1)
                        {
                            for (int j = 0; j < input[i].Length; j++)
                            {
                                if (!codification.Contains(input[i][j]))
                                {
                                    codification[6] = input[i][j];
                                    break;
                                }
                            }
                            //codification[6] = letraG;
                            for (int j = 0; j < letras.Length; j++)
                            {
                                if (!codification.Contains(letras[j]))
                                {
                                    codification[4] = letras[j];
                                    break;
                                }
                            }
                            number9 = input[i];
                            break;
                        }
                    }
                }
                //here we know:
                //OK: a, e & g
                //pair: c & f
                //pair: b & d

                string[] length6numbers = new string[3];
                int num = 0;
                bool is0check = false;
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i].Length == 6)
                    {
                        length6numbers[num] = input[i];
                        num++;
                    }
                }

                for (int i = 0; i < length6numbers.Length; i++)
                {
                    int contFaltan = 0;
                    if (!number9.Equals(length6numbers[i]) && !is0check)
                    {
                        for (int j = 0; j < length6numbers[i].Length; j++)
                        {
                            if (codification[2] == length6numbers[i][j] || codification[5] == length6numbers[i][j])
                            {
                                contFaltan++;
                            }
                        }

                        //here 0
                        if (contFaltan == 2)
                        {
                            for (int j = 0; j < length6numbers[i].Length; j++)
                            {
                                is0check = true;
                                if (codification[3] == (length6numbers[i][j]))
                                {
                                    char pivot = codification[3];
                                    codification[3] = codification[1];
                                    codification[1] = pivot;
                                    i = 0;
                                    break;
                                }
                            }
                        }
                        continue;
                    }
                    //here 6
                    else if (!number9.Equals(length6numbers[i]) && is0check)
                    {
                        for (int j = 0; j < length6numbers[i].Length; j++)
                        {
                            if (codification[2] == length6numbers[i][j])
                            {
                                char pivot = codification[2];
                                codification[2] = codification[5];
                                codification[5] = pivot;
                            }
                        }

                        //if (contFaltan == 0)
                        //{
                        //    char pivot = codification[2];
                        //    codification[2] = codification[5];
                        //    codification[5] = pivot;
                        //}
                    }
                }
                Console.WriteLine("codification: ");
                for (int i = 0; i < codification.Length; i++)
                {
                    Console.Write(codification[i]);
                }
                Console.WriteLine();

                string[] output = inAndOut[1].Split();
                string numDigits = "";

                for (int i = 0; i < output.Length; i++)
                {
                    int contNumGuess = 0;
                    bool is2 = false;
                    bool not0 = false;
                    bool not6 = false;
                    bool not9 = false;
                    if (output[i].Length == 2)
                    {
                        numDigits += 1;
                    }
                    else if (output[i].Length == 3)
                    {
                        numDigits += 7;
                    }
                    else if (output[i].Length == 4)
                    {
                        numDigits += 4;
                    }
                    else if (output[i].Length == 7)
                    {
                        numDigits += 8;
                    }
                    else if (output[i].Length == 5)
                    {
                        for (int j = 0; j < output[i].Length; j++)
                        {
                            if (output[i][j] == codification[4])
                            {
                                is2 = true;
                                numDigits += 2;
                            }
                            if (output[i][j] == codification[2] || output[i][j] == codification[5])
                            {
                                contNumGuess++;
                            }
                        }
                        if (contNumGuess == 2)
                        {
                            numDigits += 3;
                        }
                        else if (contNumGuess == 1 && !is2)
                        {
                            numDigits += 5;
                        }
                    }
                    else if (output[i].Length == 6)
                    {
                        for (int j = 0; j < output[i].Length; j++)
                        {
                            if (output[i][j] == codification[3])
                            {
                                not0 = true;
                            }
                            if (output[i][j] == codification[2])
                            {
                                not6 = true;
                            }
                            if (output[i][j] == codification[4])
                            {
                                not9 = true;
                            }
                        }
                        if (not0 && not6)
                        {
                            numDigits += 9;
                        }
                        else if (not0 && not9)
                        {
                            numDigits += 6;
                        }
                        else if (not6 && not9)
                        {
                            numDigits += 0;
                        }
                    }
                }
                Console.WriteLine(numDigits);
                sum += Convert.ToInt32(numDigits);
            }

            return sum;
        }
    }
}
