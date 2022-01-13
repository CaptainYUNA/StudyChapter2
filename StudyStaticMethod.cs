﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StudyChapter2
{
    public static class Study
    {
        private static Dictionary<int, int> days = new Dictionary<int, int>();

        public static int CompareValue(int value1, int value2, int value3)
        {
            //int @return = Larger(value1, value2);
            //var result1 = @return;
            var result1 = Larger(value1, value2);
            var result2 = Larger(result1, value3);


            Larger(Larger(value1, value2), value2);
            return Larger(result1, result2);
        }

        public static int FindLeapYear(int minYear, int maxYear)
        {
            Console.WriteLine($"{minYear} ~ {maxYear}년 사이의 윤년인 년도: ");

            var count = 0;

            for (int i = minYear; i <= maxYear; i++)
            {
                if (IsLeapYear(i))
                {
                    count++;
                    Console.Write($"{i} ");
                }
            }

            Console.WriteLine();
            Console.WriteLine($"총 {count}개");

            return count;
        }
        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0) && ((year % 100 != 0) || (year % 400 == 0));
        }

        public static void CalculateAge(int year, int month, int day)
        {
            GenerateMonth();

            //1년 = 365일
            const int allDays = 365;

            //1992-4-27
            //2022-1-13
            var today = DateTime.Today;
            var tYear = today.Year;
            var tMonth = today.Month;
            var tday = today.Day;

            int sum = 1;

            //set 일자(day)를 더함
            sum += day;

            //1992년의 5월 ~ 12월 31일 일자 계산
            var sMonth = CalculateMonth(month + 1);
            sum += sMonth; //설정한 월의 다음 월부터 12월까지의 일수

            //설정한 년도의 월, 일은 이미 계산함. year에 +1 해 줌
            //1993년 ~ 2022년의 차이는 29년, 365 * 차이 값(29)을 sum에 더해줌
            var cYear = tYear - (year + 1);
            sum += cYear * allDays;

            //올해의 월, 일 계산
            if (tMonth == 1)
            {
                sum += tday;
            }
            else
            {
                var cMonth = CalculateMonth(tMonth);
                sum += cMonth;
            }

            var leadYearCount = 0;

            //1992년 ~ 2022년에서 윤년이 있을 때마다 sum 증가
            for (int i = year; i < tYear; i++)
            {
                if (IsLeapYear(i))
                {
                    leadYearCount++;
                }
            }

            Console.WriteLine($"윤년 개수: {leadYearCount}");

            sum += leadYearCount;

            Console.WriteLine($"계산 값: {sum} 일");
        }

        private static int CalculateMonth(int month)
        {
            var sum = 0;

            for (int i = month; i <= days.Count; i++)
            {
                days.TryGetValue(i, out int value);

                sum += value;
            }

            return sum;
        }

        private static void GenerateMonth()
        {
            for (int i = 1; i <= 12; i++)
            {
                if (i <= 7)
                {
                    if (i % 2 == 1)
                    {
                        days.Add(i, 31);
                    }
                    else if (i == 2)
                    {
                        days.Add(i, 28);
                    }
                    else
                    {
                        days.Add(i, 30);
                    }
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        days.Add(i, 31);
                    }
                    else
                    {
                        days.Add(i, 30);
                    }
                }
            }
        }

        public static void CalculateAge_(int year, int month, int day)
        {
            var today = DateTime.Today;
            var setDay = new DateTime(year, month, day);


            Console.WriteLine($"오늘 날짜: {today:yyyy-MM-dd}");
            Console.WriteLine($"설정 날짜: {setDay:yyyy-MM-dd}");

            var leapYearCount = FindLeapYear(year, today.Year);

            TimeSpan span = today - setDay;
            var total = (int)(span.TotalDays + leapYearCount);

            Console.WriteLine($"{setDay:yyyy-MM-dd}로부터 {today:yyyy-MM-dd}까지 경과한 일자: {total} 일");
        }

        public static void FindPrimeNumber_(int range)
        {
            Console.Write($"2부터 {range}까지 존재하는 소수: ");
            var count = 0;

            for (int i = 2; i <= range; i++)
            {
                if (IsPrime_(i))
                {
                    count++;
                    Console.Write($"{i} ");
                }
            }

            Console.WriteLine();
            Console.WriteLine($"총 {count} 개");
        }

        //소수: 1과 자기 자신만을 약수로 갖는 숫자
        private static bool IsPrime_(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static void FindPrimeNumber(int range)
        {
            var number = 2;
            var count = 0;
            var result = new List<int>();

            while (number <= range)
            {
                Console.WriteLine($"현재 보고 있는 숫자: {number}");

                if (IsPrime(number))
                {
                    Console.WriteLine($"{number}는 소수로 판단됨.");
                    result.Add(number);
                    count++;
                }
                else
                {
                    Console.WriteLine($"{number}는 소수가 아님.");
                }

                if (number % 2 != 1)
                {
                    number += 1;
                }
                else
                {
                    number += 2;
                }

            }

            Console.Write($"2부터 {range}까지의 소수: ");

            foreach (var primeNumber in result)
            {
                Console.Write($"{primeNumber} ");
            }

            Console.WriteLine();
            Console.WriteLine($"총 {count} 개");
        }

        private static bool IsPrime(int number)
        {
            if (number == 2)
            {
                return true;
            }

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static void Factorial(int value)
        {
            int sum = 1;

            for (int i = value; i >= 1; i--)
            {
                sum *= i;
            }

            Console.WriteLine($"{value}! 합계: {sum:N0}");
        }

        public static void Add(int min, int max)
        {
            int sum = 0;

            for (int i = min; i <= max; i++)
            {
                sum += i;
            }

            Console.WriteLine($"{min} ~ {max} 사이의 값 합계: {sum}");
        }

        public static void Power(int value, int n)
        {
            int result = 0;

            for (int i = 0; i <= n; i++)
            {
                if (i == 0)
                {
                    result += 1;
                }
                else
                {
                    result *= value;
                }
            }

            Console.WriteLine($"{value}의 {n}승의 값: {result:N0}");
        }

        public static void Power_(int value, int n)
        {
            int result = 0;

            for (int i = 0; i <= n; i++)
            {
                if (i == 0)
                {
                    result += 1;
                }
                else
                {
                    result *= value;
                }
            }

            Console.WriteLine($"{value}의 {n}승의 값: {result:N0}");
        }

        public static void AreaOfCircle()
        {
            //원의 반지름이 1~10cm까지 변할 때 원의 면적 구하기
            CalculateAreaOfCircle(9);
        }

        private static void CalculateAreaOfCircle(double r)
        {
            for (int i = 0; i < r; i++)
            {
                var area = Math.PI * i * i;

                Console.WriteLine($"반지름: {i}cm / 원의 면적: {area:F2}");
            }
        }

        private static int Larger(int value1, int value2)
        {
            return (value1 >= value2) ? value1 : value2;
        }

        struct StructDate
        {
            public int year;
            public int month;
            public int day;
        }

        class ClassDate
        {
            public int year, month, day;
        }

        public static void TestClassStruct()
        {
            StructDate sDay;

            sDay.year = 2022;
            sDay.month = 1;
            sDay.day = 9;

            Console.WriteLine($"Struct Date: {sDay.year}/{sDay.month}/{sDay.day}");

            var cDay = new ClassDate
            {
                year = 2022,
                month = 1,
                day = 9
            };

            Console.WriteLine($"Class DAte: {cDay.year}/{cDay.month}/{cDay.day}");

            StructDate sDay2;

            sDay2.year = 2022;
            sDay2.month = 1;
            sDay2.day = 9;

            Console.WriteLine($"Struct Date: {sDay2.year}/{sDay2.month}/{sDay2.day}");

            var cDay2 = new ClassDate();

            cDay2.year = 2022;
            cDay2.month = 1;
            cDay2.day = 9;

            Console.WriteLine($"Class DAte: {cDay2.year}/{cDay2.month}/{cDay2.day}");
        }
    }
}

