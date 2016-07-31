#Enumerated types
think of "enumerated" as just meaning "numbered" things.
Enumerated types are very useful when storing state information.
```
enum SeaState
{
EmptySea,
Attacked,
Battleship,
Cruiser,
Submarine,
RowingBoat
};
```
I have created a type called SeaState which can be used to hold the state of a particular part of the sea.
It can only have the given values above, and must be managed solely in terms of these named enumerations.

For example I must write:
```
SeaState openSea ;
openSea = SeaState.EmptySea;
```

My variable openSea is only able to hold values which represent the state of the sea contents.

SeaState items are extra types I have created which can be used to create variables,


The new enum type can be created outside any class and creates a new type for use in any of my programs:

```
using System;
enum TrafficLight
{
Red,
RedAmber,
Green,
Amber
};
class EnumDemonstration
{
    public static void Main ()
    {
        TrafficLight light ;
        light = TrafficLight.Red;
        Console.WriteLine(light);
    }
}
```
Every time that you have to hold something which can take a limited number of possible values, or states (for example OnSale, UnderOffer, Sold, OffTheMarket etc) then you should think in terms of using enumerated types to hold the values.


#Structures

let you organise a set of individual values in a cohesive lump..

C# lets you create data structures. A structure is a collection of C# variables which you want to treat as a single entity.

below is a sructure and changing the values of the element
```
struct Account
{
  public AccountState State;
  public string Name ;
  public string Address ;
  public int AccountNumber ;
  public int Balance ;
  public int Overdraft ;
};


Account RobsAccount;
RobsAccount.Name="Rob";

```
Structures get very useful when we create arrays with them...

```
const int MAX_CUST = 100;
Account [] Bank = new Account [MAX_CUST];
```

This declaration sets up an entire array of customers called Bank.


You should give state to your objects

The Account class above is a good example of an object that will be used in different ways, depending on the state that it is occupying. For example, it will not be possible to withdraw funds from an account which is in the Frozen state. Just about every object in a system can be improved by the addition of state.

#Objects and Structures

In C# objects and structures have a lot in common. They can both hold data and contain methods.


Structures are managed in terms of value whereas objects are managed in terms of reference.

By changing it from a struture to a class, the account information is now being held in a class, rather than a structure. The account class is called, quite simply, Account.

```
class Account
{
      public string Name ;
};
class StructsAndObjectsDemo
{
    public static void Main ()
      {   
        Account RobsAccount ;
        RobsAccount = new Account();
        RobsAccount.Name = "Rob";
        Console.WriteLine (RobsAccount.Name );
      }     
}
```

We have seen this keyword `new` before. We use it to create arrays. This is because an array is actually implemented as an object, and so we use new to create it. The thing that new creates is an object.


An object is an instance of a class.

can reference the instance of the object multiple times

```
Account RobsAccount ;
RobsAccount = new Account();
RobsAccount.Name = "Rob";
Console.WriteLine (RobsAccount.Name );
Account Temp ;
Temp = RobsAccount;
Temp.Name = "Jim";
Console.WriteLine (RobsAccount.Name );
```


Objects can be initiated without any reference

if an instance has nothing referring to it, it might as well not be there. Indeed the C# language implementation has a special process, called the “Garbage Collector” which is given the job of finding such useless items and disposing of them. Note that the compiler will not stop us from “letting go” of items like this.

```
class Account
{
    public decimal Balance;
}

Account RobsAccount;
RobsAccount = new Account();
RobsAccount.balance = 99;

```

can access these variables because they are public


#Protection inside objects

`Encapsulation` or defensive programming approach

Changing private members

```
public class Account
{
       private decimal balance = 0;
       public bool WithdrawFunds ( decimal amount )
       {
             if ( balance < amount )
             {
                    return false ;
             }
             balance = balance - amount ;
             return true;
        }

        public void PayInFunds ( decimal amount )
        {
             balance = balance + amount ;
        }
       public decimal GetBalance ()
       {
             return balance;
        }
}
```
nce we want people to interact with our objects by calling methods in them. In general the rules are:
• if it is a data member (i.e. it holds data) of the class, make it private
• if it is a method member (i.e. it does something) make it public

