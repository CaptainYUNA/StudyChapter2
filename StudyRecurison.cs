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

        static int count = 0;

        public static void RecurisonTowerOfHanoi(int n, char from, char to, char by)
        {
            if (n == 1)
            {
                count++;

                Console.WriteLine($"[{from} 기둥] -> [{by} 기둥]");
            }
            else
            {
                count++;

                RecurisonTowerOfHanoi(n - 1, from, by, to);
                Console.WriteLine($"[{from} 기둥] -> [{to} 기둥]");
                RecurisonTowerOfHanoi(n - 1, by, to, from);
            }
        }
    }
}
