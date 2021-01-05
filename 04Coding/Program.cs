using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string numString = num.ToString();
            int numLength = numString.Length;
            int currentDigit = 0;

            for (int i = numLength; i > 0; i--)
            {
                currentDigit = num % 10;
                if (currentDigit == 0)
                {
                    Console.WriteLine("ZERO");
                }
                else
                {
                    for (int j = 0; j < currentDigit; j++)
                    {
                        int currentDigitASCII = int.Parse(currentDigit.ToString());
                        char symbol = (char)(currentDigitASCII + 33);
                        Console.Write(symbol);
                    }
                    Console.WriteLine();
                    
                }
                num = num / 10;
            }
        }
    }
}
