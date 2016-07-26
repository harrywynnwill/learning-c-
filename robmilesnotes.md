```
widthString = Console.ReadLine();
width = double.Parse(widthString);
```
ReadLine() - takes input from the command line
double.Parse() - converts the string to a double

double -"double precision floating point number".

`double width, height, woodLength, glassArea;`

This is a list. A list of items in C# is separated by ,
```
using System;
class GlazerCalc
{
       static void Main()
    {
       double width, height, woodLength, glassArea;
       string widthString, heightString;

widthString = Console.ReadLine();
width = double.Parse(widthString);
heightString = Console.ReadLine();
height = double.Parse(heightString);
woodLength = 2 * ( width + height ) * 3.25 ;
glassArea = 2 * ( width * height ) ;
Console.WriteLine ( "The length of the wood is " +
       woodLength + " feet" ) ;
Console.WriteLine( "The area of the glass is " +
       glassArea + " square metres" ) ;

     }
   }
```
`Console.WriteLine ( "2.0" + 3.0 );`
`
Would regard the + as concatenating two strings. It would ask the value 3 to convert itself into a string.
`2.03`
The string "2.0" has the text of the value 3.0 added on the end.

A float literal can be expressed as a real number with an f after it: 2.5f
A double literal is expressed as a real number without the f: 3.5

A char is a type of variable which can hold a single character. A character is what you get when you press a key on a keyboard or display a single character on the screen. C# uses a character set called UNICODE which can handle over 65,000 different character designs including a wide range of foreign characters.

`string` A type of box which can hold a string of text.

A string literal value is expressed enclosed in double quotes:
    "this is a string"

A bool (short for boolean) variable is a type of box which can hold whether or not something is true.

true or false only types a bool allows

variables are written in camelcase

In the program above first, second, third are identifiers and 2 is a literal value. A literal value is something which is literally there in the code. A literal value has a type associated with it by the compiler.


#Operand order

`-`

(unary minus, the minus that C# finds in negative numbers, e.g. -1. Unary means applying to only one item)

`*`

`/`

`+`

`-`


#Casting


We can force C# to regard a value as being of a certain type by the use of casting. A cast takes the form of an additional instruction to the compiler to force it to regard a value in a particular way. You cast a value by putting the type you want to see there in brackets before it. For example:

```
double d = 1.5;
float f = (float) d ;
```

```
int i ;
i = (int) 1.999 ;
```

```
float x ;
x = (float) 3.4 ;
```

```
   using System;
    class CastDemo
    {
          static void Main ()
          {
               int i = 3, j = 2 ;
          }
    }

```
Put the casts in even if they are not needed, this can make the program clearer. It may not affect the result of the calculation but it will inform the reader of what I am trying to do.



#conditional operators


```
if (condition)
          statement or block we do if the condition is true
else
          statement or block we do if the condition is false
```


```
 if (true)
          Console.WriteLine ( "hello mum" ) ;
```

#Relational operators
`==` `!=` `>` `<` `<=` `>=` `!`
`&&`
`||`


#Magic Numbers
I do not like the idea of "magic numbers" in programs, what I would like to do is replace each number with something a bit more meaningful.
We can do this by making a variable which is constant, i.e. it can never be changed.
`const double PI=3.141592654;`
