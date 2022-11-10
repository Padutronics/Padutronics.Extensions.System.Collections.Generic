using System;
using System.Collections.Generic;

namespace Padutronics.Extensions.System.Collections.Generic;

public static class EnumerableExtensions
{
    public static IEnumerable<T> ForEach<T>(this IEnumerable<T> @this, Action<T> action)
    {
        foreach (T item in @this)
        {
            action(item);
        }

        return @this;
    }

    public static IEnumerable<T> ForEach<T>(this IEnumerable<T> @this, Action<T, int> action)
    {
        var index = 0;

        foreach (T item in @this)
        {
            action(item, index);

            ++index;
        }

        return @this;
    }
}