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
            Diary diary = new Diary()  ;
            //diary.AddRating(5);
            //diary.AddRating(8.5f);
            //diary.AddRating(4.7f);

            //float avg = diary.CalcualteAvarage();
            //float max = diary.GetMaxRating();
            //float min = diary.GetMinRating();

            for (;;)
            {
                Console.WriteLine("Podaj ocenę z zakresu 1 - 10");

                float rating;
                    
                bool result = float.TryParse(Console.ReadLine(), out rating);

                //if (rating > 10)
                //{
                //    break;
                //}

                if (result)
                {
                    if (rating >= 1 && rating <= 10)
                    {
                        diary.AddRating(rating);
                    }

                    else
                    {
                        Console.WriteLine("Podana liczba jest spoza dopuszczalnego zakresu");
                        break;
                    }
                }

                else
                {
                    Console.WriteLine("Podana wartosc nie jest liczba");
                }


            }

            Console.WriteLine("Srednia wprowadzony ocen to:" + diary.CalcualteAvarage());

            Console.WriteLine("Maksymalna ocena to:" + diary.GetMaxRating());

            Console.WriteLine("Minimalna ocena to:" + diary.GetMinRating());

            Console.ReadKey();
        }
    }
}
