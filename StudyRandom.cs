using System;
using System.Collections.Generic;
using System.Text;

namespace StudyChapter2
{
    partial class StudySort
    {
        //Chapter 62.
        public static void LinearSearchRandom()
        {
            Console.Write("배열의 크기를 입력하세요. : ");

            int size = int.Parse(Console.ReadLine());

            var random = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(size);
            }

            int min = array[0];
            int max = array[0];

            for (int i = 0; i < size; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }

                if (min > array[i])
                {
                    min = array[i];
                }
            }

            double average = (max + min) / 2;

            int arraySum = 0;

            for (int i = 0; i < size; i++)
            {
                arraySum += array[i];
            }

            double arrayAverage = arraySum / size;

            Console.WriteLine($"최소값: {min}, 최대 값: {max}, 두 값의 평균: {average}");
            Console.WriteLine($"랜덤 배열의 전체 합계: {arraySum}, 전체 평균: {arrayAverage}");
        }
    }
}
