using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudyChapter2
{
    [TestClass]
    public static class Study
    {
        static Study()
        {
            GenerateMonth();
        }

        private static Dictionary<int, int> _days = new Dictionary<int, int>();

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
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }

        public static void CalculateAge(int year, int month, int day)
        {
            var today = DateTime.Today;
            CalculateAge(new DateTime(year, month, day), today);
        }

        [TestMethod]
        public static void TestCalculateAge(DateTime from, DateTime to)
        {
            Console.WriteLine($"CalculateAge: {CalculateAge(from, to)}, TimeSpan.TotalDays: {(to - from).TotalDays + 1}");
        }

        [TestMethod]
        public static int CalculateAge(DateTime from, DateTime to)
        {
            var fromYear = from.Year;
            var fromMonth = from.Month;
            var fromDay = from.Day;

            var toYear = to.Year;
            var toMonth = to.Month;
            var toDay = to.Day;

            const int allDays = 365;

            var total = 1;

            if (fromYear == toYear)
            {
                if (fromMonth == toMonth)
                {
                    _days.TryGetValue(fromMonth, out var value);
                    total += (value - fromDay) - (value - toDay);
                }
                else
                {
                    var days = CalculateDays(fromMonth);
                    _days.TryGetValue(toMonth, out var value);

                    total += (days - fromDay) - (value - toDay);
                }
            }
            else
            {
                for (int i = fromYear; i <= toYear; i++)
                {
                    if (i == fromYear)
                    {
                        var days = CalculateDays(fromMonth);

                        total += days - fromDay;

                        if (fromMonth < 3 && IsLeapYear(i))
                        {
                            total++;
                        }
                    }
                    else if (i == toYear)
                    {
                        var days = CalculateDays(toMonth);

                        total += (allDays - days) + toDay;

                        if (toMonth >= 3 && IsLeapYear(i))
                        {
                            total++;
                        }
                    }
                    else
                    {
                        total += CalculateDays(1);

                        if (IsLeapYear(i))
                        {
                            total++;
                        }
                    }
                }
            }

            return total;
        }

        private static int CalculateDays(int month)
        {
            var sum = 0;

            for (int i = month; i <= 12; i++)
            {
                _days.TryGetValue(i, out int days);
                sum += days;
            }

            return sum;
        }

        //public static int CalculateAge2(DateTime from, DateTime to)
        //{
        //    var fromYear = from.Year;
        //    var fromMonth = from.Month;
        //    var fromDay = from.Day;

        //    var toYear = to.Year;
        //    var toMonth = to.Month;
        //    var toDay = to.Day;

        //    const int allDays = 365;

        //    var sum = 0;

        //    //from
        //    if (fromYear == toYear)
        //    {
        //        if (fromMonth == toMonth)
        //        {
        //            sum += toDay - fromDay;

        //            return sum;
        //        }
        //        else
        //        {
        //            _days.TryGetValue(fromMonth, out var value);
        //            sum += value - fromDay;

        //            if (fromMonth < 3)
        //            {
        //                if (IsLeapYear(fromYear))
        //                {
        //                    sum++;
        //                }
        //            }

        //            fromMonth++;

        //            if (fromMonth == 12)
        //            {
        //                return sum + toDay;
        //            }

        //            fromYear++;
        //        }
        //    }
        //    else //년도가 다른 case --> fromDay를 더해주고 fromMonth + 1부터 그 해의 12월까지 계산해야 함
        //    {
        //        _days.TryGetValue(fromMonth, out var value);
        //        sum += value - fromDay;

        //        var leapDays = LeapYearCount(fromYear, fromMonth);
        //        sum += leapDays;

        //        fromMonth++;

        //        if (fromMonth == 12)
        //        {
        //            _days.TryGetValue(fromMonth, out var day);
        //            sum += day;
        //        }
        //        else
        //        {
        //            var totalFromDays = CalculateFromDays(fromMonth);
        //            sum += totalFromDays;
        //        }

        //        fromYear++;
        //    }

        //    //to
        //    var yearSpan = toYear - fromYear; //yearSpan이 음수가 되는 경우는 없음 (0은 됨)

        //    if (yearSpan == 0)
        //    {
        //        var totalToDays = CalculatetToDays(toMonth);

        //        return sum += totalToDays - toDay;
        //    }
        //    else
        //    {
        //        sum += yearSpan * allDays;

        //        var totalToDays = CalculatetToDays(toMonth);
        //        sum += totalToDays - toDay;

        //        if (toMonth >= 3)
        //        {
        //            if (IsLeapYear(toYear))
        //            {
        //                sum++;
        //            }
        //        }
        //    }

        //    for (int i = fromYear; i < toYear; i++)
        //    {
        //        if (IsLeapYear(i))
        //        {
        //            sum++;
        //        }
        //    }

        //    return sum;
        //}


        private static int LeapYearCount(int fromYear, int fromMonth)
        {
            var sum = 0;

            if (fromMonth < 3)
            {
                if (IsLeapYear(fromYear))
                {
                    sum++;
                }
            }

            return sum;
        }

        private static int CalculatetToDays(int month)
        {
            var sum = 0;

            for (int i = 1; i <= month; i++)
            {
                var day = month - (month - i);
                _days.TryGetValue(day, out int value);

                sum += value;
            }

            return sum;
        }

        private static int CalculateFromDays(int month, int day)
        {
            var sum = 0;

            for (int i = month; i <= 12; i++)
            {
                _days.TryGetValue(i, out int value);
                sum += value;
            }

            sum -= day;

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
                        _days.Add(i, 31);
                    }
                    else if (i == 2)
                    {
                        _days.Add(i, 28);
                    }
                    else
                    {
                        _days.Add(i, 30);
                    }
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        _days.Add(i, 31);
                    }
                    else
                    {
                        _days.Add(i, 30);
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

        //condition: 2를 제외한 모든 짝수는 소수가 아님
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
            CalculateAreaOfCircle(10);
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

