using System.Diagnostics.CodeAnalysis;

namespace AdventOfCode2024;

[ExcludeFromCodeCoverage]
internal static class Extensions
{
    /// <summary>
    /// Splits the given string <paramref name="source"/> on the given char <paramref name="separators"/>, removing the empty entries.
    /// </summary>
    /// <param name="source">The string to split.</param>
    /// <param name="separators">The character separators to use.</param>
    /// <returns>A string array of the results of the split.</returns>
    public static string[] SplitOn(this string source, params char[] separators)
    {
        return source.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    }

    /// <summary>
    /// Splits the given string <paramref name="source"/> on the given string <paramref name="separators"/>, removing the empty entries.
    /// </summary>
    /// <param name="source">The string to split.</param>
    /// <param name="separators">The string separators to use.</param>
    /// <returns>A string array of the results of the split.</returns>
    public static string[] SplitOn(this string source, params string[] separators)
    {
        return source.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    }

    /// <summary>
    /// Splits the given string <paramref name="source"/> on the <see cref="Environment.NewLine"/> string, optionally
    /// omitting empty elements and/or trimming each split entry.
    /// </summary>
    /// <param name="source">The string to split into lines.</param>
    /// <param name="removeEmptyEntries">Defaults to <em>true</em>, determines whether the split operation omits elements that contain
    /// and empty string from the result.</param>
    /// <param name="trimEntries">Defaults to <em>true</em>, determines whether the individual split entries are trimmed.</param>
    /// <returns>An enumerable of strings representing each line within the source string.</returns>
    public static IEnumerable<string> SplitLines(this string source, bool removeEmptyEntries = true, bool trimEntries = true)
    {
        var options = StringSplitOptions.None;

        if (removeEmptyEntries) options |= StringSplitOptions.RemoveEmptyEntries;
        if (trimEntries) options |= StringSplitOptions.TrimEntries;

        return source.Split([Environment.NewLine], options);
    }

    /// <summary>
    /// Executes <code>string.Trim()</code> on each line within the source collection.
    /// </summary>
    /// <param name="source">The string collection to operate on.</param>
    /// <returns>An enumerable of the given strings, each trimmed.</returns>
    public static IEnumerable<string> TrimEach(this IEnumerable<string> source)
    {
        return source.Select(x => x.Trim());
    }

    /// <summary>
    /// Returns the value within the given dictionary for the given key if the key is present within the dictionary and the dictionary is
    /// not null, the default value of the value otherwise.
    /// </summary>
    /// <param name="dict">The dictionary to look within.</param>
    /// <param name="key">The key to attempt to locate within the dictionary.</param>
    /// <param name="defaultValue">The default value to return.</param>
    /// <typeparam name="TKey">They type of the keys of the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of the values of the dictionary.</typeparam>
    /// <returns>The value paired with the given key within the given dictionary, if it exists and the dictionary is not null. Otherwise,
    /// the given default if provided, and the default of the type of the value if not.</returns>
    public static TValue? GetValueOrDefault<TKey, TValue>(this IDictionary<TKey, TValue?> dict, TKey key,
        TValue? defaultValue = default)
    {
        return dict != null && dict.TryGetValue(key, out var value) ? value : defaultValue;
    }

    /// <summary>
    /// Evaluates the give enumerable for null or empty.
    /// </summary>
    /// <param name="source">The enumerable to evaluate.</param>
    /// <typeparam name="T">The type of the enumerable.</typeparam>
    /// <returns><em>true</em> if the given enumerable is not null and not empty, <em>false</em> otherwise.</returns>
    public static bool HasAny<T>(this IEnumerable<T> source)
    {
        return source != null && source.Any();
    }

    /// <summary>
    /// Converts the given enumerable of chars to a string, if it is not null. Returns the empty string if the enumerable is null or empty.
    /// </summary>
    /// <param name="chars">The enumerable to make a string of.</param>
    /// <returns>A string containing the chars of the enumerable in order, or the empty string if the enumerable is null or empty.</returns>
    public static string AsString(this IEnumerable<char> chars)
    {
        return chars.HasAny() ? new string([.. chars]) : string.Empty;
    }

