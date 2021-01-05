using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Party
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";

            bool isValid = true;

            double validNamesCount = 0;
            double invalidNamesCount = 0;
            double totalNamesCount = 0;


            while ((name = Console.ReadLine()) != "Statistic")
            {
                isValid = true;
                totalNamesCount++;

                for (int i = 0; i < name.Length; i++)
                {
                    if (!Char.IsLetter(name[i]))
                    {
                        Console.WriteLine("Invalid name!");
                        invalidNamesCount++;
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    validNamesCount++;
                    name = name[0].ToString().ToUpper() + name.Substring(1, name.Length - 1).ToLower();

                    Console.WriteLine(name);
                }
            }

            double peopleComingPercent = (validNamesCount / totalNamesCount) * 100;
            double peopleNotComingPercent = (invalidNamesCount / totalNamesCount) * 100;

            Console.WriteLine($"Valid names are {peopleComingPercent}% from {totalNamesCount} names.");
            Console.WriteLine($"Invalid names are {peopleNotComingPercent}% from {totalNamesCount} names.");

        }
    }
}
