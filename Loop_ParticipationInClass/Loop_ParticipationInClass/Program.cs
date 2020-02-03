using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_ParticipationInClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number do you want to count to? >>");
            int threshold = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= threshold; i++)
            {
                Console.Write(i + " ");
            }

            double sum = 0;
                string answer;
            do
            {
                Console.WriteLine("Please give us a # to add >>");
                int number = Convert.ToInt32(Console.ReadLine());
                sum += number;

                Console.WriteLine("Do you have another # to add? (y,n) >>");
                answer = Console.ReadLine();

            } while (answer == "y");

            Console.WriteLine($"Your summation of values is {sum.ToString("N2")}")

            Console.ReadKey();
        }
    }
}
