using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            int currentNumber = 0;


            for (int i = 0; i < n; i++)
            {
                counter++;
                for (int j = 0; j < counter; j++)
                {
                    if (currentNumber==n)
                    {
                        break;
                    }

                    currentNumber++;
                    Console.Write($"{currentNumber} ");

                }

                Console.WriteLine();
                

            }
        }
    }
}
