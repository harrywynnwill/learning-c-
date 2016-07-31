public static class Kata
{
    public static string bonus_time(int salary, bool bonus)
    {
        return $"${salary * (bonus ? 10 : 1)}";
    }
}

public static class MonkeyCounter
{
  public static int[] MonkeyCount(int n)
  {
    return Enumerable.Range(1, n).ToArray();
  }
}
using System.Collections.Generic;
public static class Kata
{
    public static string Greet(string language)
    {
      return (lang.ContainsKey(language))
        ? lang[language]
        : "Welcome";
    }

    private static readonly Dictionary<string, string> lang = new Dictionary<string, string>
    {
        {"english", "Welcome"},
        {"czech", "Vitejte"},
        {"danish", "Velkomst"},
        {"dutch", "Welkom"},
        {"estonian", "Tere tulemast"},
        {"finnish", "Tervetuloa"},
        {"flemish", "Welgekomen"},
        {"french", "Bienvenue"},
        {"german", "Willkommen"},
        {"irish", "Failte"},
        {"italian", "Benvenuto"},
        {"latvian", "Gaidits"},
        {"lithuanian", "Laukiamas"},
        {"polish", "Witamy"},
        {"spanish", "Bienvenido"},
        {"swedish", "Valkommen"},
        {"welsh", "Croeso"}
    };

}
using System;
public class Kata
{
  public static string FindNeedle(object[] haystack)
  {
    return "found the needle at position " + Array.IndexOf(haystack,"needle");
  }
}
