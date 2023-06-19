﻿namespace UmbCheckout.Shared.Extensions
{
    public static class ConvertExtensions
    {
        public static bool ToBoolean(this string value)
        {
            if (value.Equals("1"))
            {
                return true;
            }

            if (value.Equals("true", StringComparison.InvariantCultureIgnoreCase))
            {
                return true;
            }

            if (value.Equals("0"))
            {
                return false;
            }

            if (value.Equals("false", StringComparison.InvariantCultureIgnoreCase))
            {
                return false;
            }

            return false;
        }
    }
}
