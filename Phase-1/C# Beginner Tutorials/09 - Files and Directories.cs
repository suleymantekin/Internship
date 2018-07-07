/*
    Author: Süleyman Tekin
    Date  : 07.07.2018
 */


// 2.1 Exercise: Write a text file
// Write the message "Han shot first" in a local text file named "StarWars.txt"

using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        // Your code here.
		File.WriteAllText(@".\StarWars.txt", "Han shot first");
    }
}


// 2.2 Exercise: Read a text file
// Read the message back out of the text file "StarWars.txt" and write that message to the console. 
// You should first read the content back out to a variable named content. 
// Next, write the content variable to the console using Console.WriteLine.

using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        File.WriteAllText(@".\StarWars.txt", "Han shot first");
        
        // Your code here.
		string content = File.ReadAllText(@".\StarWars.txt");
        Console.WriteLine(content);
    }
}


// 2.3 Exercise: Delete a file
// Delete the file "StarWars.txt"

using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        File.WriteAllText(@".\StarWars.txt", "Han shot first");
        
        // Your code here.
		File.Delete(@".\StarWars.txt");
    }
}


// 3.1 Exercise: Create a directory
// Create a new directory under the current directory, name this directory 'Droids'.

using System;
using System.IO;

public class Program
{
    public static void Main()
    {        
        // Your code here.
		Directory.CreateDirectory(@".\Droids");
    }
}


// 3.2 Exercise: Delete a directory
// Delete the directory 'Droids' and ensure that all files are removed by using the recursive option.

using System;
using System.IO;

public class Program
{
    public static void Main()
    {        
        Directory.CreateDirectory(@".\Droids");
        File.WriteAllText(@".\Droids\R2D2.txt", "beep bop");
        
        // Your code here.
		Directory.Delete(@".\Droids", true);
    }
}


// 3.3 Exercise: Enumerate files in a directory
// Create a local variable named files which is a string array. 
// You must use Directory.GetFiles to get all text files in the Droids and all child directories. 
// Loop through each item using a foreach loop, writing each item to the console using WriteLine.

using System;
using System.IO;

public class Program
{
    public static void Main()
    {        
        Directory.CreateDirectory(@".\Droids\Astromech");
        Directory.CreateDirectory(@".\Droids\Protocol");
        File.WriteAllText(@".\Droids\Astromech\R2D2.txt", "beep bop");
        File.WriteAllText(@".\Droids\Protocol\C3P0.txt", "sir!");
        
        // Your code here.
		string[] files = Directory.GetFiles(@".\Droids", "*.txt", SearchOption.AllDirectories);
		foreach (string file in files)
		{
			Console.WriteLine(file);   
		}
    }
}


// 4.1 Exercise: Reading from a file
// Read from the local file Movies.txt
// Create a file stream called file using the local file "Movies.txt"
// Create a stream reader called reader using the file stream
// While we are not at the end of the stream, create a local string declaration named movie and assign this the value of the next line from the file
// Write each movie to the Console using WriteLine.
//After the loop close the reader

using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        File.WriteAllText(@".\Movies.txt", "Star Wars\nThe Empire Strikes Back\nReturn Of The Jedi\n");
        
        // Your code here.
		var file = new FileStream(@".\Movies.txt", FileMode.Open);
		var reader = new StreamReader(file);
		while(!reader.EndOfStream){
			string movie = reader.ReadLine();
			Console.WriteLine(movie);
		}
		reader.Close();
    }
}


// 4.2 Exercise: Writing to a file
// Write to the local file Actors.txt
// Create a file stream called file using the local file "Movies.txt" to overwrite the file
// Create a stream writer called writer using the file stream
// Write each item in the list actors to the file on a new line. Use a foreach loop for this
// After the loop, close the reader.

using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    public static void Main()
    {
        List<string> actors = new List<string>()
        {
            "Mark Hamill",
            "Harrison Ford",
            "Carrie Fisher"
        };
        
        // Your code here.
		var file = new FileStream(@".\Actors.txt", FileMode.Create);
		var writer = new StreamWriter(file);
		foreach(string actor in actors){
			writer.WriteLine(actor);
		}
		
		writer.Close();
    }
}


// 5.1 Exercise: Reading from a file with using
// Read from the local file 'Movies.txt'
// Create a file stream caleld file with a using statement.
//Create a stream reader called reader using the file stream. This block must be nested using block syntax { ... }.
// While we are not at the end of the stream, create a local string declaration named movie and assign this the value of the next line from the file.
// Write each move to the Console using WriteLine.

using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        File.WriteAllText(@".\Movies.txt", "Star Wars\nThe Empire Strikes Back\nReturn Of The Jedi\n");
        
        // Your code here.
		using (var file = new FileStream(@".\Movies.txt", FileMode.Open))
		{
            using (var reader = new StreamReader(file))
            {
                while(!reader.EndOfStream){
                    string movie = reader.ReadLine();
                    Console.WriteLine(movie);
                }
            }
		}
    }
}


// 5.2 Exercise: Writing to a file with using
// Write to the local file Actors.txt
// Create a file stream called file with a using statement.
// Create a stream writer called writer using the file stram. This block must not use block syntax { ... } and instead by nested as the single statement under the previous using.
// Write each item in the list actors to the file on a new line. Use a foreach loop for this.

using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    public static void Main()
    {
        List<string> actors = new List<string>()
        {
            "Mark Hamill",
            "Harrison Ford",
            "Carrie Fisher"
        };
        
        // Your code here.
		using (var file = new FileStream(@".\Actors.txt", FileMode.Create))
		using (var writer = new StreamWriter(file))
        {
			foreach(string actor in actors){
				writer.WriteLine(actor);
			}
        }
		
    }
}


// 6.1 Exercise: Working with directories
// Create an instance of DirectoryInfo, named directory for the path .\.
// Get the child directories as an array of DirectoryInfo and assign them to a new variable named children.
// Using a for loop, enumerate through the items of children and write each item's Name to the console usingWriteLine.

using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        Directory.CreateDirectory(@".\sub-dir1");
        Directory.CreateDirectory(@".\sub-dir2");
        Directory.CreateDirectory(@".\sub-dir3");

        // Your code here
		var directory = new DirectoryInfo(@".\");
		var children = directory.GetDirectories();
		for(int i = 0; i < children.Length; i++){
			Console.WriteLine(children[i].Name);
		}
    }
}


// 6.2 Exercise: Working with files
// Create an instance of FileInfo, named file for the path `.\hello-world.txt.
// Using an if statement, check to see if the file exists.
// If the file does exist, create a new string variable named fileName and assign it the value using the correct Pathmethod, using the FullName property of your FileInfo instance.
// Write the fileName variable to the console using WriteLine.


using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        File.WriteAllText(@".\hello-world.txt", "Hello World");

        // Your code here
		var file = new FileInfo(@".\hello-world.txt");
		if(file.Exists){
			var fileName = Path.GetFileName(file.FullName);
			Console.WriteLine(fileName);
		}
    }
}