using System.Collections.Generic;

namespace Padutronics.Extensions.System.Collections.Generic;

public static class ListExtensions
{
    public static IList<T> RemoveLast<T>(this IList<T> @this)
    {
        @this.RemoveAt(@this.Count - 1);

        return @this;
    }
}