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
