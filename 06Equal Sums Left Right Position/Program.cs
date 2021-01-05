using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Equal_Sums_Left_Right_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {
                int number = i;
                int leftSum = 0;
                int rightSum = 0;
                int middleNumber = 0;

                while (number > 0)
                {
                    leftSum += number % 10;
                    number /= 10;
                    leftSum += number % 10;
                    number /= 10;
                    middleNumber = number % 10;
                    number /= 10;
                    rightSum += number % 10;
                    number /= 10;
                    rightSum += number % 10;
                    number /= 10;
                }

                if (leftSum == rightSum)
                {
                    Console.Write($"{i} ");
                }
                else
                {
                    if (leftSum < rightSum)
                    {
                        leftSum += middleNumber;

                    }
                    else
                    {
                        rightSum += middleNumber;
                    }

                    if (leftSum == rightSum)
                    {
                        Console.Write($"{i} ");
                    }
                }

            }
        }
    }
}
