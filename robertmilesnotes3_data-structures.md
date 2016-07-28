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
