## C#

use linqPad to test code
its syntax sensitive
camelCasing

```
using System;

public class Hello
{
    public static void Main()
    {
        System.Console.WriteLine("Goodbye, World!");
    }
}
```


# Variables and Types

c# is statically typed, therefore variables must be declared before using them.
Essentially, C# can handle three types of data, floating point numbers, integer numbers and text

```
int myInt = 1;
float myFloat = 1f;
bool myBoolean = true;
string myName = "John";
char myChar = 'a';
```

compiler can determine the type of variable

```
var x = 1;
var y = 2;
var sum = x + y;    // sum will also be defined as an integer
```

#Enums

Enums are integers that should be used when an integer is used to specify an option from a fixed amount of options.

```
public enum CarType
{
    Toyota = 1,
    Honda = 2,
    Ford = 3,
}

public class Tutorial
{
    public static void Main()
    {
        CarType myCarType = CarType.Toyota;
    }
}
```


### Examples
```
using System;

public class Tutorial
{
   public static void Main()
   {
      // write your code here
      string productName = "TV";
      int productYear = 2012;
      float productPrice = 279.99f;

      // test code
      Console.WriteLine("productName: " + productName);
      Console.WriteLine("productYear: " + productYear);
      Console.WriteLine("productPrice: " + productPrice);
   }
}
```

#Arrays

Arrays in c# are defined by []

```
int[] nums = { 1, 2, 3, 4, 5 };
int[] nums = new int[10];
```
to access an element in the array
```
int firstNumber = nums[0];
```

#Multidimensional Arrays
```
int[,] matrix = new int[2,2];

matrix[0,0] = 1;
matrix[0,1] = 2;
matrix[1,0] = 3;
matrix[1,1] = 4;

int[,] predefinedMatrix = new int[2,2] { { 1, 2 }, { 3, 4 } };
```

#Lists

a list is an object which holds variables in a specific order.
the type of variables the list can hold is defined using the generic syntax.

the below holds integers

```
List<int> numbers = new List<int>();
```
add numbers to the list like so
```
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
```

can add a whole array to a list using the following syntax `addRange(array)`

```
int[] array = new int[] { 1, 2, 3 };
numbers.AddRange(array);
```

using `Remove` to remove an item from a list

```
List<string> fruits = new List<string>();
// add fruits
fruits.Add("apple");
fruits.Add("banana");
fruits.Add("orange");

// now remove the banana
fruits.Remove("banana");
Console.WriteLine(fruits.Count);
```

using `RemoveAt(index)` and specifing an index to remove at.

```
List<string> fruits = new List<string>();
// add fruits
fruits.Add("apple");
fruits.Add("banana");
fruits.Add("orange");

// now remove the banana
fruits.RemoveAt(1);
Console.WriteLine(fruits.Count);
```

using `AddRange` to concatenate lists
```
List<string> food = new List<string>();
food.Add("apple");
food.Add("banana");

List<string> vegetables = new List<string>();
vegetables.Add("tomato");
vegetables.Add("carrot");

food.AddRange(vegetables);
Console.WriteLine(food.Count);
```

##Example

```
public class Hello
{
    public static void Main()
    {


        List<int> primeNumbers = new List<int>();
        int [] array = new int []{2,3,5,7,11};
        primeNumbers.AddRange(array);

        Console.WriteLine(primeNumbers.Count);
        Console.WriteLine(primeNumbers[0]);
        Console.WriteLine(primeNumbers[1]);
        Console.WriteLine(primeNumbers[2]);
        Console.WriteLine(primeNumbers[3]);
        Console.WriteLine(primeNumbers[4]);

    }
}
```

#Dictionary

Dictionaries are special lists where every value has a key which is also a variable.

two methods below to add to a dictionary

```
Dictionary<string, long> phonebook = new Dictionary<string, long>();
phonebook.Add("Alex", 4154346543);
phonebook["Jessica"] = 4159484588;
```

need to define a definition with two types.
type of key, type of value.


`ContainsKey("Alex")` ContainsKey method for accessing elements in the dictionary.

`phonebook.Remove("Jessica");` Removes items from the dictionary.

removing an item by its key is fast and efficient removing by the value is very slow.


##Example
```
using System;
using System.Collections.Generic;

public class Hello
{
    public static void Main()
    {
        // TODO: add the inventory dictionary here
		Dictionary<string, int> inventory = new Dictionary<string, int>();
        inventory.Add("apple", 3);
        inventory.Add("orange", 5);
        inventory.Add("banana", 2);
        Console.WriteLine(inventory["apple"]);
        Console.WriteLine(inventory["orange"]);
        Console.WriteLine(inventory["banana"]);

    }
}
```

#Strings

