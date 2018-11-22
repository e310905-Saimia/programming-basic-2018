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
                Console.WriteLine(GetStars(numbers[i]));
                //PrintStars(numbers[i]);
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

        /// <summary>
        /// Palauttaa tähtien määrän.
        /// length = tähtien määrä
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        static string GetStars(int length)
        {
            string returnStars = "";
            for (int i = 0; i < length; i++)
            {
                returnStars += "* ";
                //returnStars = $"{returnStars}*"; 
            }
            return returnStars;
        }
    }
}
