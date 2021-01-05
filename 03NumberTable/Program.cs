using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    number = i + j + 1;

                    if (number > n)
                    {
                        number = 2 * n - number;
                    }

                    Console.Write($"{number} ");
                    
                }
                Console.WriteLine();
            }
        }
    }
}
