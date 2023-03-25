using System.Linq;

namespace FluentExtensions
{
    /// <summary>
    /// Provides object extension methods.
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// Determines whether a value is contained in a specified sequence by using the default equality comparer.
        /// </summary>
        /// <typeparam name="T">The type of <paramref name="value"/>.</typeparam>
        /// <param name="value">A value to locate in a sequence.</param>
        /// <param name="array">The sequence in which to locate the value.</param>
        /// <returns>
        /// <see langword="true" /> if the specified sequence contains the value; otherwise, <see langword="false" />.
        /// </returns>
        public static bool IsIn<T>(this T value, params T[] array)
        {
            return array.Contains(value);
        }
    }
}