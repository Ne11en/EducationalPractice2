using System;

namespace EduPrac2._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            char[] rimNum = (Console.ReadLine()).ToCharArray();
            int[] rusNum = new int[rimNum.Length];
            rusNum = Da(rimNum, rusNum);

            for (int i = 0; i < rusNum.Length; i++)
            {
                Console.WriteLine(rusNum[i]);
            }

            for (int i = 0; i < rusNum.Length - 1; i++)
            {
                if (rusNum[i] < rusNum[i+1])
                {
                    n += rusNum[i + 1] - rusNum[i];
                    i++;
                }
                else if (rusNum[i] >= rusNum[i+1])
                {
                    n += rusNum[i];
                    if (i == rusNum.Length - 2)
                    {
                        n += rusNum[i + 1];
                    }
                }
                
            }

            Console.WriteLine(n);
        }

        static int[] Da (char[] rimNum, int[] rusNum)
        {
            
            for (int i = 0; i < rimNum.Length; i++)
            {
                switch (rimNum[i])
                {
                    case 'I':
                        rusNum[i] = 1;
                        break;
                    case 'V':
                        rusNum[i] = 5;
                        break;
                    case 'X':
                        rusNum[i] = 10;
                        break;
                    case 'L':
                        rusNum[i] = 50;
                        break;
                    case 'C':
                        rusNum[i] = 100;
                        break;
                    case 'D':
                        rusNum[i] = 500;
                        break;
                    case 'M':
                        rusNum[i] = 1000;
                        break;
                }
                
            }

            return rusNum;
        }
    }
}