using System;
using System.Collections.Generic;
using System.Linq;

namespace Class_variable___theory
{
    class Diary
    {
        public Diary()
        {
            ratings = new List<float>();
        }

        // Stany (zmienne - pola)
        List<float> ratings;

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




