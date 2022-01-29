using Microsoft.VisualStudio.TestTools.UnitTesting;

using StudyChapter2;

using System;

namespace CoverageTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Study.TestCalculateAge(new DateTime(1992, 1, 27), new DateTime(2020, 1, 15));
            Study.TestCalculateAge(new DateTime(1992, 1, 27), new DateTime(2020, 3, 15));
            Study.TestCalculateAge(new DateTime(1992, 4, 27), new DateTime(2020, 1, 15));

            Study.TestCalculateAge(new DateTime(1992, 4, 27), new DateTime(2020, 3, 15));
            Study.TestCalculateAge(new DateTime(1992, 12, 27), new DateTime(2020, 3, 15));
            Study.TestCalculateAge(new DateTime(1992, 12, 27), new DateTime(2020, 1, 15));
            Study.TestCalculateAge(new DateTime(2020, 12, 3), new DateTime(2020, 12, 15));
            Study.TestCalculateAge(new DateTime(2019, 12, 3), new DateTime(2020, 12, 15));
            Study.TestCalculateAge(new DateTime(2019, 11, 3), new DateTime(2019, 12, 15));
            Study.TestCalculateAge(new DateTime(2019, 2, 3), new DateTime(2019, 12, 15));
            Study.TestCalculateAge(new DateTime(2018, 12, 3), new DateTime(2019, 12, 15));
            Study.TestCalculateAge(new DateTime(2016, 2, 3), new DateTime(2016, 12, 15));
            Study.TestCalculateAge(new DateTime(2018, 11, 3), new DateTime(2019, 12, 15));
        }
    }
}
