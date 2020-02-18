using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentDiary
{
    class Diary
    {
        public Diary()
        {
            ratings = new List<float>();
            Count++;
        }

        // Stany (zmienne - pola)
        private List<float> ratings;

        public static float MinxGrade = 0;
        public static float MaxGrade = 0;
        public static long Count = 0;

        //Zachowania
        /// <summary>
        /// Adding ratings
        /// </summary>
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }
        /// <summary>
        /// Statistics: avg, max, min ratings
        /// </summary>
        /// <returns></returns>
        internal DiaryStatistics ComputeStatistics()
        {
            DiaryStatistics stats = new DiaryStatistics();

            float sum = 0f;

            foreach (var rating in ratings)
            {
                sum += rating;
            }

            stats.AvgarageGrade = sum / ratings.Count();
            stats.MaxGrade = ratings.Max();
            stats.MinGrade = ratings.Min();

            return stats;
        }

    }
}




