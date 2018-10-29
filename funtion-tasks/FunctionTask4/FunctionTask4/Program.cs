using System;

namespace FunctionTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            int indx=0;
            Console.WriteLine("Syötä 10 lukua");
            Console.WriteLine($"Suurin luku {LargesNumber(ref indx)} oli {indx}.");
            //Console.WriteLine($"Suurin luku {LargesNumber(out int indx)} oli {indx}.");
        }

        static int LargesNumber(ref int indx)
        {
            //indx = 0;
            int largesNumber=0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}. ");
                int userNumber = int.Parse(Console.ReadLine());
                if (userNumber < 0)
                {
                    Console.WriteLine("Väärä syöte, syötä positiivinen luku");
                    i--;
                }

                if (userNumber > largesNumber)
                {
                    largesNumber = userNumber;
                    indx = i + 1;
                }

            }
            return largesNumber;
        }
    }
}
