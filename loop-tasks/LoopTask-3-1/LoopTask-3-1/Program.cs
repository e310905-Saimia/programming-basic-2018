using System;

namespace LoopTask_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee annetun luvun kertoman.");
            int number = 0;
            int i = 1;
            int fact = 1;

            //Check that number is positive number
            do
            {
                Console.Write("Syötä luku: ");
                //string userInput = Console.ReadLine();
                //number = int.Parse(userInput);
                number = int.Parse(Console.ReadLine());

                if (number <= 0)
                {
                    Console.WriteLine("Virheellinen syöte!");                   
                }
                else
                {
                    break;
                }

            } while (true);

            // Calculate factorial 1 * 2 * 3 * ... * n
            while (i <= number)
            {
                fact = fact * i;    //fact*=i
                i = i + 1;          //i++;
            }
            //for (i = 1; i <= number; i++)
            //{
            //    fact *= i;
            //}
            Console.WriteLine($"Luvun {number}! = {fact}");
        }
    }
}
