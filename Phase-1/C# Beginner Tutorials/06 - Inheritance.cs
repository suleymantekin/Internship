/*
    Author: Süleyman Tekin
    Date  : 05.07.2018
 */


// 2.1 Exercise: Implement inheritance
//Define a class named Vehicle. Define another class named Car which inherits from Vehicle.

// Implement your classes here
public class Vehicle{}

public class Car : Vehicle{}

public class Program
{
	public static void Main()
	{

	}
}


// 3.1 Exercise: Inherit from System.Object
// Define a class named Electron that explicitly inherits from System.Object.

// Implement your classes here.
public class Electron : System.Object {}

public class Program
{
	public static void Main()
	{

	}
}


// 3.2 Exercise: Inherit from System.Object without using System.Object, Object or object.
// Define a class named Proton that inherits from System.Object implicitly.

// Implement your classes here.
public class Proton {}

public class Program
{
	public static void Main()
	{

	}
}


// 4.1 Exercise: Define a method named Send on our Message class.
// Extend the Message class to add a method named Send that writes the value of of the Content property to the console.

using System;

public class Message
{
    public string Content { get; set; }
	
	public void Send() {
		Console.WriteLine(Content);
	}
}

public class Program
{
	public static void Main()
	{

	}
}


// 4.2 Exercise: Create a derived class, named Email, that inherits from Message.
// Implement a derived class named Email that inherits from Message.
// In the Main method of your program class, create a new instance of Email assigned to a variable named 'email' and call the Send method.

using System;

public class Message
{
    public string Content { get; set; }

    public void Send()
    {
        Console.WriteLine(Content);
    }
}

public class Email : Message {

}

public class Program
{
	public static void Main()
	{
		Email email = new Email();
		email.Send();
	}
}


// 5.1 Exercise: Create a constructor
// Create a constructor on the base type Atom that accepts an integer named protons and an integer electrons. The constructor should set the values to the associated properties Protons and Electrons.
// Implement a derived type Hydrogen that inherits from Atom and provides the correct arguments for protons and electrons to the base constructor.

public class Atom
{
	public Atom (int protons, int electrons){
		Protons = protons;
		Electrons = electrons;
	}
    public int Protons { get; set; }

    public int Electrons { get; set; }
}

public class Hydrogen : Atom {
	public Hydrogen() : base(1, 1) {}
}
public class Program
{
	public static void Main()
	{

	}
}


// 6.1 Exercise: Implement an abstract class
// Create a class named SpaceStation that is abstract
// On that abstract class, add a abstract method called FireLaser
// Create a derived class called DeathStar that implements the FireLaser method to write "Pew pew" to the Console followed by a new line

using System;

// Implement your classes here
public abstract class SpaceStation {
	public abstract void FireLaser();
}

public class DeathStar : SpaceStation {
	public override void FireLaser(){
		Console.WriteLine("Pew pew");
	}
}

public class Program
{
	public static void Main()
	{

	}
}


// 7.1 Exercise: Use the virtual and override keywords
// Create an abstract class named Astrodroid that provides a virtual method called GetSound which returns a string. The default sound should be the words "Beep beep".
// Implement a method called 'MakeSound' which writes the result of the GetSound method to the Console followed by a new line.
// Create a derived class named R2 that inherits from Astrodroid.
// Override the GetSound method on the R2 class so that it returns "Beep bop".

using System;

// Implement your classes here.
public abstract class Astrodroid {
	public virtual string GetSound(){
		return "Beep beep";
	}
	
	public void MakeSound(){
		Console.WriteLine(GetSound());
	}
}


public class R2 : Astrodroid {
	public override string GetSound(){
		return "Beep bop";
	}
}
public class Program
{
	public static void Main()
	{

	}
}