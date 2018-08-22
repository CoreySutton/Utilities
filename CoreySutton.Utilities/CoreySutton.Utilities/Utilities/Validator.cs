using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CoreySutton.Utilities
{
    public static class Validator
    {
        #region IsNullOrEmpty

        public static bool IsNullOrEmpty(IEnumerable value)
        {
            return value == null || value.Cast<object>().Count() <= 0;
        }

        public static bool IsNullOrEmpty<T>(IEnumerable<T> value)
        {
            return value == null || value.Count() <= 0;
        }

        public static bool IsNullOrEmpty(IDictionary value)
        {
            return value == null || value.Count == 0;
        }

        public static bool IsNullOrEmpty(ICollection value)
        {
            return value == null || value.Count == 0;
        }

        #endregion

        #region HasOneItem

        public static bool HasOneItem(IEnumerable value)
        {
            Argument.IsNotNull(value, nameof(value));

            return value.Cast<object>().Count() == 1;
        }

        public static bool HasOneItem<T>(IEnumerable<T> value)
        {
            Argument.IsNotNull(value, nameof(value));

            return value.Count() == 1;
        }

        public static bool HasOneItem(IDictionary value)
        {
            Argument.IsNotNull(value, nameof(value));

            return value.Count == 1;
        }

        public static bool HasOneItem(ICollection value)
        {
            Argument.IsNotNull(value, nameof(value));

            return value.Count == 1;
        }

        #endregion

        #region IsNotNullAndHasOneItem

        public static bool IsNotNullAndHasOneItem(IEnumerable value)
        {
            return value != null && value.Cast<object>().Count() == 1;
        }

        public static bool IsNotNullAndHasOneItem<T>(IEnumerable<T> value)
        {
            return value != null && value.Count() == 1;
        }

        public static bool IsNotNullAndHasOneItem(IDictionary value)
        {
            return value != null && value.Count == 1;
        }

        public static bool IsNotNullAndHasOneItem(ICollection value)
        {
            return value != null && value.Count == 1;
        }

        #endregion
    }
}
