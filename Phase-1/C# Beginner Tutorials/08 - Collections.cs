/*
    Author: Süleyman Tekin
    Date  : 06.07.2018
 */


// 2.1 Exercise: Declare an array
// Please create a new string array, without using the var keyword. This array must be of length 0.

using System;

public class Program
{
    public static void Main()
    {
        // Create your array here.
		string[] array = new string[0];
    }
}


// 2.2 Exercise: Read and write array values
// Please set the first item in the array to 'Han Solo'. On the next line, write the first item in the array to the Console.

using System;

public class Program
{
    public static void Main()
    {
        string[] names = new string[1];
        
        // Your code goes here.
		names[0] = "Han Solo";
		Console.WriteLine(names[0]);
    }
}


// 2.3 Exercise: Loop through the array
// Please create a for loop after the array declaration, and loop through the values, writing each to the console.

using System;

public class Program
{
    public static void Main()
    {
        int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        // Your code goes here.
		for(int i = 0; i < numbers.Length; i++){
			Console.WriteLine(numbers[i]);
		}
    }
}


// 3.1 Exercise: Declare a list
// Please create a new string list, without using the var keyword. This list should contain no values.

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Create your list here
		List<string> list = new List<string>();
    }
}


// 3.2 Exercise: Read and write list values
// Please add the item Chewbacca to the list. On the next line, write the first item in the list to the Console.

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<string> characters = new List<string>();
        
        // Your code goes here.
		characters.Add("Chewbacca");
		
		Console.Write(characters[0]);
    }
}


// 3.3 Exercise: Remove an item from the list
// Please remove the item "Luke Skywalker" from the list using the value itself.

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<string> characters = new List<string>()
        {
            "Luke Skywalker",
            "Han Solo",
            "Chewbacca"
        };
        
        // Your code goes here.
		characters.Remove("Luke Skywalker");
    }
}


// 3.4 Exercise: Remove an item from the list another way
//Please remove the third item from the list using its index.

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<string> characters = new List<string>()
        {
            "Luke Skywalker",
            "Han Solo",
            "Chewbacca"
        };
        
        // Your code goes here.
		characters.RemoveAt(2);
	}
}


// 3.5 Exercise: Loop through the list
// Please create a foreach loop after the list declaration, and loop through the values, writing each to the console.

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<string> characters = new List<string>()
        {
            "Luke Skywalker",
            "Han Solo",
            "Chewbacca"
        };
        
        // Your code goes here.
		foreach(string character in characters){
			Console.WriteLine(character);
		}
    }
}


// 4.1 Exercise: Declare a dictionary
// Please create a new dictionary, where the key type is a string and the value type is an int. This dictionary should contain no values.

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Your code here.
		Dictionary<string, int> dict = new Dictionary<string, int>();
    }
}


// 4.2 Exercise: Read and write dictionary values
// Please add a new value, the key of which is your name, and the value of which is your age. Do this using the Add method.
// Next, add another value to the dictionary using the index notation. This time, use a different name and a different age.
// Lastly, read the first item you added to the dictionary, and write it to the console using Console.WriteLine`.

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Dictionary<string, int> people = new Dictionary<string, int>();

        // Your code here.
		people.Add("Suleyman", 23);
		people["Paul"] = 34;
		
		Console.WriteLine(people["Suleyman"]);
    }
}


// 4.3 Exercise: Remove an item from the dictionary
// Please remove the item with the key 'Han' from the dictionary.

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Dictionary<string, bool> characters = new Dictionary<string, bool>()
        {
            { "Luke", true },
            { "Han", false },
            { "Chewbacca", false }
        };

        // Your code here.
		characters.Remove("Han");
    }
}


// 4.4 Exercise: Loop through the dictionary
// Please create a foreach loop after the dictionary declaration and loop through the tiems, writing the Value to the console using Console.WriteLine. Your loop variable should be declared as 'var'.

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Dictionary<string, bool> characters = new Dictionary<string, bool>()
        {
            { "Luke", true },
            { "Han", false },
            { "Chewbacca", false }
        };

        // Your code here.
		foreach(var character in characters){
			Console.WriteLine(character.Value);
		}
    }
}


// 5.1 Exercise: Declare a queue
// Please create a new queue of type int, named primes.

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Your code here
		Queue<int> primes = new Queue<int>();
    }
}


// 5.2 Exercise: Add items to the queue
// Please add the first 5 primes to the queue.

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Queue<int> primes = new Queue<int>();

        // Your code here
		primes.Enqueue(2);
		primes.Enqueue(3);
		primes.Enqueue(5);
		primes.Enqueue(7);
		primes.Enqueue(11);
    }
}


// 5.3 Exercise: Loop through the queue
// Please loop through the queue using a while loop, and add the next item to the total variable. 
// After the loop, please write the total to the console using Console.WriteLine.

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Queue<int> primes = new Queue<int>();

        primes.Enqueue(2);
        primes.Enqueue(3);
        primes.Enqueue(5);
        primes.Enqueue(7);
        primes.Enqueue(11);

        int total = 0;

        // Your code here
		while( primes.Count > 0 ){
			total += primes.Dequeue();
		}
		Console.WriteLine(total);
    }
}


// 6.1 Exercise: Declare a stackusing System;
// Please create a new stack of type string, named films.

using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Your code here
		Stack<string> films = new Stack<string>();
    }
}


// 6.2 Exercise: Add items to the stack
// Please add the original 3 Star Wars film names to the stack.

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Stack<string> films = new Stack<string>();

        // Your code here
		films.Push("A New Hope");
		films.Push("The Empire Strikes Back");
		films.Push("Return Of The Jedi");
    }
}


// 6.3 Exercise: Loop through the stack
//Please loop through the stack using a do-while loop, and remove each item from it. Write each item to the Console using WriteLine.

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Stack<string> films = new Stack<string>();

        // Your code here
		films.Push("A New Hope");
		films.Push("The Empire Strikes Back");
		films.Push("Return Of The Jedi");
		
		do{
			Console.WriteLine(films.Pop());
		}while(films.Count > 0);
    }
}


// 7.1 Exercise: Declare a linked list
// Please create a new linked list of type string named movies.

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Your code here
		LinkedList<string> movies = new LinkedList<string>();
    }
}


// 7.2 Exercise: Add items to the list
//Add 'Avatar' as the first item in the list.
// Create a LinkedListNode<string> named titanic with the value 'Titanic' and add it to the last position in the list.
// Add 'Star Wars: The Force Awakens after 'Titanic' using the 'titanic` node as an anchor.

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        LinkedList<string> movies = new LinkedList<string>();

        // Your code here
		movies.AddFirst("Avatar");
		var titanic = new LinkedListNode<string>("Titanic");
		movies.AddLast(titanic);
		movies.AddAfter(titanic, "Star Wars: The Force Awakens");
		
    }
}


//  7.3 Exercise: Remove items from the list
// Remove the value C-3PO from the list.
// Find the node for R2-D2 and then remove it from the list.
// Remove the last item from the list.

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        LinkedList<string> droids = new LinkedList<string>();

        droids.AddLast("C-3PO");
        droids.AddLast("AZI-3");
        droids.AddLast("R2-D2");
        droids.AddLast("IG-88");
        droids.AddLast("2-1B");

        // Your code here
		droids.Remove("C-3PO");
		droids.Remove(droids.Find("R2-D2"));
		droids.RemoveLast();
    }
}