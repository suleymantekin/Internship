/*
    Author: Süleyman Tekin
    Date  : 06.07.2018
 */


// 2.1 Exercise: Use the public modifier
// Modify the example class
// Make the class public
// Add a public method named 'GetAge' that returns an int.

using System;
					
public class Program
{
	public static void Main()
	{
		
	}
	
	public int GetAge(){
	
		return 24;
	}
}


// 3.1 Exercise: Use the private modifier
// Modify the example class Person
// Make the class private
// Add a private method to the example class that contains the method body "return Age.ToString()".

using System;
					
public class Program
{
    private class Person
    {
        public int Age { get; set; }
		
		private string GetAge(){
			return Age.ToString();
		}
    }	

    public static void Main()
    {

    }
}


// 4.1 Exercise: Use the protected modifier
// Add a protected property to the class 'Student' named 'GraduationYear' of type int.

using System;

public class Student
{
	protected int GraduationYear{ get; set; }

    public Student(int graduationYear)
    {
        GraduationYear = graduationYear;
    }

    public int GetYearsSinceGraduation()
    {
        return DateTime.Now.Year - GraduationYear;
    }
}

public class Graduate : Student
{
    public Graduate(int graduationYear)
        : base(graduationYear)
    {

    }

    public void GraduateToday()
    {
        GraduationYear = DateTime.Now.Year;
    }
}

public class Program
{
    public static void Main()
    {
        var student = new Student(2006);
        Console.WriteLine("Years since graduation: {0}", student.GetYearsSinceGraduation());
    }
}


// 5.1 Exercise: Use the internal modifier
// Add a internal property to the example class called 'Order' of type 'int'".

using System;
					
public class Candidate
{
	internal int Order { get; set; }
}

public class Programa
{
	public static void Main()
	{
		var candidate = new Candidate();
		candidate.Order = 1;
	}
}


// 6.1 Exercise: Use the static modifier
// Modify the 'NewLine' property to make it static.
// Add a new static method to the class called Version, of type 'int' which returns the number 4.

using System;
					
public static class Environment
{
	public static string NewLine { get; set; }
	
	public static int Version() {
		return 4;
	}
}

public static class Program
{
	public static void Main()
	{
		Environment.NewLine = "\r\n";
		
		int version = Environment.Version();
	}
}


// 7.1 Exercise: Use the abstract modifier
// Modify the Person class to make it abstract
// Implement the abstract method 'GetPostcode' in the 'Customer' class, returning a string.

using System;

public abstract class Person
{
	public abstract string GetPostcode();
}

public class Customer : Person
{
	public override string GetPostcode(){
		return "Boo";
	}
}

public class Program
{
	public static void Main(string[] args)
	{
		var person = new Customer();
        Console.WriteLine(person.GetPostcode());
	}
}


// 8.1 Exercise: Use the virtual modifier
// Add a virtual method called 'GetName' to the Person method that return the string 'John Smith'
// Overide the method in Lord to return 'Sir John Smith';

using System;

public class Person
{
	public virtual string GetName() {
		return "John Smith";
	}
}

public class Lord : Person
{
	public override string GetName() {
		return "Sir John Smith";
	}
}

public static class Program
{
    public static void Main()
    {
        var person = new Person();
        Person lord = new Lord();

        Console.WriteLine(person.GetName());
        Console.WriteLine(lord.GetName());
    }
}