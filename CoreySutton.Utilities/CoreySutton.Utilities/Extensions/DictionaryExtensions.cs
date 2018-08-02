using System.Collections.Generic;

namespace CoreySutton.Utilities
{
    public static class DictionaryExtensions
    {
        public static void AddToNestedList<TKey, TValue>(
            this Dictionary<TKey, List<TValue>> dictionary,
            TKey key,
            TValue value)
        {
            dictionary.TryGetValue(key, out List<TValue> nestedList);

            if (nestedList == null)
            {
                nestedList = new List<TValue> { value };

                dictionary.Add(key, nestedList);
            }
            else
            {
                dictionary[key].Add(value);
            }
        }
    }
}
