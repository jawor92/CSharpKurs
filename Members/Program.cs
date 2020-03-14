
using System;

namespace Members
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();

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
 