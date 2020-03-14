using System;
using System.Collections.Generic;
using System.Linq;

namespace Members
{
    public class Diary
    {
        public Diary()
        {
            ratings = new List<float>();
        }

        // Stany (zmienne - pola)
        private List<float> ratings;

        private string _name;

        public string Name
        {
            get
            {
                return _name.ToUpper();
            } 
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (_name != value)
                    {
                        NamedChangedEventArgs args = new NamedChangedEventArgs();

                        args.ExistingName = _name;
                        args.NewName = value;

                        NameChanged(this, args);
                    }

                    _name = value;
                }
            }
        }

        //Delegate

        public NamedChangedDelagte NameChanged;


        public DiaryStatistics com;

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
        public DiaryStatistics ComputeStatistics()
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




