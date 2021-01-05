using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            int money = int.Parse(Console.ReadLine());
            int clothesCount = 0;
            int spentMoney = 0;
            string command = "";

            while ((command = Console.ReadLine()) != "enough" )
            {
                

                if (command =="enter")
                {
                    string input = "";
                    while (money > 0 && (input = Console.ReadLine()) != "leave")
                    {
                        
                        int cost = int.Parse(input);
                        if (money < cost)
                        {
                            Console.WriteLine("Not enough money.");
                            continue;
                        }
                        else
                        {
                            money -= cost;
                            spentMoney += cost;
                            clothesCount++;

                            
                        }
                    }

                    if (money <= 0)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine($"For {clothesCount} clothes I spent {spentMoney} lv and have {money} lv left.");
        }
    }
}
