using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DSA
{
    public static class Monad
    {
        // Wraps a set of items up into a list.
        public static IEnumerable<T> Return<T>(params T[] ts) =>
            ts.ToList();
        
        // Extension method for a nullable type.
        public static B? Bind<A, B>(
            this A? a
            , Func<A, B?> f) // Perform action on A to return B
            where B : struct // Not sure
            where A : struct // Not sure
        {
            return a.HasValue ? f(a.Value) : null; // If a has a value do the function on a, otherwise null.
        }
    }
}