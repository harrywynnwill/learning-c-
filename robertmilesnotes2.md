
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