`private` is lower case

#Static

`static` is for members not held in the instance of the class, but in the class itself.

it is used in the Main method to run the program.

if you made 50 instances of a class they would all share the same Main method.

part of the class not the instance. not that it cannot be changed

e.g . used on an interest rate that would cover multiple accounts at a bank.

```
  public class Account
  {
    public decimal Balance ;
    public static decimal InterestRateCharged ;
  }

  Account RobsAccount = new Account();
  RobsAccount.Balance = 100;
  Account.InterestRateCharged = 10;
```
since its held in the account you use the Class name to access it.

#Static methods

We can make methods static too.

you can call the methods without having an account instance. e.g. a method to test if the person is acceptable to have an account.

N.B. the variables outside the method need to be static too.

```
public class AccountAllowed
{
  private static decimal minIncome = 10000;
  private static int minAge = 18;
  public static bool AccountAllowed ( decimal income, int age )
{
      if ( ( income >= minIncome ) && ( age >= minAge ) )
      {
          return true;
      }
      else
      {
          return false;
      }
  }
}
```
can be called on the class name like so

` Account.AccountAllowed ( 25000, 21 )`

Static methods are used in the construction of libraries.


#Construction of Objects

objects are created when we uses `new`...

`test = new Account();`

every class must have a constructor method.
default constructor method looks like the below, it takes no args and is public so can be accessed in other classes.
```
 public class Account
{
     public Account ()
     {
     }
}
```

can override with what ever we want, for e.g. to feed in our own params to setup the account.
```
 class Account
{
  // private member data
  private string name;
  private string address;
  private decimal balance;
  // constructor
  public Account (string inName, string inAddress,
    decimal inBalance)
  {
    name = inName;
    address = inAddress;
    balance = inBalance;
  }
}
```
if you override constructor cannot access the default one.

#overloading

"A method has the same name as another, but has a different set of parameters"

the call will be matched up with the method which accepts the correct parameters

```
 public Account (string inName, string inAddress,
      decimal inBalance)
    {
      name = inName;
      address = inAddress;
      balance = inBalance;
}
    public Account (string inName, string inAddress)
    {
      name = inName;
      address = inAddress;
      balance = 0;
}
    public Account (string inName)
    {
      name = inName;
      address = "Not Supplied";
      balance = 0;
}
```

This is not good programming as it is not DRY.

you can use the keyword `this` which means another constructor in the class.

```
public Account (string inName, string inAddress,
      decimal inBalance)
    {
      name = inName;
      address = inAddress;
      balance = inBalance;
    }
    public Account ( string inName, string inAddress ) :
      this (inName, inAddress, 0 )
    {
}
    public Account ( string inName ) :
      this (inName, "Not Supplied", 0 )
    {
}
```

`this` is used to call the first constructor. pass the params to the proper constructor to deal with it.


```
class Bank
{
  public static void Main()
  {
      const int MAX_CUST = 100;
      Account[] Accounts = new Account[MAX_CUST];
      Accounts[0] = new Account("Rob", "Robs House",
                                1000000);
      Accounts[1] = new Account("Jim", "Jims House");
      Accounts[2] = new Account("Fred");
  }
}
```

constrcutors cannot fail!

the only way round this is to add exceptions to the method.


#Components and interfaces

Interface is a set of method defintions that are lumped together...

```
public interface IAccount
{
  void PayInFunds ( decimal amount );
  bool WithdrawFunds ( decimal amount );
  decimal GetBalance ();
}
```

this the interface for the Account. Coding conventions dictate that interfaces should start with the letter I.

interfaces need to be implemented by a class


```

public class CustomerAccount : IAccount
{
   private decimal balance = 0;
   public bool WithdrawFunds ( decimal amount )
   {
     if ( balance < amount )
     {
       return false ;
     }
    balance = balance - amount ;
    return true;
    }
    public void PayInFunds ( decimal amount )
    {
      balance = balance + amount ;
    }
    public decimal GetBalance ()
    {
      return balance;
    }
}
```
the top line is where the Iaccount interfcace is implemented. If the class does not contain a method the interface needs you will get a compiler error.

