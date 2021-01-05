using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            for (int x11 = a; x11 <= b; x11++)
            {
                for (int x12 = a; x12 <= b; x12++)
                {
                    for (int x21 = c; x21 <= d; x21++)
                    {
                        for (int x22 = c; x22 <= d; x22++)
                        {
                            if (x11+x22 == x21+x12 && x11 != x12 && x21 != x22)
                            {
                                Console.WriteLine($"{x11}{x12}");
                                Console.WriteLine($"{x21}{x22}");
                                Console.WriteLine();

                            }
                        }
                    }
                }
            }

        }
    }
}
