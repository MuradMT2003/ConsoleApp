using System.Text.RegularExpressions;

namespace ConsoleApp.Business.Helpers;

public static class Extension
{
    public static bool IsOnlyLetter(this string word)
    {
        return Regex.IsMatch(word, @"^[a-zA-Z]+$");
    }
}
