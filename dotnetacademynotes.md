

by default c# executes a method called Main at the starting point for an application

AKA the default entry point.


The method "Main" has public access modifier which means that this method can be called by other classes and even other assemblies.  

Access modifier is followed by static, which is a modifier that allows this function to be called without instantiating the class.  


without having to instantiate Program class first like:
```
var program = new Program();
program.Main();
```

Notice that C# uses brackets, { and } to indicate blocks of code. Now let's add our Main method.

```
using System;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Hello World");
  }
}
```

could call `System.Console.WriteLine()`

#Using Directives

`using System;`

enables us to use the Console library methods.

.NET framework organise their classes into containers called `Namespaces`

`System.Collections` - Contains classes for creating lists and dictionaries for storing data.
`System.IO` - Contains classes used to read and write files, and other disk operations.
`System.Xml` - Contains classes for using XML.

#Comments
```
// This is a comment.

        /*
           This is known as a
           multiline comment
        */
```

#Using classes
```
using System;

public class Program
{
	public static void Main()
	{
		World world = new World();
		world.Hello();
	}
}

public class World
{
	public void Hello()
	{
		Console.WriteLine("Hello World");
	}

}
```

#variables
These are types which define a certain set of requirements, including:

The storage space required to store a value of the type
The minimum and maximum values that can be represented with the type
The location in memory for variables of the type
What operations can be permitted
The base type it inherits from

all types inherit from object

```
string name = "Matt";
int age = 31;
DateTime today = DateTime.Now;
```

different types bring different methods to your code...
```
using System;

public class Program
{
	public static void Main()
	{
		DateTime now = DateTime.Now;
		Console.WriteLine(now);

		int maxValue = int.MaxValue;
		Console.WriteLine(maxValue);

		int minValue = int.MinValue;
		Console.WriteLine(minValue);

		string name = "Matt";
		string nameUpper = name.ToUpper();
		Console.WriteLine(nameUpper);
	}
}
```

#Value types
also known as a struct in c#. a value type stores its own allocation of memory.

a value type must have a value and cannot be set to null.

 For this reason, when you declare a value type variable without an initializer, it is implicitly initialized with the type's default value:

 ```
 int number; // Number is implicitly set to 0, or default(int)
 ```


When you pass a value type to a method, you are in essence cloning the value, so any changes you make to your variable in your method, will not be reflected in your original variable

```
using System;

public class Program
{
	public static void Main()
	{
		int value = 1;
		Method1(value);
		Console.Write(value); // Value is still 1.
	}

	public static void Method1(int value)
	{
		value = 2;
	}
}
```

This is known as pass by value.

#Reference types

reference types do not store its value directly, instead stores in another location in memory and referecnces it.

```
using System;

public class Program
{
	public static void Main()
	{
		Person person = new Person();
		person.Age = 30;
		Console.WriteLine(person.Age);

		Method1(person);
		Console.WriteLine(person.Age);
	}

	public static void Method1(Person person)
	{
		person.Age = 40;
	}
}

public class Person
{
	public int Age { get; set; }		
}
```

#Primitive types

A primitive type, whilst is is an alias for an actual type, it can also be used as the value for a constant, and can be represented as a literal value in your code.

In the following example, the values of "1", "hello" are literals, as they are literally written into your code.


Primitive type	Aliased Type
sbyte	System.SByte
byte	System.Byte
short	System.Int16
ushort	System.UInt16
int	System.Int32
uint	System.UInt32
long	System.Int64
ulong	System.UInt64
char	System.Char
float	System.Single
double	System.Double
bool	System.Boolean
decimal	System.Decimal


#constants

Another type of declaration that is possible in code, is something known as a constant, which is declared using the const keyword. When you declare constant values, they can no longer be changed. Once a constant value is set, it cannot be changed.


you can only declare constants with literal values.

```
const int one = 1;
const string two = "two";
```

#var

 It's primary purpose is a language feature called type inference

 ```
 using System;

public class Program
{
	public static void Main()
	{
		var one = 1;
		var two = "two";
	}
}
```

That is still perfectly valid C#, and the reason this works, is because the compiler will infer what type that one and two represent based on their assignments

Anonymous types (we'll come to these in a future tutorial) wouldn't be possible without the var keyword

`var person = new { Name = "John Smith" };`



```
