﻿using System;

namespace FunctionTask5_2
{
    class Program
    {
        static void Main(string[] args)
        {            
            Intro(out int x, out int y);
            PrintData(SmallerNumber(x, y));
        }

        static void Intro(out int number1, out int number2)
        {
            Console.WriteLine(" Ohjelma palauttaa kahdesta annetusta luvusta pienemmän!");
            Console.Write("Syötä 1. luku: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Syötä 2. luku: ");
            number2 = int.Parse(Console.ReadLine());
        }

        static string SmallerNumber(int a, int b)
        {
            if (a == b)
                return $"Luku {a} on yhtäsuuri kuin {b}";
            else if (a < b)
                return $"Luku {a} on pienempi kuin {b}";
            else
                return $"Luku {b} on pienempi kuin {a}";
        }

        static string SmallerNumber2(int a, int b)
        {
            string result = "";
            
            if (a == b)
                result =  $"Luku {a} on yhtäsuuri kuin {b}";
            else if (a < b)
                result = $"Luku {a} on pienempi kuin {b}";
            else
                result = $"Luku {b} on pienempi kuin {a}";

            return result;
        }

        static void PrintData(string data)
        {
            
            Console.WriteLine(data);
        }
    }
}
