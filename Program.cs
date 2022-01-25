using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudyChapter2
{
    [TestClass]
    class Program
    {
        static void Main(string[] args)
        {
            //2차원 배열 Test
            //int[][] testArray = new int[2][];

            //while (true)
            //{
            //    var line = Console.ReadLine();
            //    if (int.TryParse(line, out var input))
            //    {
            //        Console.WriteLine(Study.IsLeapYear(input) ? "윤년" : "평년");
            //    }
            //    else { Console.WriteLine("다시입력"); }
            //}

            //var study = new Study();

            //생성자 메소드, static 키워드가 없으므로 인스턴스의 멤버 메소드로 호출하는 방식
            //StudySort.LinearSearchRandom(); // 2022-01-05 Linear Search19

            //StudySort.LinearSearchChapter63(); // 2022-01-06 Linear Search (Find Index, search count)
            //var watch = System.Diagnostics.Stopwatch.StartNew();
            //StudySort.BinarySearchSearchChapter63(); // 2022-01-06 Binary Search (Find Index, search count)
            //watch.Stop();

            //var elapsedMs = watch.ElapsedMilliseconds;
            //Console.WriteLine($"Normal Binary Search Elapsed Ms: {elapsedMs}");

            //StudySort.BubbleSotringChapter64(); //2022-01-07 Bubble Sotring

            ////스태틱 메소드, 인스턴스를 만들지 않고 바로 호출할 수 있음
            //ExampleStaticMethod(testArray);

            //var result = Study.CompareValue(54, 11, 77); //2022-01-08 Chapter 70
            //Console.WriteLine($"가장 큰 값: {result}");

            //Study.FindPrimeNumber(100);

            //Study.IsLeapYear(2022); // Chapter 72
            //Study.FindLeapYear(1992, 2022);
            //Study.CalculateAge(1992, 8, 1);

            //Study.Factorial(10); //2022-01-11 Chapter 75
            //Study.Add(1, 100); //Chpater 76
            //Study.Add(101, 200);
            //Study.Power(2, 20); //Cahpter 77
            //Study.AreaOfCircle(10);

            //TODO::
            //Study.CalculateAge(1992, 4, 27);
            //Study.TestCalculateAge(new DateTime(1992, 4, 27), DateTime.Today);
            //Study.TestCalculateAge(new DateTime(1992, 4, 27), DateTime.Today.AddMonths(1));

            //var powerResult = StudyRecurison.RecurisonPower(5, 5);
            //Console.WriteLine($"Result of Recurison Power Method: {powerResult}");

            //var factorialResult = StudyRecurison.RecurisonFactorial(10);
            //Console.WriteLine($"Result of Recurison Power Method: {factorialResult}");

            //watch = System.Diagnostics.Stopwatch.StartNew();
            //StudyRecurison.RecurisonBinarySearch();
            //watch.Stop();

            //elapsedMs = watch.ElapsedMilliseconds;
            //Console.WriteLine($"Recurion Binary Search Elapsed Ms: {elapsedMs}");

            //Study.TestCalculateAge(new DateTime(1992, 1, 27), DateTime.Today); //10949, 10948

            Study.TestCalculateAge(new DateTime(1992, 1, 27), new DateTime(2020, 1, 15));
            Study.TestCalculateAge(new DateTime(1992, 1, 27), new DateTime(2020, 3, 15));

            Study.TestCalculateAge(new DateTime(1992, 4, 27), new DateTime(2020, 1, 15));
            Study.TestCalculateAge(new DateTime(1992, 4, 27), new DateTime(2020, 3, 15));

            Study.TestCalculateAge(new DateTime(1992, 12, 27), new DateTime(2020, 3, 15));
            Study.TestCalculateAge(new DateTime(1992, 12, 27), new DateTime(2020, 1, 15));

            Study.TestCalculateAge(new DateTime(2020, 12, 3), new DateTime(2020, 12, 15));
            Study.TestCalculateAge(new DateTime(2019, 12, 3), new DateTime(2020, 12, 15));
        }

        private static void ExampleStaticMethod(int[][] array)
        {
            array[0] = new int[] { 1, 2 };
            array[1] = new int[] { 3, 4, 5, 6, 7 };
        }
    }
}