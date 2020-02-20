using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTools
{
    class UsefulTools
    {
        public static int Min(int x, int y)
        {
            if (x < y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }

        public static int Max(int x, int y)
        {
            if (x > y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }

        public static int strLen(string x)
        {
            return x.Length;
        }

        public static int Addition(int x, int y)
        {
            return x + y;
        }

        public static int Subtraction(int x, int y)
        {
            return x - y;
        }

        public static int Multiplication(int x, int y)
        {
            return x * y;
        }

        public static int Division(int x, int y)
        {
            return x / y;
        }

        public static int Squared(int x)
        {
            return x * x;
        }

        public static int Remainder(int x, int y)
        {
            return x % y;
        }

        public static string IsCapitals(string x)
        {
            string firstLetter = x.Substring(0, 1);
            int strLength = x.Length;
            string restOfSentence = x.Substring(1, (strLength - 1));

            if (firstLetter == firstLetter.ToUpper() && restOfSentence == restOfSentence.ToLower())
            {
                return "Capitals";
            }
            else
            {
                return "Not Capitals";
            }
        }

        public static string IsUpperCase(string x)
        {
            if (x == x.ToUpper())
            {
                return "Uppercase";
            }
            else
            {
                return "Not uppercase";
            }
        }

        public static string EvenOdd(int x)
        {

            if (x % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }

        public static string CointainsInStr(string x, string y)
        {
            if (x.ToLower().Contains(y.ToLower()))
            {
                return "Contains";
            }
            else
            {
                return "Doesn't contain";
            }
        }
    }
}
