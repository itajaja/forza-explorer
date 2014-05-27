using System.Globalization;

namespace ForzaExplorer.Utils
{
  public static class StringExtensions
  {

    /// <summary>
    /// Check if the string contains the specified string ignoring the case options specified by the culture
    /// </summary>
    /// <param name="text"></param>
    /// <param name="word">the string that has to be contained</param>
    /// <returns>Returns true if the string contains the word string, ignoring the case, otherwise false</returns>
    public static bool ContainsIgnore(this string text, string word)
    {
      return CultureInfo.CurrentCulture.CompareInfo.IndexOf(text, word, CompareOptions.IgnoreCase) >= 0;
    }

    /// <summary>
    /// returns true if a contains all the characters of b in the correct order
    /// </summary>
    public static bool MatchSub(this string a, string b)
    {
      var i = 0;
      var currentChar = char.ToLowerInvariant(b[i]);
      foreach (var c in a)
      {
        if (char.ToLowerInvariant(c) != currentChar)
          continue;
        i++;
        if (b.Length == i)
          break;
        currentChar = char.ToLowerInvariant(b[i]);
      }
      return i == b.Length;
    }
  }
}