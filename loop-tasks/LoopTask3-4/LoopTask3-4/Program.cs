using System;

namespace LoopTask3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //This algorithm based on flowchar by Rami Shemeikka look at in Moodle
            int number = 0;
            int i = 0;
            int sum = 0;

            Console.WriteLine("Ohjelma laskee N ensimmäistä lukua yhteen, myös negatiiviseen suuntaan.");
            
            do
            {
                Console.Write("Syötä luku: ");
                bool isNumber = int.TryParse(Console.ReadLine(), out number); 
                if (!isNumber)
                {
                    Console.Write("Virheellinen syöte!");
                }
                else
                {
                    break;
                }
            } while (true);            

            while (i != number)
            {
                if (number > 0)
                {
                    i++;
                }
                else
                {
                    i--;
                }
                sum = sum + i;
            }
            Console.WriteLine($"Vastaus: {sum}");
        }
    }
}
