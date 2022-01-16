using System;
using System.Collections.Generic;
using System.Text;

namespace StudyChapter2
{
    public static class StudyRecurison
    {
        public static int RecurisonFactorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * RecurisonFactorial(n - 1);
            }
        }

        public static int RecurisonPower(int x, int y)
        {
            if (y == 0)
            {
                return 1;
            }
            else
            {
                return x * RecurisonPower(x, y - 1);
            }
        }

        public static double RecurisonSumInverseNumber(double n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return 1.0 / n + RecurisonSumInverseNumber(n - 1);
            }
        }

        public static void RecurisonTowerOfHanoi(int n, char from, char to, char by)
        {
            if (n == 1)
            {
                Console.WriteLine($"[{from} 기둥] -> [{by} 기둥]");
            }
            else
            {
                RecurisonTowerOfHanoi(n - 1, from, by, to);
                Console.WriteLine($"[{from} 기둥] -> [{to} 기둥]");
                RecurisonTowerOfHanoi(n - 1, by, to, from);
            }
        }

        public static void RecurisonBinarySearch()
        {
            var array = StudySort.GenerateArray(30, 1, 1000);

            StudySort.PrintArray(array, "정렬 전 값: ");

            Array.Sort(array);

            StudySort.PrintArray(array, "정렬 후 값: ");

            Console.WriteLine("찾을 값 입력: ");
            var key = int.Parse(Console.ReadLine());

            int start = 0;
            int end = array.Length - 1;
            int mid = (start + end) / 2;

            var index = InternalRecurisonBinarySearch(array, key, start, end, mid);

            if (index >= 0)
            {
                Console.WriteLine($"이진 탐색 수행 결과 ---> 인덱스: {index}");
            }
            else
            {
                Console.WriteLine($"값이 존재하지 않음.");
            }
        }

        private static int InternalRecurisonBinarySearch(int[] array, int key, int start, int end, int mid)
        {
            if (start <= end)
            {
                if (key == array[mid])
                {
                    return mid;
                }

                if (key > array[mid])
                {
                    start = mid + 1;
                    mid = (start + end) / 2;

                    return InternalRecurisonBinarySearch(array, key, start, end, mid);
                }

                else if (key < array[mid])
                {
                    end = mid - 1;
                    mid = (start + mid) / 2;

                    return InternalRecurisonBinarySearch(array, key, start, mid, end);
                }
            }

            return -1;
        }
    }
}