`CustomerAccount` is what is is
`IAccount` is what it can do


need to be able to reference which refer to objects in terms of their interfaces...

```
IAccount account = new CustomerAccount();
account.PayInFunds(50);
Console.WriteLine("Balance: " + account.GetBalance());
```

Now an interface has been defined it is much easier to extend, can create a baby account which implements all the required methods but behaves slightly differently.
```
public class BabyAccount : IAccount
{
  private decimal balance = 0;
  public bool WithdrawFunds ( decimal amount )
       {
          if (amount > 10)
          {
             return false ;
          }
          if (balance < amount)
          {
             return false ;
          }
          balance = balance - amount ;
          return true;
       }
       public void PayInFunds ( decimal amount )
       {
          balance = balance + amount ;
       }
       public decimal GetBalance ()
       {
          return balance;
       }
}
```
```
accounts[0] = new CustomerAccount();
accounts[0].PayInFunds(50);
Console.WriteLine("Balance: " +
accounts[0].GetBalance());
accounts[1] = new BabyAccount();
accounts[1].PayInFunds(20);
Console.WriteLine("Balance: " +
accounts[1].GetBalance());
```


`Duck typing`??


a component can implement many interfaces

```
public interface IPrintToPaper
{
    void DoPrint ();
 }
 ```
implements the account and print interfaces now

 `public class BabyAccount : IAccount, IPrintToPaper`


#Inheritance
can pick up behaviours from the class which is parent and inherit it into the child.

syntax to inherit is

`public class BabyAccount : CustomerAccount,IAccount`

instances of BabyAccount now have access to the methods from CustomerAccount.


`override`keywords overrides the methods from the parent class...

```
public override bool WithdrawFunds (decimal amount)
                                    {
                                      ```

`virtual` keyword must be added to the super class so the compiler knows it can be overridden.

The keyword virtual means “I might want to make another version of this method in a child class”.

If the class is going to be inherited `private` values in the class will not be able to be altered. `protected` is used instead which makes the members visible to classes that extend the parent.

```
  public class CustomerAccount : IAccount
    {
       protected decimal balance = 0;
..... }
```

`base` method = “a reference to the thing which has been overridden”.

```
  public class BabyAccount : CustomerAccount, IAccount
{
public override bool WithdrawFunds (decimal amount)
{
  if (amount > 10)
  {
     return false ;
  }
  return base.WithdrawFunds(amount);
  }
}
```

the base mehtod here makes a call to the CustomerAccount and not the BabyAccount

you could change back to private from protected by using this technique

`sealed` keyword means you cannot override these methods.

```
 public sealed class BabyAccount : CustomerAccount,IAccount
{
.....
}
```

to create an object from a parent object use the `base` method in the params of the method.

```
public CustomerAccount (string inName, decimal inBalance) :
base ( inName, inBalance)
{
}
```
#Abstract mehtods and classes

way of flagging a method as abstract. This means that the method body is not provided in this class, but will be provided in a child class:


```
 public abstract class Account
{
      public abstract string RudeLetterString();
}
```

when you create a class it is in fact a child of object class many behaviours come with this class.


#ToString()
converts to string! is virtual and can be overridden

```
class Account
{
 private string name;
 private decimal balance;
 public override string ToString()
 {                                  
   return "Name: " + name + " balance: " + balance;
 }
  public Account (string inName, decimal inBalance)
   {
     name = inName;
     balance = inBalance;
   }
}
```

#this

this is a reference to the current instnace...

```
public class Counter
{
  public int Data=0;
  public void Count ()
  {
     this.Data = this.Data + 1;
  }
}
```

We can add a `this`. if we like to make it explicit that we are using a member of a class rather than a local variable.

this can be used to provide a reference to itself to another class that wants to use it.