define a string using quotes

`string myString = "A string.";`

In C#, a string is an alias for the String object.

2 ways to create an empty string
```
string emptyString = String.Empty;
string anotherEmptyString = "";
```

can concatenate strings using the + operator

to add ones string to another use the += operator

```
string sentence = "I like to play ";
sentence += "chess.";
Console.WriteLine(sentence);
```

#String formatting

can format strings using the `String.Format` function.
converting integers to strings

```
int x = 1, y = 2;
int sum = x + y;
string sumCalculation = String.Format("{0} + {1} = {2}", x, y, sum);
Console.WriteLine(sumCalculation);
```

Each additional argument to the function can be referred to in the string using the brackets operator with the index number. For example, {1} refers to the second argument provided for the format function.

#Substring

substring method returns a part of the string, beginning from the index specified as the arguement.

```
string fullString = "full string";
string partOfString = fullString.Substring(5);
string shorterPart = fullString.Substring(5, 3);
Console.WriteLine(partOfString);
Console.WriteLine(shorterPart);
```

#Search and replace

the `Replace` string method replaces and occurences of a string with another string.

```
string name = "John Doe";
string newName = name.Replace("John", "Eric");
Console.WriteLine(newName);
```

#Index of
the `IndexOf` string method finds the first occurence of a string in a larger string. If the string is not found, -1 is returned.

```
string fruit = "apple,orange,banana";
Console.WriteLine("Found orange in position: " + fruit.IndexOf("orange"));
Console.WriteLine("Found lemon in position: " + fruit.IndexOf("lemon"));
```

##Example

please note you need to add the variables at the end of the String.Format method
```
using System;

public class Hello
{
    public static void Main()
    {
        string firstName = "John";
        string lastName = "Doe";
        int age = 27;

        string sentence = String.Format("{0} {1} is {2} years old.",
            firstName, lastName, age);

        Console.WriteLine(sentence);

    }
}
```

#For loops

Like java and javascript...

```
int i;

for( i = 0; i < 10; i++)
{

}
```
can declare the variable in the loop
```
for( int i = 0; i < 10; i++)
```
loops are used to repeat sections of code a fixed or variable amount of times.

`break;` allows you to exit the loop without finishing the loop

```
for(int i = 0; i < 16; i++)
{

    if(i == 12)
    {
        break;    
    }
}
```
`continue;` allows you to skip straight to the next iteration.

```
for(int i = 0; i < 16; i++)
{

    if(i % 2 == 1)
    {
        continue;
    }

    Console.WriteLine(i);

}
```
##Example
```
using System;

public class Functions
{
    public static void Main()
    {
        string x = "Hi";
        int n = 10;

        for( int i = 0; i < n; i++)
        {
            Console.WriteLine(x);
        }
    }

}
```

#While loops

allow you to continuously repeat a section of code until a condition is met...
```
while([conditions to be checked])
{
[Code to execute]
}
```

This would execute once as N is changed from zero the first time it runs. Unlike for loops, while loops do not allow you to declare or assign the variable used in the conditions.

The same control statements (break and continue) as are used in for loops can also be used in while loops.


```
int n = 0;

while( n == 0)
{
    Console.WriteLine("N is 0");
    n++;
}
```

##Example
```
using System;

public class Functions
{
    public static void Main()
    {
        string x = "Hi";
        int n = 10;

        int i = 0;

        while(i < n)
        {
            Console.WriteLine(x);
            i++;
        }
    }

}
```

#Methods

Methods are portions of a larger program that perform specific tasks

```
[Modifiers (E.G public or static)] [Type of output] [Name] ( [parameter 1],[parameter 2] ...)
{

}
```
```
public static int Multiply(int a, int b)
{

    return a * b;

}
```
This method has been passed two parameters, integer a and integer b, this is how you provide input for a subroutine (method).

The return statement stops the subroutine and (depending on the output type) can output a value of the same type as the output type you put at the top

```
//int is the output type

int Foo()
{

    //So you return an integer
    return 0;

}
```
use `void` when you do not need to return a value.
```
void Foo()
{

    //the output type is void, so you don't return a value
    return;

}

```

In this case the return statement simply stops the subroutine and does not give any output

#Example
```
using System;

public class Methods
{
    public static void Main()
    {

        int x = 2;
        int y = 2;
        int a = Foo(x,y);
        Console.WriteLine(a);

    }
	public static int Foo(int a, int b)
    {
        return a / b;
    }
}
```
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


#Methods

```
using System ;
    class MethodDemo
    {
        static void doit ()
        {
          Console.WriteLine ("Hello");
        }

        public static void Main ()
        {
          doit();
          doit();
        }
    }
```

with parameters

