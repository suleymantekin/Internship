/*
    Author: Süleyman Tekin
    Date  : 05.07.2018
 */


// 3.1 Exercise: Console.WriteLine
// Use Console.WriteLine(...) to write "Hello Universe" to the Console window.

using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello Universe");

	}
}


// 4.1 Exercise: Using Directive
// Fix the following code so the output of the program reads "Hello World"

using System;
	
public class Program
{
  public static void Main()
  {
    Console.WriteLine("Hello World");
  }
}


// 4.2 Exercise: Avoid the Using Directive
// Fix the following code so the output of the program reads "Hello World", without adding a using directive.

public class Program
{
  public static void Main()
  {
    System.Console.WriteLine("Hello World");
  }
}


// 5.1 Exercise: Single-line Comments
// Comment out the Console.WriteLine("Hello World"); statement below using a single-line comment.

using System;

public class Program
{
    public static void Main()
    {
        //Console.WriteLine("Hello World");
    }
}


// 5.2 Exercise: Multi-line Comments
// Comment out the two Console.WriteLine statements below using a multi-line comment.

using System;

public class Program
{
    public static void Main()
    {
		/*
			Console.WriteLine("Hello");
			Console.WriteLine("World");
		*/
    }
}