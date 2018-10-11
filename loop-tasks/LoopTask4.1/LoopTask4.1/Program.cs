﻿using System;

namespace LoopTask4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rndNumber;
                     
            Console.WriteLine("Ohjelma tulostaa 10 arvottua kokonaislukua ja niiden neliöjuuret.");
            Console.WriteLine("#\tRND\tSQRT");
            #region for example
            //for (int i = 0; i < 10; i++)
            //{
            //    rndNumber = rnd.Next(2, 10);
            //    Console.WriteLine($"{i + 1}.\t{rndNumber}\t{Math.Sqrt(rndNumber)}");
            //}
            #endregion
            int i = 0;
            #region while example
            //while (i<10)
            //{
            //    rndNumber = rnd.Next(2, 10);
            //    Console.WriteLine($"{i + 1}.\t{rndNumber}\t{Math.Sqrt(rndNumber)}");
            //    i = i + 1; //i++
            //}
            #endregion
            do
            {
                rndNumber = rnd.Next(2, 10);
                Console.WriteLine($"{i + 1}.\t" +
                    $"{rndNumber}\t" +
                    $"{Math.Sqrt(rndNumber)}");
                i = i + 1; //i++
            } while (i < 10);


        }
    }
}
