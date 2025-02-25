using System.Collections.Generic;
using System.Linq;

namespace Jelewow.Asteroids.Extensions
{
    public static class CollectionExtensions
    {
        public static bool IsCollectionValid<T>(this ICollection<T> collection)
        {
            return collection != null && collection.Any(element => element != null);
        }
    }
}