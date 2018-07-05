/*
    Author: Süleyman Tekin
    Date  : 05.07.2018
 */

 // 3.1 Exercise: Define your own class
 // Define a class named Animal with no methods or properties.

 // Create your class here
public class Animal {}


public class Program
{
	public static void Main()
	{

	}
}


// 4.1 Exercise: Declare an instance of your Class
// Declare an instance of your Animal class assigned to a variable named 'dog' within your 'Main' entry point method.

public class Animal
{
	
}

public class Program
{
	public static void Main()
	{
		Animal dog = new Animal();
	}
}


// 5.1 Exercise: Add a method to your class
/* 
   Add a method named Speak to your Animal class. 
   The method should contain the following: Console.WriteLine("The dog says woof!");. 
   The method should not return anything 
*/

using System;

public class Animal
{
	public void Speak(){
		Console.WriteLine("The dog says woof!");
	}
}

public class Program
{
	public static void Main()
	{

	}
}



// 6.1 Exercise: Add a property to your class
// Add a string property to your class named Sound.

using System;

public class Animal
{
	public string Sound { get; set; }
    public void Speak()
    {
        Console.WriteLine("The dog says woof!");
    }
}

public class Program
{
    public static void Main()
    {

    }
}



// 6.2 Exercise: Updated your method to print the Sound property value
// Change your Speak method to write the sentence "The dog says" + the value of your Sound property.

using System;

public class Animal
{
    public string Sound { get; set; }

    public void Speak()
    {
        Console.WriteLine("The dog says " + Sound);
    }
}

public class Program
{
    public static void Main()
    {

    }
}


// 7.1 Exercise: Add a constructor to your class.
// Add a constructor to your Animal class. Your constructor should pass in a string parameter named "sound".

using System;

public class Animal
{	
    public string Sound { get; set; }
	
	public Animal(string sound){
		Sound = sound;
	}

    public void Speak()
    {
        Console.WriteLine("The dog says " + Sound);
    }
}

public class Program
{
    public static void Main()
    {

    }
}


// 8.1 Exercise: Add a DateOfBirth property to your class
// Add a DateOfBirth property to your class, which is of type DateTime.

using System;

public class Person
{
	public Person(string firstName, string lastName)
	{
		FirstName = firstName;
		LastName = lastName;
	}
	
	public string FirstName { get; set; }
	
	public string LastName { get; set; }
	
	public DateTime DateOfBirth { get; set; }
	
	public string GetFullName()
	{
		return FirstName + " " + LastName;
	}
}

public class Program
{
	public static void Main()
	{

	}
}


// 8.2 Exercise: Add a GetAge method to your class
// Add a method called GetAge which has the method body: "return DateTime.Now.Year - DateOfBirth.Year;"

using System;

public class Person
{
	public Person(string firstName, string lastName)
	{
		FirstName = firstName;
		LastName = lastName;
	}
	
	public string FirstName { get; set; }
	
	public string LastName { get; set; }
	
	public DateTime DateOfBirth { get; set; }
	
	public string GetFullName()
	{
		return FirstName + " " + LastName;
	}
	
	public int GetAge(){
		return DateTime.Now.Year - DateOfBirth.Year;
	}
}

public class Program
{
	public static void Main()
	{

	}
}


// 8.3 Exercise: Update your constructor
// Update your existing constructor to accept a value for the `DateOfBirth` property.

using System;

public class Person
{
	public Person(string firstName, string lastName, DateTime dateOfBirth)
	{
		FirstName = firstName;
		LastName = lastName;
		DateOfBirth = dateOfBirth;
	}
	
	public string FirstName { get; set; }
	
	public string LastName { get; set; }
	
	public DateTime DateOfBirth { get; set; }
	
	public string GetFullName()
	{
		return FirstName + " " + LastName;
	}
	
	public int GetAge()
	{
		return DateTime.Now.Year - DateOfBirth.Year;
	}
}

public class Program
{
	public static void Main()
	{

	}
}