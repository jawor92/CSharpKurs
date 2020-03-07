
using System;

namespace Members
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            diary.AddRating(9.5f);
            diary.AddRating(5.4f);
            diary.AddRating(8.4f);

            DiaryStatistics stats = diary.ComputeStatistics();
            WriteResult("Srednia", stats.AvgarageGrade, 3,5,7,8,9);
            WriteResult("Maksymalna ocena", (int)stats.MaxGrade);
            WriteResult("Minimalna ocena", (long)stats.MinGrade);
            WriteResult("Minimalna ocena", stats.MinGrade, 1);
        }

        static void WriteResult(string description, params float[] result)
        {
            Console.WriteLine(description + ": " + result[0] + "   ----  " + result[4]);
        }

        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, long result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, float result, long test)
        {
            Console.WriteLine(description + ": " + result + ", " + test);
            Console.WriteLine("{0}: {1:C1} {2}: {3}: {4}: {5}:", description, result, 2,3,4,5);
            Console.WriteLine($"{description}: {result:C1} {2}: {3}: {4}: {5}:"); ///added in C# v.6
        }
    }
}
