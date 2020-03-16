using System;

namespace FlowControl
{
    class Program
    {
        private static int age;
        private static string name;
        private static string number;

        static void Main(string[] args)
        {
            //InstructionIf();

            Console.WriteLine("Insert value");
            number = Console.ReadLine();


            switch (number)
            {
                case "1":
                    Method1();
                    break;

                case "2":
                    Method2();
                    break;

                case "3":
                    Method3();
                    break;

                default:
                    Method4();
                    break;
            }

            Console.ReadKey();
        }

        private static void InstructionIf()
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
