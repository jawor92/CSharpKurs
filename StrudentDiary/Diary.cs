using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentDiary
{
    class Diary
    {
        // Stany (zmienne - pola)
        List<float> ratings = new List<float>();

        //Zachowania
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }

        public float CalcualteAvarage()
        {
            float sum = 0, avg = 0;

            foreach (var rating in ratings)
            {
                sum += rating;
            }

            avg = sum / ratings.Count();

            return avg;
        }

        public float GetMaxRating()
        {
            return ratings.Max();
        }

        public float GetMinRating()
        {
            return ratings.Min();
        }

    }
}




