/*
    Author: Süleyman Tekin
    Date  : 05.07.2018
 */

// 3.1 Exercise: Using Console.WriteLine
// Use Console.WriteLine(...) to write the text "This is the first line", "This is the second line" and "This is the third line" as three separate statements.

using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("This is the first line");
		Console.WriteLine("This is the second line");
		Console.WriteLine("This is the third line");
	}
}


// 4.1 Exercise: Using Console.Write
// Use Console.Write(...) to write the text "Hello", " " and "World" as three separate staments.

using System;

public class Program
{
	public static void Main()
	{
		Console.Write("Hello");
        Console.Write(" ");
        Console.Write("World");
	}
}


// 5.1 Exercise: Using Console.ReadLine
// Use Console.ReadLine and assign the result to the variable called "name".

using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hi, what is your name?");

        string name = Console.ReadLine();

        Console.WriteLine("Hi, " + name);
    }
}

/*  -- Notes --
    Console.Read returns an integer, you can get the character like this:
    int value = Console.Read();
    char letter = (char)value;
 */