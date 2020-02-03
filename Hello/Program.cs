

using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueType();

            for (; ; )
            {
                Greeting();

                Statements_age();

                Settings();
            }

        }

        /// <summary>
        /// Wartosci max
        /// </summary>
        private static void ValueType()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("Max Int: " + maxInt);
            Console.WriteLine("Min Int: " + minInt);
            Console.WriteLine("Max Long: " + maxLong);
            Console.WriteLine("Min Long: " + minLong);
        }

        /// <summary>
        /// Ustawienia
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

        /// <summary>
        /// Warunki
        /// </summary>
        private static void Statements_age()
        {
            Console.Write("Wpisz ile masz lat: ");
            int age;

            bool result = int.TryParse(Console.ReadLine(), out age);

            //Parse lub TryParse - konwersja z liter na int

            if (age >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Brawo! Piwo dla Ciebie");
            }

            else if (result == false)
            {
                Console.WriteLine("Wymagana jest liczba");
            }

            else
            {
                Console.WriteLine("Jestes niepelnoletni");
            }
        }


        /// <summary>
        /// Wpisujemy powitanie uzytkownika
        /// </summary>
        private static void Greeting()
        {
            Console.Write("Wpisz swoje imię: ");
            string name = Console.ReadLine();

            Console.WriteLine("Witaj " + name + "!");
        }
    }
}

