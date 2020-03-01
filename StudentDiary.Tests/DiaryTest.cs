using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudentDiary.Tests
{
    [TestClass]
    public class DiaryTest
    {
        [TestMethod]
        public void CalculateMaxGrade()
        {
            Diary diary = new Diary();
            diary.AddRating(6f);
            diary.AddRating(4f);
            diary.AddRating(3f);

            DiaryStatistics stats = diary.ComputeStatistics();

            Assert.AreEqual(6f, stats.MaxGrade);

        }

        [TestMethod]
        public void PassiveValue()
        {
            Diary diary = new Diary();
            diary.Name = "Jacek";

            SetName(diary);

            Assert.AreEqual("Mateusz", diary.Name);
        }

        private void SetName(Diary diary)
        {
            diary.Name = "Mateusz";
        }

        [TestMethod]
        public void PassiveValueInt()
        {
            int x1 = 5;
            IncrementNumber(x1);

            Assert.AreEqual(5, x1);
        }

        private void IncrementNumber(int number)
        {
            number = 15;
        }

        [TestMethod]
        public void PassiveReferenceInt()
        {
            int x1 = 5;
            IncrementNumber(ref x1);

            Assert.AreEqual(15, x1);
        }
        private void IncrementNumber(ref int number)
        {
            number = 15;
        }
    }
}
