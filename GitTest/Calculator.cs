using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    public static class Calculator
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y; // mind you, answer can be negative
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Max(int x, int y)
        {
            return Math.Max(x, y);
        }


    }
}
