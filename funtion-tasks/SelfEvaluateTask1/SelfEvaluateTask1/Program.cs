using System;

namespace SelfEvaluateTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tulostaa tähtiä.");
            int[] numbers = new int[] { 2, 5, 10, 7, 3 };

            for (int i = 0; i < numbers.Length; i++)
            {
                PrintStars(numbers[i]);
            }
            //PrintStars(numbers[0]);
            //PrintStars(numbers[1]);
            //PrintStars(numbers[2]);
            //PrintStars(numbers[3]);
            //PrintStars(numbers[4]);
        }


        /// <summary>
        /// Tulostaa tähtiä.
        /// lenght = tähtien määrä
        /// </summary>
        /// <param name="length"></param>
        static void PrintStars(int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
