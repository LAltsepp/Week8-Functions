using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma nimi");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta oma sünniaastat:");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta oma perekonnanimi");
            string lastName = Console.ReadLine();
            
            //lisa perekonna nimi
            Greetings(userName, userAge, lastName);
        }

        private static void Greetings(string someString, int someInt, string someText)
        {
            Console.WriteLine($"Tere, {someString} {someText}!");
            Console.WriteLine($"Oled {2021 - someInt}.");
        }

    }
}
