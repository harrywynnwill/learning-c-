using System ;
class ReturnDemo
{
  static int sillyReturnPlus ( int i )
  {
    i = i + 1;
    Console.WriteLine ( "i is : " + i ) ;
    return i;
  }
  public static void Main ()
  {
    int res;
    res = sillyReturnPlus (5);
    Console.WriteLine ( "res is : " + res ) ;
    res = sillyReturnPlus (5) + sillyReturnPlus (7) + 1;
    Console.WriteLine ( "res is : " + res ) ;
  }
}
