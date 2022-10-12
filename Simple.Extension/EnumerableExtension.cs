using System;
using System.Collections;
using System.Linq;

namespace Simple.Extension.Enumerable;

public static class EnumerableExtension
{
    public static bool IsNullOrEmpty<T>(this IEnumerable<T> value)
    {
        return value?.Any() ?? false;
    }

    public static bool IsNotNullOrEmpty<T>(this IEnumerable<T> value)
    {
        return !(value?.Any() ?? false);
    }
}