```
   using System ;
    class MethodDemo
    {
        static void silly ( int i )
        {
            Console.WriteLine ( "i is : " + i ) ;
        }
        public static void Main ()
        {
            silly ( 101 ) ;
            silly ( 500 ) ;
        }
    }
```

##return values

methods can also return values to the user

A parameter is the special kind of variable that is defined in the method header and used inside that method to represent the value that was fed into the method call.

`static int sillyReturnPlus ( int i)`

An argument is the value that is supplied to the method when it is called.

`sillyReturnPlus(99);`

#parameters

if you want to make method calls and not worry about the order you can name them like the below

`x = readValue(low:25, high:100, prompt: "Enter your age");`


you can add optional parameters with = ""

```
static double readValue (
    double low,
double high,
string prompt = "", )
{
... }
```

if more than one optional parameter identify optional parameter by name

`x = readValue(25, 100, error:"Age out of range");`


#parameter Passing By Reference

Rather than sending the value of a variable into a method, a reference to that variable is supplied instead.

Effectively the thing that is passed into the method is the position or address of the variable in memory, rather than the content of the variable.


```
static void addOneToRefParam ( ref int i )
{
i = i + 1;
          Console.WriteLine ( "i is : " + i ) ;
}
    ```


A change by a method to something around it is called a side effect of the method. In other words, when someone calls our addOneToRefParam method, it is going to have the “side effect” of changing something outside the method itself (namely the value of the parameter passed by reference). Generally speaking you have to be careful with side effects, as someone reading your program has to know that your method has made changes in this way.

#passing parameters as out

When you pass a parameter as a reference you are giving the method complete control of it. Sometimes you don't want this. Instead you want to just allow the method to change the variable


The original value of the parameters is of no interest to the method. Instead it just wants to deliver results to them. In this case I can replace the ref with the keyword out:

```
 static void readPerson ( out string name, out int age )
  {
        name = readString ( "Enter your name : " ) ;
        age = readInt ( "Enter your age : ", 0, 100 ) ;
  }
  ```

  ```
   static string readString ( string prompt )
    {
          string result ;
do
          {
               Console.Write ( prompt ) ;
               result = Console.ReadLine ();
          } while ( result == "" ) ;
          return result ;
    }
```

I can call readPerson as follows:
```
  string name ;
  int age ;
  readPerson ( out name, out age ) ;
```

In order to keep you from confusing yourself by creating two versions of a variable
with the same name, C# has an additional rule about the variables in the inner blocks:

```
{
int i ;
  {
    int i ;
  }
}
```
This is not a valid program because C# does not let a variable in an inner block have the same name as one in an outer block. This is because inside the inner block there is the possibility that you may use the "inner" version of i when you intend to use the outer one.

#class variable
```
  class MemberExample
   {
         // the variable member is part of the class
         static int member = 0 ;
   }
```

decalared as static as it is class variable

One common programming mistake is to confuse static with const. Marking a variable as const means “the value cannot be changed”. Marking a variable with static means “the variable is part of the class and is always present”.


#Arrays


```
using System;
class ArrayDemo
{
  public static void Main ()
   {
     int [] scores = new int [11]  ;
     for ( int i=0; i<11; i=i+1)
     {
       scores [i] = readInt ( "Score : ", 0,1000);
     }
   }
}
```

`int [] scores` part tells the compiler that we want to create an array variable. You can think of this as a tag which can be made to refer to a given array.

`new int [11]` the part that makes the array

Identify which element you mean by putting its number in square brackets [ ] after the array name.

`scores [i+1]`

When an array is created all the elements in the array are set to 0.

Arrays are zero indexed

```
using System;
class ArrayDemo
{
    public static void Main ()
    {
        int [] scores = new int [1000] ;
        for ( int i=0; i<1000; i=i+1)
        {
          scores [i] = readInt ( "Score : ", 0,1000);
        }
    }
}
```

Keep array size in constant variables

```
 const int SCORE_SIZE = 1000;
 int [] scores = new int [SCORE_SIZE] ;
 for ( int i=0; i < SCORE_SIZE; i=i+1)
 {
   scores [i] = readInt ( "Score : ", 0,1000);
 }
```

keep constants capital and separated by underscores

#2D Arrays

##create a grid
For example, to hold the board for a game of noughts and crosses (tic tac toe) we could use:
```
int [,] board = new int [3,3];
board [1,1] = 1;
```
##arrays and lookup tables

```
string[] monthNames = new string[13];
monthNames[1] = "January";
monthNames[2] = "February";
```

Programmer’s Point: Sometimes it is OK to “waste” array element 0

can initialize an array with many elements using the following syntax {}

