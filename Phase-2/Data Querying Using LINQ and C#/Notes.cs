//--------------------------------------------------------------------------------------------------------------------------
// Given two int arrays:

int[] a1 = { 1, 2, 3, 4, 5 };
int[] a2 = { 3, 4, 5, 6, 7 };
// To get the integers appear in both arrays, without LINQ, the code will be:

var result = new List<int>();
foreach (var p in a1) {
    foreach (var q in a2) {
        if (p == q) {
            result.Add(p);
        }
    }
}
// There's a nested foreach loop in the code which is a little bit challenging to new developers. 
//Even for experienced developers, the time of thinking, typing, and maintaining these code is also a considerable cost.

// With LINQ, the code will be as easy as:

var result = a1.Intersect(a2);

//--------------------------------------------------------------------------------------------------------------------------

// If we want to get the names of all the books cheaper than $60, before we have LINQ, the ADO.NET code looks like:

var conn = new SqlConnection(connStr);
conn.Open();
var cmdText = "SELECT [Id],[Author],[Name],[Price] FROM [Bookstore].[dbo].[Book] WHERE Price < 60";
var cmd = new SqlCommand(cmdText, conn);
var reader = cmd.ExecuteReader();
var names = new List<string>();
while (reader.Read()) {
    names.Add(reader["Name"].ToString());
}
conn.Close();

// While using Entity Framework (or Entity Framework Core) with LINQ, the code will just look like:

var names = _dbContext.Book
    .Where(b => b.Price < 60).Select(b => b.Name).ToList();


//--------------------------------------------------------------------------------------------------------------------------

// There are two syntaxes for writing LINQ:

// The standard syntax which looks like code fir calling methods.
// The query expression syntax which looks like SQL queries

// Using standard syntax:
var result = array.Where(n => n > 100);
// Using query expression syntax:
var result = from n in array select n;

//--------------------------------------------------------------------------------------------------------------------------

// Fluent API

// Let's consider this example:
// I want to design a Student class, which has a method named Greet. 
//This Greet method accepts a string parameter. When calling this method, the student just greets the person name passed in. 
//Without exception, your design will be:

public class Student {
    public void Greet(string name) {
        Console.WriteLine($"Hello, {name}!");
    }
}
// To use this class and its method, the code will look like:

var stu = new Student();
stu.Greet("Timothy");
stu.Greet("Tom");
stu.Greet("Roman");

// But, if we design the Greet method as below:

public class Student {
    public Student Greet(string name) {
        Console.WriteLine($"Hello, {name}!");
        return this;
    }
}
// Then, you can call the method like this:

var stu = new Student();
stu.Greet("Timothy").Greet("Tom").Greet("Roman");
// And, you get the same output.

// We can even compress the code to just one line as follows:

new Student().Greet("Timothy").Greet("Tom").Greet("Roman");
// This coding style is called Fluent API. Usually, you will see Fluent API style in two 
//portions of the code - LINQ and programmatic configuration.

//--------------------------------------------------------------------------------------------------------------------------

// Extension methods enable you to “attach” methods to existing types without creating a new derived type, 
// recompiling, or otherwise modifying the original type. Extension methods are a special kind of static methods, 
// but they are called as if they are instance methods on the extended type.

using System;

namespace Trimming {
    static class DoubleExtension {
        public static double Round(this double value, int digits) {
            return Math.Round(value, digits);
        }
    }

    class Program {
        static void Main(string[] args) {
            var d = 12.3456789;
            var r1 = d.Round(2);
            var r2 = d.Round(4);
            Console.WriteLine(d);
            Console.WriteLine(r1);
            Console.WriteLine(r2);
        }
    }
}

// As we see in the code example, the syntax of declaring an extension method is to

// - declare a static method in a static class, and
// - use the this modifier to modify the first parameter of the static method.
// - The type of the first parameter will be the target type this extension method attaches to.
// - When calling the extension method, we don't need to provide argument for the first parameter, since the C# compiler will treat the caller of the extension method as the argument for the first argument.

// There are only two points you should pay attention to:
// - Both the extension method and the host class must be static.
// - The first parameter of extension method must be modified by this. When the method is invoked, 
// this parameter won't appear in the parameter list, since the entity who is calling this method is exactly the parameter. 
// That means, when calling an extension method, 
// the argument list is always shorter than the parameter list of the declaration by one.

//As we see, when we declared the extension method, there are two parameters. But when calling the extension method, 
//we just need to provide one argument - the argument for the first parameter is the caller double value itself in this example.