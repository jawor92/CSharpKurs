
using System;

namespace Members
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();

            try
            {
                Console.WriteLine("Podaj imie");
                diary.Name = Console.ReadLine();
            }

            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Something went wrong");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            diary.NameChanged += OnNameChanged;
            diary.NameChanged += OnNameChanged2;
            diary.NameChanged += OnNameChanged3;
            diary.NameChanged += OnNameChanged4;
            diary.NameChanged += OnNameChanged4;
            diary.NameChanged += OnNameChanged4;

            diary.Name = "Dziennik Mateusz";
            diary.Name = "Dziennik Doroty";
            diary.Name = "Dziennik X";

            Console.WriteLine(diary.Name);
        }

        private static void OnNameChanged(object sender, NamedChangedEventArgs args)
        {
            Console.WriteLine($"Zmiana nazwy z {args.ExistingName} na {args.NewName}");
        }

        private static void OnNameChanged2(object sender, NamedChangedEventArgs argse)
        {
            Console.WriteLine("*****************");
        }

        private static void OnNameChanged3(object sender, NamedChangedEventArgs argse)
        {
            Console.WriteLine("++++++++++++++++++");
        }

        private static void OnNameChanged4(object sender, NamedChangedEventArgs argse)
        {
            Console.WriteLine("----------------");
        }
    }
}
 