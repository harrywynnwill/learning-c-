
#loops

3 ways to loop in c#


##do -- while loop

This allows us to repeat a chunk of code until the condition at the end becomes false. Note that the test is performed after the statement or block, i.e. even if the test is bound to fail the statement is performed once.

```
do
          statement or block
    while (condition) ;
    ```

##while loop

```
 while (condition)
          statement or block
```

##for loop
```
  for ( setup ; finish test ; update )
{
things we want to do a given
          number of times
    }
```
```
using System;
    class ForLoop
      {
        public static void Main ()
          {       
            int i ;
               for ( i = 1 ; i < 11 ; i = i + 1 )
               {
                      Console.WriteLine ( "Hello mum" ) ;
               }
          }
      }

```
You can do this with the `break` statement. This is a command to leave the loop immediately

Every now and then you will want to go back to the top of a loop and do it all again. This happens when you have gone as far down the statements as you need to. C# provides the `continue` keyword.


##Adjusting real number precision

Placeholders can have formatting information added to them:
  ```  
    int i = 150 ;
    double f = 1234.56789 ;
    Console.WriteLine ( "i: {0:0} f: {1:0.00}", i, f ) ;
  ```
This would print out:
    i: 150 f: 1234.57
