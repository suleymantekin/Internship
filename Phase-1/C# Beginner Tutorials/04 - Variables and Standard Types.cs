/*
    Author: Süleyman Tekin
    Date  : 05.07.2018
 */

 // 3.1 Exercise: Declare a string
 // Declare a string variable called 'name', with an initial value of 'John'

 public class Program
{
	public static void Main()
	{
		string name = "John";
	}
}


// 3.2 Exercise: Declare an integer
// Declare an 'int' variable called 'age', with an initial value of '30'

public class Program
{
	public static void Main()
	{
		int age = 30;
	}
}


// 6.1 Exercise: Declare a number using a primitive type
// Declare an integer (int) variable using the primitive type alias, with a value of 100.

using System;

public class Program
{
    public static void Main()
    {
		int value = 100;	
    }
}


// 6.2 Exercise: Declare an instance of the 'Int32' type
// Declare the same number again, using the actual source type (Int32), with a value of 100.

using System;

public class Program
{
    public static void Main()
    {
		Int32 value = 100;
    }
}


// 7.1 Exercise: Declare a constant string
// Declare a string, using the const keyword, with a value of "Hello";

using System;

public class Program
{
	public static void Main()
	{
		const string value = "Hello";
	}
}


/*  -- Notes --
    Why should you use var keyword?
 */

// 1 - We can use var to help minimise the amount of code we have to type, e.g.:
ConcurrentDictionary<string, int> dictionary = new ConcurrentDictionary<string, int>(); // Long hand
var dictionary = new ConcurrentDictionary<string, int>(); // Shorter

// 2 - Anonymous types wouldn't be possible without the var keyword
var person = new { Name = "John Smith" };


// 8.1 Exercise: Declare an number using the var keyword
// Declare an integer number named age with a value of 31 using var

public class Program
{
    public static void Main()
    {
		var age = 31;
    }
}