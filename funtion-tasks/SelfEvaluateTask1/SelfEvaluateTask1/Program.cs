using System;

namespace SelfEvaluateTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tulostaa tähtiä. Ohjelman suoritus alkaa 3 sekunnin kuluttua.");
            Delay();
            int[] numbers = new int[] { 2, 5, 10, 7, 3 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(GetStars(numbers[i]));
                //PrintStars(numbers[i]);
            }           
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
                returnStars += "*";
                //returnStars = $"{returnStars}*"; 
            }
            return returnStars;
        }

        static void Delay()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine();
        }
    }
}
