using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CoreySutton.Utilities
{
    public static class Argument
    {
        public const string DefaultArgumentName = "value";

        public static void IsNotNull(object value, string name = DefaultArgumentName)
        {
            if (value == null) throw new ArgumentNullException(name);
        }

        public static void IsNotNullOrEmpty(string value, string name = DefaultArgumentName)
        {
            if (string.IsNullOrEmpty(value)) throw new ArgumentNullException(name);
        }

        public static void IsNotNullOrEmpty(ICollection value, string name = DefaultArgumentName)
        {
            if (value == null || value.Count <= 0) throw new ArgumentNullException(name);
        }

        public static void IsNotNullOrEmpty(IDictionary value, string name = DefaultArgumentName)
        {
            if (value == null || value.Count <= 0) throw new ArgumentNullException(name);
        }

        public static void IsNotNullOrEmpty<T>(IEnumerable<T> value, string name = DefaultArgumentName)
        {
            if (value == null || value.Count() <= 0) throw new ArgumentNullException(name);
        }

        public static void IsNotNullOrEmpty(IEnumerable value, string name = DefaultArgumentName)
        {
            if (value == null || value.Cast<object>().Count() <= 0) throw new ArgumentNullException(name);
        }

        public static void IsGreaterThanZero(double value, string name = DefaultArgumentName)
        {
            if (value <= 0.0) throw new ArgumentNullException(name);
        }

        public static void IsGreaterThanZero(int value, string name = DefaultArgumentName)
        {
            if (value <= 0) throw new ArgumentNullException(name);
        }

        public static void IsGreaterThanOrEqualToZero(double value, string name = DefaultArgumentName)
        {
            if (value < 0.0) throw new ArgumentNullException(name);
        }

        public static void IsGreaterThanOrEqualToZero(int value, string name = DefaultArgumentName)
        {
            if (value < 0) throw new ArgumentNullException(name);
        }

        public static void IsLessThanZero(double value, string name = DefaultArgumentName)
        {
            if (value >= 0.0) throw new ArgumentNullException(name);
        }

        public static void IsLessThanZero(int value, string name = DefaultArgumentName)
        {
            if (value >= 0) throw new ArgumentNullException(name);
        }

        public static void IsLessThanOrEqualToZero(double value, string name = DefaultArgumentName)
        {
            if (value > 0.0) throw new ArgumentNullException(name);
        }

        public static void IsLessThanOrEqualToZero(int value, string name = DefaultArgumentName)
        {
            if (value > 0) throw new ArgumentNullException(name);
        }
    }
}