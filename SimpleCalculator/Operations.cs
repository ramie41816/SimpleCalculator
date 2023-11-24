using System.Diagnostics.CodeAnalysis;
using System.Drawing.Text;
using System.Linq.Expressions;

namespace SimpleCalculator
{
    internal static class Arithmetic
    {
        public static double add(double x, double y)
        {
            return x + y;
        }

        public static double sub(double x, double y)
        {
            return x - y;
        }

        public static double mul(double x, double y)
        {
            return x * y;
        }

        public static double div(double x, double y)
        {
            return x / y;
        }

        public static double sqrd(double x)
        {
            return Math.Pow(x, 2);
        }

        public static double sqrt(double x)
        {
            return Math.Sqrt(x);
        }

    }
}