    /// <summary>
    /// Joins the strings of the given enumerable with the given separator. If the enumerable is null or empty, returns the empty string.
    /// </summary>
    /// <param name="source">The strings to join.</param>
    /// <param name="separator">The separator to insert between the strings.</param>
    /// <typeparam name="T">The type of the enumerable.</typeparam>
    /// <returns>The results of joining the ToString objects of the enumerable if the enumerable is not null or empty, the empty string otherwise.</returns>
    public static string JoinStrings<T>(this IEnumerable<T> source, string separator = "")
    {
        return source.HasAny()
            ? string.Join(separator, source)
            : string.Empty;
    }

    /// <summary>
    /// Parses the given string as the given enum type.
    /// </summary>
    /// <param name="value">The string to parse.</param>
    /// <param name="ignoreCase">Whether the parsing ignores case.</param>
    /// <param name="defaultValue">A default to return if the string cannot be parsed.</param>
    /// <typeparam name="TEnum">The enum type to be parsed into.</typeparam>
    /// <returns>An enum of type TEnum, parsed from the given string.</returns>
    /// <throws>InvalidOperationException if the given type is not an enum.</throws>
    public static TEnum ParseEnum<TEnum>(this string value, bool ignoreCase = true, TEnum defaultValue = default)
        where TEnum : struct, System.Enum
    {
        if (!typeof(TEnum).IsEnum)
            throw new InvalidOperationException("Given type is not an enum");

        return Enum.TryParse(value, ignoreCase, out TEnum result)
            ? result
            : defaultValue;
    }

    /// <summary>
    /// Parses the given strings as the given enum type.
    /// </summary>
    /// <param name="source">The enumerable of strings to parse.</param>
    /// <param name="ignoreCase">Whether the parsing ignores case.</param>
    /// <param name="defaultValue">A default to return if a string cannot be parsed.</param>
    /// <typeparam name="TEnum">The enum type to be parsed into.</typeparam>
    /// <returns>A collection of enums of type TEnum, parsed from the given strings.</returns>
    /// <throws>InvalidOperationException if the given type is not an enum.</throws>
    public static IList<TEnum> ParseEnums<TEnum>(this IEnumerable<string> source, bool ignoreCase = true, TEnum defaultValue = default)
        where TEnum : struct, System.Enum
    {
        return source.HasAny()
            ? source.Select(x => x.ParseEnum(ignoreCase, defaultValue)).ToList()
            : [];
    }

    /// <summary>
    /// Copies the given <paramref name="source"/> enumerable to a <see cref="DefaultDictionary{TKey,TValue}"/>
    /// </summary>
    /// <typeparam name="TSource">The type of the items in the source enumerable.</typeparam>
    /// <typeparam name="TKey">The type of the key of the resulting Dictionary.</typeparam>
    /// <typeparam name="TValue">The type of the value of the resulting Dictionary.</typeparam>
    /// <param name="source">The source enumerable.</param>
    /// <param name="keySelector">A function to generate the key from a given item.</param>
    /// <param name="valueSelector">A function to generate the value from a given item.</param>
    /// <param name="defaultFactory">The default factory to be used in the Dictionary.</param>
    /// <returns>A DefaultDictionary containing the items of the given enumerable, transformed by the given selector functions.</returns>
    /// <exception cref="ArgumentNullException">If any of the parameters are null.</exception>
    public static IDictionary<TKey, TValue> ToDefaultDictionary<TSource, TKey, TValue>(this IEnumerable<TSource> source,
        Func<TSource, TKey> keySelector, Func<TSource, TValue> valueSelector, Func<TKey, TValue> defaultFactory)
        where TKey : notnull
    {
        ArgumentNullException.ThrowIfNull(source);
        ArgumentNullException.ThrowIfNull(keySelector);
        ArgumentNullException.ThrowIfNull(valueSelector);
        ArgumentNullException.ThrowIfNull(defaultFactory);

        var dict = new DefaultDictionary<TKey, TValue>(defaultFactory);
        foreach (var item in source)
        {
            dict.Add(keySelector(item), valueSelector(item));
        }
        return dict;
    }

    /// <summary>
    /// Searches the input string for the first occurrence of the Regular Expression, returning true if there was a match.
    /// </summary>
    /// <param name="regex">The Regular Expression to search for.</param>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="match">The match.</param>
    /// <returns>true if the match was successful, false otherwise.</returns>
    public static bool TryMatch(this Regex regex, string input, out Match match)
    {
        match = regex.Match(input);
        return match.Success;
    }
}
