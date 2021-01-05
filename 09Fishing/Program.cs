using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Fishing
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalFishes = int.Parse(Console.ReadLine());
            
            
            double income = 0;
            double paid = 0;
            int fish = 0;

            string fishName = "";

            while ((fishName = Console.ReadLine()) != "Stop")
            {
                double currentFishPrice = 0;
                int sumLetters = 0;
                double fishKg = double.Parse(Console.ReadLine());

                fish++;

                if (fish % 3 == 0)
                {
                    
                    for (int i = 0; i < fishName.Length; i++)
                    {
                        sumLetters += fishName[i];
                    }
                    currentFishPrice = sumLetters / fishKg;
                    income += currentFishPrice;
                }
                else
                {

                    for (int i = 0; i < fishName.Length; i++)
                    {
                        sumLetters += fishName[i];
                    }
                    currentFishPrice = sumLetters / fishKg;
                    paid += currentFishPrice;
                }

                if (fish == totalFishes)
                {
                    Console.WriteLine("Lyubo fulfilled the quota!");
                    break;
                }
            }

            if (income >= paid)
            {
                Console.WriteLine($"Lyubo's profit from {fish} fishes is {(income - paid):f2} leva.");
            }
            else
            {
                Console.WriteLine($"Lyubo lost {(paid - income):f2} leva today.");
            }

        }
    }
}
