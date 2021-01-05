using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Stupid_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int first = 1; first <= n; first++)
            {
                for (int second = 1; second <= n; second++)
                {
                    for (char third = 'a'; third <= ('a'+ l-1); third++)
                    {
                        for (char fourth = 'a'; fourth <= ('a' + l-1); fourth++)
                        {
                            for (int fifth = 1; fifth <= n; fifth++)
                            {
                                if (fifth > first && fifth > second)
                                {
                                    Console.Write(first + "" + second + "" + third + "" + fourth + "" + fifth + " ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
