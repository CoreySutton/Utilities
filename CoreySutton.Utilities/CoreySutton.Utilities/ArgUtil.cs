using System;
using System.Collections;

namespace TogglLib.Utilities
{
    public static class ArgUtil
    {
        public static void IsNotNull(object nullableObj)
        {
            if (nullableObj == null) throw new ArgumentNullException(nameof(nullableObj));
        }

        public static void IsNotNullOrEmpty(ICollection collection)
        {
            if (collection == null || collection.Count <= 0) throw new ArgumentNullException(nameof(collection));
        }

        public static void IsGreaterThanZero(double value)
        {
            if (value <= 0.0) throw new ArgumentNullException(nameof(value));
        }

        public static void IsGreaterThanZero(int value)
        {
            if (value <= 0) throw new ArgumentNullException(nameof(value));
        }

        public static void IsGreaterThanOrEqualToZero(double value)
        {
            if (value < 0.0) throw new ArgumentNullException(nameof(value));
        }

        public static void IsGreaterThanOrEqualToZero(int value)
        {
            if (value < 0) throw new ArgumentNullException(nameof(value));
        }

        public static void IsLessThanZero(double value)
        {
            if (value >= 0.0) throw new ArgumentNullException(nameof(value));
        }

        public static void IsLessThanZero(int value)
        {
            if (value >= 0) throw new ArgumentNullException(nameof(value));
        }

        public static void IsLessThanOrEqualToZero(double value)
        {
            if (value > 0.0) throw new ArgumentNullException(nameof(value));
        }

        public static void IsLessThanOrEqualToZero(int value)
        {
            if (value > 0) throw new ArgumentNullException(nameof(value));
        }
    }
}