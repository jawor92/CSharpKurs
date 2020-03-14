
using System;

namespace Members
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();

            diary.NameChanged += new NamedChangedDelagte(OnNameChanged);
            diary.NameChanged += new NamedChangedDelagte(OnNameChanged2);
            diary.NameChanged += new NamedChangedDelagte(OnNameChanged3);
            diary.NameChanged += new NamedChangedDelagte(OnNameChanged4);
            diary.NameChanged += new NamedChangedDelagte(OnNameChanged4);
            diary.NameChanged += new NamedChangedDelagte(OnNameChanged4);

            diary.Name = "Dziennik Mateusz";
            diary.Name = "Dziennik Doroty";
            diary.Name = "Dziennik X";

            Console.WriteLine(diary.Name);
        }

        private static void OnNameChanged(string existingName, string newName)
        {
            Console.WriteLine($"Zmiana nazwy z {existingName} na {newName}");
        }

        private static void OnNameChanged2(string existingName, string newName)
        {
            Console.WriteLine("*****************");
        }

        private static void OnNameChanged3(string existingName, string newName)
        {
            Console.WriteLine("++++++++++++++++++");
        }

        private static void OnNameChanged4(string existingName, string newName)
        {
            Console.WriteLine("----------------");
        }
    }
}
 