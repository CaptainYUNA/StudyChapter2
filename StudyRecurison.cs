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
    }
}