```
string[] monthNames = new string[]
{
null, // null element for non existent month 0 "January", "February", "March", "April", "May", "June", "July", "August",
"September", "October", "November", "December"
};
```

and Multidimensional arrays too


```
int [,] squareWeights = new int [3,3] {{1,0,1},{0,2,0},{1,0,1}};

```
3d array
```
int [,,] board = new int [3,3,3];
board [1,1,1] = 1;
```

##Exceptions and parse methods
Parse is the method we use to convert strings of text into numeric values.
```
int age = int.Parse(ageString);
```
takes string stores it as an int

##catching Exceptions
dynamic error handling  
```
int age;
try
{
age = int.Parse(ageString);
Console.WriteLine("Thank you");
}
catch
{
Console.WriteLine("Invalid age value");
}
```

The try keyword is followed by a block of code. After the block of code comes the catch clause. If any of the statements following the try throws an exception the program runs the code in the catch clause to handle this error.


When Parse fails it creates an exception object that describes the bad thing that has just happened (in this case input string not in the correct format).

The program above ignores the exception object and just registers to the exception event but we can improve the diagnostics of our program by catching the exception if we wish:

```
int age;
try
{
   age = int.Parse(ageString);
   Console.WriteLine("Thank you");
}
catch (Exception e)
{
Console.WriteLine(e.Message);
}
```

you can nest try catch blocks within other try catches

adding `finally`
```
try
{
}
catch (Exception outer)
{
}
finally
{
}
```

In the above code the statements in the finally part are guaranteed to run, either when the statements in the try part have finished, or just before execution leaves the catch part of your program.

`throw new Exception("Boom");`

The statement above makes a new exception and then throws it. When you make a new exception you can give it a string that contains the message the exception will deliver.


Exceptions are best reserved for situations when your program really cannot go any further.


#Switch constructor

```
switch (selection)
{
  case 1 :
    handleCasement ();
    break ;
  case 2 :
    handleStandard () ;
    break ;
  case 3 :
    handlePatio () ;
    break ;
  default :
    Console.WriteLine ( "Invalid number" ) ;
    break ;
}
```

default gives switch to go if no where else!
can use strings instead of integers for case names.

you can also have multiple switch names...

```
switch (command)
{
      case "casement" :
      case "c" :
            handleCasement ();
            break ;
...
```
use ToUpper() to remove edge cases.

```
 switch (command.ToUpper())
 ```

#Streams
stream a link  between your program and your data source
data can flow up and down so streams can read and write.


A C# program can contain an object representing a particular stream that a programmer has created and connected to a file. The program performs operations on the file by calling methods on the stream object to tell it what to do.


Two stream types which let programs use files; these are the `StreamWriter` and `StreamReader` types.

`StreamWriter` creates an output stream...


```
StreamWriter writer ;
writer = new StreamWriter("test.txt");
```
When the new StreamWriter is created the program will open a file called test.txt for output and connect the stream to it.
If existing file by the same name it will be written over.

Once a stream had been created can write to it using

 `writer.WriteLine("hello world");`


When your program has finished writing to a stream it is very important that the stream is explicitly closed using the Close method:
                                 `writer.Close();`
When the Close method is called the stream will write out any text to the file that is waiting to be written and disconnect the program from the file. Any further attempts to write to the stream will fail with an exception.

`StreamReader` creates an input stream

very similiar to writing a file


```
StreamReader reader = new StreamReader("Test.txt");
string line = reader.ReadLine();
Console.WriteLine (line);
reader.Close();
```
`EndOfStream`determines when the end of the file has been reached. When the property becomes true the end of the file has been reached.
```
StreamReader reader = new StreamReader("Test.txt");
while (reader.EndOfStream == false)
    {
        string line = reader.ReadLine();
        Console.WriteLine(line);
    }
    reader.Close();
```

#File paths in C#

 If you don’t give a folder location when you open a file (as we have been doing with the file Test.txt) then the system assumes the file that is being used is stored in the same folder as the program which is running.

 you can add path information to a filename:
```
string path;
path = @"c:\data\2009\November\sales.txt";
```

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

```
using System;

public static class Kata
{
  public static string Leo(int oscar) => oscar > 88 ? "Leo got one already!" : (oscar == 88 ? "Leo finally won the oscar! Leo is happy" : (oscar == 86 ? "Not even for Wolf of wallstreet?!" : "When will you give Leo an Oscar?"));
}
```

#Relational operators
`==` `!=` `>` `<` `<=` `>=` `!`
`&&`
`||`


#Magic Numbers
I do not like the idea of "magic numbers" in programs, what I would like to do is replace each number with something a bit more meaningful.
We can do this by making a variable which is constant, i.e. it can never be changed.
`const double PI=3.141592654;`
