using System;
using System.Collections;

namespace CoreySutton.Utilities
{
    public static class ArgUtil
    {
        public const string DefaultArgumentName = "value";

        public static void NotNull(object value, string name = DefaultArgumentName)
        {
            if (value == null) throw new ArgumentNullException(name);
        }

        public static void NotNullOrEmpty(ICollection value, string name = DefaultArgumentName)
        {
            if (value == null || value.Count <= 0) throw new ArgumentNullException(name);
        }

        public static void GreaterThanZero(double value, string name = DefaultArgumentName)
        {
            if (value <= 0.0) throw new ArgumentNullException(name);
        }

        public static void GreaterThanZero(int value, string name = DefaultArgumentName)
        {
            if (value <= 0) throw new ArgumentNullException(name);
        }

        public static void GreaterThanOrEqualToZero(double value, string name = DefaultArgumentName)
        {
            if (value < 0.0) throw new ArgumentNullException(name);
        }

        public static void GreaterThanOrEqualToZero(int value, string name = DefaultArgumentName)
        {
            if (value < 0) throw new ArgumentNullException(name);
        }

        public static void LessThanZero(double value, string name = DefaultArgumentName)
        {
            if (value >= 0.0) throw new ArgumentNullException(name);
        }

        public static void LessThanZero(int value, string name = DefaultArgumentName)
        {
            if (value >= 0) throw new ArgumentNullException(name);
        }

        public static void LessThanOrEqualToZero(double value, string name = DefaultArgumentName)
        {
            if (value > 0.0) throw new ArgumentNullException(name);
        }

        public static void LessThanOrEqualToZero(int value, string name = DefaultArgumentName)
        {
            if (value > 0) throw new ArgumentNullException(name);
        }
    }
}