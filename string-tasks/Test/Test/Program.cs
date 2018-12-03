using System;
using System.IO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string choise = null;
            string path = @"C:\TEMP\TESTI.DAT";
            string msg = "";
            do
            {
                choise = UserInterface();

                switch (choise.ToUpper())
                {
                    case "K":
                        WriteToFile(path);
                        msg = "\nTiedostoon kirjoitus on päättynyt! \nPaina Enter jatkaaksesi!";
                        break;
                    case "L":
                        AddDataToFile(path);
                        msg = "\nTiedoston loppuun kirjoitus on päättynyt! \nPaina Enter jatkaaksesi!";
                        break;
                    case "N":
                        ReadFile(path);
                        msg = "\nTiedoston lukeminen on päättynyt! \nPaina Enter jatkaaksesi!";
                        break;
                    case "X":
                        msg = "\nOhjelman suoritus päättyy!";
                        break;
                    default:
                        msg = "Nyt tuli huti yritä uudestaan - Paina Enter ja aloita alusta!";
                        break;
                }

                Console.WriteLine(msg);
                Console.ReadLine();
                Console.Clear();
            }
            while (choise.ToUpper() != "X");

        }


      
        static string UserInterface()
        {
            Console.WriteLine("Tiedoston käsittely esimerkki!");
            Console.WriteLine("[K] Kirjoita tiedostoon - Tekee kokonaan uuden");
            Console.WriteLine("[L] Kirjoita tiedoston loppuun - Lisätään tiedostoon tietoja");
            Console.WriteLine("[N] Näytä tiedoston sisältö");
            Console.WriteLine("[X] Lopeta ohjelmansuoritus");
            Console.WriteLine();
            Console.Write("Valitse mitä tehdään: ");

            return Console.ReadLine();
        }

        /// <summary>
        /// Write to file
        /// Create new file
        /// string filePath is 
        /// </summary>
        /// <param name="filePath"></param>
        static void WriteToFile(string filePath)
        {
            StreamWriter R = new StreamWriter(filePath);
            R.WriteLine("TERVE TAAS!");
            R.WriteLine(DateTime.Now.ToString());
            R.WriteLine($"Tiedoston sijainti on: \t\t{filePath}");
            R.Close();
        }

        static void ReadFile(string filePath)
        {
            StreamReader R = new StreamReader(filePath);
            string strRow = null;

            Console.WriteLine("Tiedostosta löytyy seuraavat rivit:\n");
            while ((strRow = R.ReadLine()) != null)
            {
                Console.WriteLine(strRow);
            }

            R.Close();
        }

        /// <summary>
        /// Append data to end of file
        /// </summary>
        /// <param name="filePath"></param>
        static void AddDataToFile(string filePath)
        {
            StreamWriter R = new StreamWriter(filePath, true);
            R.WriteLine("-----------------------------------------");
            R.WriteLine("TERVE TAAS!");
            R.WriteLine(DateTime.Now.ToString());
            R.WriteLine("Tiedoston sijainti on: \t\t{0}", filePath);
            R.Close();
        }
    }
}



