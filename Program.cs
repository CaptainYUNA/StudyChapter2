using System;

namespace StudyChapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2차원 배열 Test
            int[][] testArray = new int[2][];

            while (true)
            {
                var line = Console.ReadLine();
                if (int.TryParse(line, out var input))
                {
                    Console.WriteLine(Study.IsLeapYear(input) ? "윤년" : "평년");
                }
                else { Console.WriteLine("다시입력"); }
            }

            //var study = new Study();

            //생성자 메소드, static 키워드가 없으므로 인스턴스의 멤버 메소드로 호출하는 방식
            //StudySort.LinearSearchRandom(); // 2022-01-05 Linear Search19

            //StudySort.LinearSearchChapter63(); // 2022-01-06 Linear Search (Find Index, search count)
            //StudySort.BinarySearchSearchChapter63(); // 2022-01-06 Binary Search (Find Index, search count)

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

            Study.CalculateAge(1992, 8, 1);
        }

        private static void ExampleStaticMethod(int[][] array)
        {
            array[0] = new int[] { 1, 2 };
            array[1] = new int[] { 3, 4, 5, 6, 7 };
        }
    }
}



