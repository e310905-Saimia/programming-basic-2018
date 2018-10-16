using System;

namespace LoopTask4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma simuloi kolikon heittoa!");
            Console.Write("Kuinka monta kertaa kolikkoa heitetään? ");
            int counter = int.Parse(Console.ReadLine());
            int heads = 0;
            int tails = 0;
            Random rnd = new Random();
            int rndNumber;
            for (int i = 0; i < counter; i++)
            {
                rndNumber = rnd.Next(2);
                if (rndNumber == 0)
                    tails++;
                else
                    heads++;
            }

            Console.WriteLine($"Rahaa on heitetty {rndNumber} kertaa.");
            Console.WriteLine($"Klaavoja tuli {tails} ja kruunuja {heads}.");
        }
    }
}
