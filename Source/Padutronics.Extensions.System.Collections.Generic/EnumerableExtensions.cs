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
}