﻿using System.Collections;
using System.Data;

namespace CoreySutton.Utilities.Utilities
{
    public static class Validator
    {
        public static bool IsNullOrEmpty(ICollection value)
        {
            return value == null || value.Count == 0;
        }

        public static bool HasOneItem(ICollection value)
        {
            if (value == null)
            {
                throw new NoNullAllowedException("Collection should not be null");
            }

            return value.Count == 1;
        }
    }
}