#Immutable strings
The idea is that if you try to change a string, the C# system instead creates a new string and makes the reference you are "changing" refer to the changed one. In other words, when the system sees the line:
                                 s2 = "different";
- it makes a new string which contains the text "different" and makes s2 refer to that.


#String Comparison

strings can be compared not as objects but as strings either with `==` or `x.Equals(x2)`

#String Editing

```
string h1 = "string";
char firstCh = h1[0]; // returns 's'
```

`Substring(,)` first param is the index second the amount of chars
```
string s1 = "Rob";
s1= s1.Substring(1,2);// 'ob'
```

`.Length`

gets the length of the string

`.ToUpper()``.ToLower()`

`.Trim()`

removes any white space

#Properties as class members

to get around having to make properties public we use getter and setter methods, these methods are public.

```
 public class StaffMember
{
  private int age;
  public int GetAge()
  {
     return this.age;
  }
  public void SetAge( int inAge )
  {
     if ( (inAge > 0) && (inAge < 120) )
     {
        this.age = inAge;
     }
  }
}
```
#Delegates Progs and Lambdas??

“A way of telling a piece of program what to do when something happens”
A delegate is a type safe reference to a method in a class.


`public delegate decimal CalculateFee (decimal balance);`


```
public decimal RipoffFee (decimal balance)
{
       if ( balance < 0 )
       {      
        return 100; }
        else
        {
        return 1;
        }
}
```
`CalculateFee calc = new CalculateFee (RipoffFee);`
`fees = calc(100);`

#Storing in an Array

```
private IAccount [] accounts ;
public ArrayBank( int bankSize )
{
    accounts = new IAccount[bankSize];
}
```

`IBank friendlyBank = new ArrayBank (50);`

#Adding to an array
```
public bool StoreAccount (IAccount account)
{
    int position = 0;
    for (position = 0; position<accounts.Length; position++)
    {
        if (accounts[position] == null)
        {
            accounts[position] = account;
            return true;
        }
      }         
    return false;
}
```
This method works through the array looking for an element containing null. If it finds one it sets this to refer to the account it has been asked to store and then returns true. If it does not find a null element before it reaches the end of the array it returns false to indicate that the store has failed.

FindAccount which will find the account which matches a particular customer name:
`IAccount fetchedAccount = arrayBank.FindAccount("Rob");`

This will either return the account with the required name, or null if the account cannot be found. In the array based implementation of the bank this is achieved by means of a simple search:
```
public IAccount FindAccount ( string name )
{
    int position=0 ;
    for (position=0 ; position<accounts.Length ; position++)
    {
        if ( accounts[position] == null )
        {
        continue;
        }
        if ( accounts[position].GetName() == name )
        {
            return accounts[position];
        }
      }
    return null;
}
  ```

#Hash table
found in System.Collections

```
 class HashBank : IBank
{
  Hashtable bankHashtable = new Hashtable();
  public IAccount FindAccount(string name)
  {
      return bankHashtable[name] as IAccount;
  }
  public bool StoreAccount(IAccount account)
  {
      bankHashtable.Add(account.GetName(), account);
      return true;
  }
}
```

provides the `.Add` method

We have to use the "as" part of this code as the collection will return a reference to an object. We want to return a reference to an instance which implements the IAccount interface.


#Advanced programming

#ArrayList

cousin of HashTable

used when dont know the size of the Array...

`ArrayList store = new ArrayList();`

and to add to it... `.Add`

`store.Add(robsAccount);`

Accessing items from an ArrayList

The designers of the ArrayList class had no idea precisely what type of object a programmer will want to use it with and so they had to use the object reference.

This is not actually a huge problem, because a program can use a cast to change the type of the item the arraylist returns:

```
    Account a = (Account) store[0];
    a.PayInFunds(50);
```

Array list is not typesafe, can Add any object to it!

a really useful Remove behaviour. This is given a reference to the thing to be removed:

    `store.Remove(robsAccount);`

    `.Count` tells you the size of the ArrayList
    `.Contains` checks to see if the Arraylist contains a particular refernece
