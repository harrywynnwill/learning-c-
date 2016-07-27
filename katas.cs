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
