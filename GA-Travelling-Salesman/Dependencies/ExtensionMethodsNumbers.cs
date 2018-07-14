using System;
using System.Collections.Generic;
using System.Linq;

namespace GA_Travelling_Salesman.Dependencies
{
    public static class ExtensionMethodsNumbers
    {
        public const float DEFAULT_EPSILON_FLOAT = 0.00000001f;
        public const Decimal DEFAULT_EPSILON_DECIMAL = (Decimal)0.00000001;

        public static bool EEquals(this float number1, float number2, float precision = DEFAULT_EPSILON_FLOAT)
        {
            var diff = Math.Abs(number1 - number2);
            return diff < precision;
        }

        public static int ECompareTo(this float number1, float number2, float precision = DEFAULT_EPSILON_FLOAT)
        {
            var diff = number1 - number2;
            if (diff > precision)
                return 1;
            if (diff < -precision)
                return -1;
            return 0;
        }

        public static bool EEquals(this Decimal number1, Decimal number2, Decimal precision = DEFAULT_EPSILON_DECIMAL)
        {
            var diff = Math.Abs(number1 - number2);
            return diff < precision;
        }

        public static int ECompareTo(this Decimal number1, Decimal number2, Decimal precision = DEFAULT_EPSILON_DECIMAL)
        {
            var diff = number1 - number2;
            if (diff > precision)
                return 1;
            if (diff < -precision)
                return -1;
            return 0;
        }
    }
}
