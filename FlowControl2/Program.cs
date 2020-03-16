using System;

namespace FlowControl
{
    class Program
    {
        private static int age;
        private static string name;

        static void Main(string[] args)
        {
            //Console.WriteLine("Podaj swoj wiek");
            //age = int.Parse(Console.ReadLine());
            //string test = age > 18 ? "Pelnoletni" : "Dziecko";
            //Console.WriteLine(test);


            Console.WriteLine("Podaj swój wiek i imię");
            age = int.Parse(Console.ReadLine());
            name = Console.ReadLine();

            if (age <= 10)
            {
                if (name == "Marcin")
                {
                    Method1();
                }
                else
                {
                    Console.WriteLine("Bledne imie");
                }
            }

            else if (age < 20)
            {
                Method2();
            }

            else if (age < 30)
            {
                Method3();
            }

            else
            {
                Method4();
            }

            Console.ReadKey();
        }

        private static void Method4()
        {
            Console.WriteLine("Masz 30 lub więcej lat");
        }

        private static void Method3()
        {
            Console.WriteLine("Twój wiek jest większy od 20 a mniejszy o 39 i wynosi: " + age);
        }

        private static void Method2()
        {
            Console.WriteLine("Twój wiek jest większy od 10 a mniejszy o 20 i wynosi: " + age);
        }

        private static void Method1()
        {
            Console.WriteLine("Masz 10 lub mniej lat Twój wiek to: " + age);
        }
    }
}
