﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace StudentDiary
{
    class Program
    {
        static void GiveName(ref Diary diary)
        {
            diary = new Diary();
            diary.Name = "Nowy Dzienniczek Marcina";
        }

        static void IncreamentNum(ref int number)
        {
            number += 1;
        }

        static int IncrementNum2(int number)
        {
            number += 1;
            return number;
        }

        static void Main(string[] args)
        {
            ///PassivValueAndRef();

            ///Immutable();

            Arrays();

            SpeechSynthesizer synt = new SpeechSynthesizer();

            synt.Speak("Czesc");

            Console.ReadKey();


        }

        private static void Arrays()
        {
            float[] ratings;
            ratings = new float[4];

            AddRatings(ratings);

            foreach (var rating in ratings)
            {
                Console.WriteLine(rating);
            }

        }

        private static void AddRatings(float[] ratings)
        {
            if (ratings.Length <= 4)
            {
                ratings[0] = 3.4f;
                ratings[1] = 4.1f;
                ratings[2] = 10.4f;
                ratings[3] = 1.5f;
            }
        }

        

        private static void Immutable()
        {
            string name = "    Mateusz    ";
            name = name.Trim();

            DateTime date = new DateTime(2015,3,10);

            date = date.AddHours(48);

            Console.WriteLine(date);

            Console.WriteLine(name);
        }

        private static void PassivValueAndRef()
        {
            Diary d1 = new Diary();
            Diary d2 = d1;
            GiveName(ref d2);
            Console.WriteLine(d2.Name);

            int x1 = 4;
            IncreamentNum(ref x1);
            Console.WriteLine(x1);

            int x2 = 6;
            x2 = IncrementNum2(x2);

            Console.WriteLine(x2);
        }


        ///string name1 = "Mateusz";
        ///string name2 = "mateusz";

        ///bool comp = name1.Equals(name2);

        ///Console.WriteLine(comp);


        //Diary diary = new Diary();
        //diary.AddRating(5);
        //diary.AddRating(8.5f);
        //diary.AddRating(4.7f);

        //Diary diary2 = new Diary();
        //Diary diary3 = new Diary();
        //Diary diary4 = new Diary();
        //Diary diary5 = new Diary();


        //Console.WriteLine(Diary.Count);

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
