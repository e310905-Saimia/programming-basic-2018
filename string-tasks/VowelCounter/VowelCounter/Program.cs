using System;

namespace VowelCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää sanassa tai lauseessa olevien vokaalien lukumäärän");
            string userInput = UserInput();
            string removedUserInput = VowelsRemove(userInput);
            Console.WriteLine($"Vokaaleita sanassa {userInput} on {userInput.Length-removedUserInput.Length}");
        }

        static string UserInput()
        {
            Console.Write("Syötä sana tai lause: ");
            return Console.ReadLine().ToUpper();
        }

        static string VowelsRemove(string d)
        {         
            for (int i = 0; i < d.Length; i++)
            {
                if (d[i] == 'A' || d[i] == 'E' || d[i] == 'I' || d[i] == 'O' || d[i] == 'U' || d[i] == 'Y' || d[i] == 'Ä' || d[i] == 'Ö')
                {
                    d = d.Remove(i, 1);
                    i--;
                }
            }
            return d;
        }
    }
}
