using System;

namespace UITest
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            string msg = string.Empty;
            do
            {            
                cki = UserInterface();
                switch (cki.Key)
                {
                    case ConsoleKey.F1:
                        msg = "\nTiedostoon kirjoitus on päättynyt! \nPaina Enter jatkaaksesi!";
                        break;

                    case ConsoleKey.F2:
                        msg = "\nTiedoston loppuun kirjoitus on päättynyt! \nPaina Enter jatkaaksesi!";
                        break;
                    case ConsoleKey.N:
                        msg = "\nTiedoston lukeminen on päättynyt! \nPaina Enter jatkaaksesi!";
                        break;
                    case ConsoleKey.Escape:
                        msg = "\nOhjelman suoritus päättyy!";
                        break;
                    default:
                        msg = "Nyt tuli huti yritä uudestaan - Paina Enter ja aloita alusta!";
                        break;
                }                
                Console.WriteLine(msg);
                Console.ReadLine();
                Console.Clear();
            } while (cki.Key != ConsoleKey.Escape);

            Console.WriteLine("Ohjelman suoritus päättyi!");
        }


        
        static ConsoleKeyInfo UserInterface()
        {            
            Console.WriteLine("Tiedoston käsittely esimerkki!");
            Console.WriteLine("[F1] Kirjoita tiedostoon - Tekee kokonaan uuden");
            Console.WriteLine("[F2] Kirjoita tiedoston loppuun - Lisätään tiedostoon tietoja");
            Console.WriteLine("[N] Näytä tiedoston sisältö");
            Console.WriteLine("[ESC] Lopeta ohjelmansuoritus");
            Console.WriteLine();
            Console.Write("Valitse mitä tehdään: ");

            return Console.ReadKey();
        }
    }
}
