using System;

namespace Class_variable___theory
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            diary.AddRating(3);
            diary.AddRating(5);

            Diary diary2 = diary;
            diary2.AddRating(8);

            Diary diary3 = diary2;
            diary3.AddRating(1);

        }
    }
}
