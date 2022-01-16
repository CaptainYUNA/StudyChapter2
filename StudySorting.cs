using System;
using System.Collections.Generic;
using System.Text;

namespace StudyChapter2
{
    static partial class StudySort
    {
        //Chapter 63. Linear Search
        public static void LinearSearchChapter63()
        {
            int[] linearArray = GenerateArray(30, 1, 1000);

            PrintArray(linearArray, "생성된 배열: ");

            Console.WriteLine();
            Console.Write("선형 탐색을 수행할 값 입력: ");
            var searchValue = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < linearArray.Length; i++)
            {
                if (searchValue == linearArray[count])
                {
                    Console.WriteLine($"입력한 값의 인덱스: {count}");
                    Console.WriteLine($"소요 횟수: {count + 1}");

                    break;
                }

                count++;
            }
        }

        public static int[] GenerateArray(int size, int min, int max, int sid = 0)
        {
            var random = new Random();

            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(min, max);
            }

            return array;
        }

        public static void BinarySearchSearchChapter63()
        {
            int[] binaryArray = GenerateArray(30, 1, 1000);

            PrintArray(binaryArray, "생성된 배열: ");

            Array.Sort(binaryArray);

            PrintArray(binaryArray, "정렬된 배열: ");

            Console.WriteLine();
            Console.Write("이진 탐색을 수행할 값 입력: ");
            var searchValue = int.Parse(Console.ReadLine());

            int count = 1;
            int min = 0;
            int max = binaryArray.Length - 1;
            int mid = (min + max) / 2;

            while (min <= max)
            {
                if (searchValue == binaryArray[mid])
                {
                    Console.WriteLine($"이진 탐색 수행 결과 ---> 인덱스: {mid} / 수행 횟수: {count}");
                    break;
                }

                if (searchValue > binaryArray[mid])
                {
                    mid = (mid + max) / 2;
                    count += 1;
                    min = mid + 1;
                }
                else if (searchValue < binaryArray[mid])
                {
                    mid = (min + mid) / 2;
                    count += 1;
                    max = mid - 1;
                }
            }
        }

        public static void BubbleSotringChapter64()
        {
            int[] bubbleArray = GenerateArray(5, 0, 50);

            PrintArray(bubbleArray, "생성된 배열: ");
            Console.WriteLine();

            for (int i = bubbleArray.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine($"현재 비교 값의 index ---> [{j}]: {bubbleArray[j]}, [{j + 1}]: {bubbleArray[j + 1]}");

                    if (bubbleArray[j] > bubbleArray[j + 1])
                    {
                        var temp = bubbleArray[j];
                        bubbleArray[j] = bubbleArray[j + 1];
                        bubbleArray[j + 1] = temp;

                        PrintArray(bubbleArray, "현재 배열: ");
                    }
                }
            }

            PrintArray(bubbleArray, "정렬된 배열: ");
        }

        public static void PrintArray(int[] array, string message)
        {
            Console.Write($"{message}");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();
        }
    }
}

