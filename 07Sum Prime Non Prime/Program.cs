using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sumPrime = 0;
            int sumNonPrime = 0;
            int number = 0;

            while (input != "stop")
            {
                
                number = int.Parse(input);

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else if (number == 0)
                {
                    sumNonPrime += number;
                }
                else if (number == 1)
                {
                    sumNonPrime += number;
                }
                else
                {
                    int counter = 0;
                    for (int i = 1; i <= number; i++)
                    {
                        if (number % i == 0)
                        {
                            counter++;
                        }
                    }

                    if (counter > 2)
                    {
                        sumNonPrime += number;
                    }
                    else
                    {
                        sumPrime += number;
                    }
                }

                input = Console.ReadLine();

            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
