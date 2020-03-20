using System;

namespace FlowControl
{
    class Program
    {
        private static int age;
        private static string name;
        private static string number;
        private static int m;

        static void Main(string[] args)
        {
            //InstructionIf();
            //Switch();
            //ForLoop();
            //int i = WhileLoop();
            //int i = DoWhileLoop(i);
            //ForEachLoop();

            int[] ages = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //foreach (var age in ages)
            //{
            //    if (age == 2)
            //    {
            //        Console.WriteLine("Age = {0}", age);
            //        continue;
            //        Console.WriteLine("Hello");
            //    }

            //    if (age == 4)
            //    {
            //        Console.WriteLine("Age = {0}", age);
            //        break;
            //        Console.WriteLine("Hello");
            //    }
            //}            

            //foreach (var age in ages)
            //{
            //    if (age == 2)
            //    {
            //        Console.WriteLine("Age = {0}", age);
            //        goto skip;
            //    }
            //}

            //skip:
            //Console.WriteLine("Hello");

            CheckAge(ages);

            //Console.ReadKey();

        }

        #region private methods
        private static void CheckAge(int[] ages)
        {
            foreach (var age in ages)
            {
                if (age == 3)
                {
                    Console.WriteLine("Age = {0}", age);
                    return;
                }
            }
        }

        private static void ForLoop()
        {
            for (int x = 1; x <= 6; x++)
            {
                for (int y = 1; y <= 6; y++)
                {
                    m = x * y;
                    Console.WriteLine("Wartość x: {0} oraz wartosc y: {1}. Mnoznik: {2}", x, y, m);
                }

            }
        }

        private static void ForEachLoop()
        {
            int[] tab = { 1, 2, 3, 4, 5, 6, 25, 423 };

            foreach (var item in tab)
            {
                Console.WriteLine("Wartosc x z tablicy to: {0}", item);
            }
        }

        private static int DoWhileLoop(int i)
        {
            
            do
            {
                Console.WriteLine("Wartosc i: {0}", i);
                i++;
            } while (i > 3);
            return i;
        }

        private static int WhileLoop()
        {
            int i = 1;

            while (i < 3)
            {
                Console.WriteLine("Wartosc i: {0}", i);
                i++;
            }

            return i;
        }

        private static void Switch()
        {
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
        #endregion
    }
}
