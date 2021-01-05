using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 0; k <= 9; k++)
                    {
                        for (int l = 1; l <= 9; l++)
                        {
                            int currentNumber = i * 1000 + j * 100 + k * 10 + l;
                            if (N % i == 0 && N % j == 0 && N % k == 0 && N % l == 0)
                            {
                                Console.Write(currentNumber + " ");
                            }
                        }
                    }
                }
            }
        }
    }
}
