using System.Buffers;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;
using System.Linq.Expressions;

namespace SimpleCalculator
{
    internal static class Arithmetic
    {
        public static double x;
        public static double y;
        public static char sign;

        public static string Operation(string? operation)
        {
            string value = "";

            if (operation == "add")
            {
                sign = '+';
                value = (x + y).ToString() != "∞" ? (x + y).ToString() : "Overflow";
            }
            else if (operation == "sub")
            {
                sign = '-';
                value = (x - y).ToString() != "∞" ? (x - y).ToString() : "Overflow";
            }
            else if (operation == "mul")
            {
                sign = '×';
                value = (x * y).ToString() != "∞" ? (x * y).ToString() : "Overflow";
            }
            else if (operation == "div")
            {
                sign = '÷';
                value = (x / y).ToString() != "∞" ? (x / y).ToString() : "Can't Divide by Zero";
            }
            else
                value = "0";

            return value;
        }
    }
}
