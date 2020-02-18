using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {

            Diary diary = new Diary();
            diary.AddRating(5);
            diary.AddRating(8.5f);
            diary.AddRating(4.7f);

            Diary diary2 = new Diary();
            Diary diary3 = new Diary();
            Diary diary4 = new Diary();
            Diary diary5 = new Diary();


            Console.WriteLine(Diary.Count);

            ///DiaryStatistics stats = diary.ComputeStatistics();

            ///Console.WriteLine("Srednia wartość ocen: " +  stats.AvgarageGrade);
            ///Console.WriteLine("Maksymalna wartosc: " + stats.MaxGrade);
            ///Console.WriteLine("Minimalna wartosc: " + stats.MinGrade);

            ///Diary diary2 = new Diary();
            ///diary2.AddRating(1);
            ///diary2.AddRating(2);
            ///diary2.AddRating(3);

            ///DiaryStatistics stats2 = diary2.ComputeStatistics();

            ///Console.WriteLine("Srednia wartość ocen: " + stats2.AvgarageGrade);
            ///Console.WriteLine("Maksymalna wartosc: " + stats2.MaxGrade);
            ///Console.WriteLine("Minimalna wartosc: " + stats2.MinGrade);


        }
    }
}
