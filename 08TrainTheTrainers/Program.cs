using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int judges = int.Parse(Console.ReadLine());
            string presentationName = "";
            double totalGradesSum = 0;
            double currentPresentationGrade = 0;
            int gradesCount = 0;

            while ((presentationName = Console.ReadLine()) != "Finish")
            {
                currentPresentationGrade = 0;
                for (int i = 0; i < judges; i++)
                {
                    currentPresentationGrade += double.Parse(Console.ReadLine());
                    
                    gradesCount++;
                }

                totalGradesSum += currentPresentationGrade;
                double avarageGradeSum = currentPresentationGrade / judges;

                Console.WriteLine($"{presentationName} - {avarageGradeSum:f2}.");
               
            }

            Console.WriteLine($"Student's final assessment is {totalGradesSum/gradesCount:f2}.");
        }
    }
}
