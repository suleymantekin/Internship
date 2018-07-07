/*
    Author: Süleyman Tekin
    Date  : 07.07.2018
 */


// Task 1

using System;
using System.Collections.Generic;

// Your code here
public class Program{
	public static void Main(string[] args){
	}

}


// Task 2

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {

    }
}

// Your code here.
public abstract class Answer{
	public int Score { get; set; }
}


// Task 3

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {

    }
}

public abstract class Answer
{
    public int Score { get; set; }
}

// Your code here.
public abstract class Question
{
    public string Label { get; set; }
	
	protected abstract Answer CreateAnswer(string input);
	
	protected virtual void PrintQuestion(){
		Console.WriteLine(Label);
	}
	
	public Answer Ask(){
		PrintQuestion();
		string input = Console.ReadLine();
		return CreateAnswer(input);
		
	}
}


// Task 4

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {

    }
}

public abstract class Answer
{
    public int Score { get; set; }
}

public abstract class Question
{
    public string Label { get; set; }

    protected abstract Answer CreateAnswer(string input);

    protected virtual void PrintQuestion()
    {
        Console.WriteLine(Label);
    }

    public Answer Ask()
    {
        PrintQuestion();

        string input = Console.ReadLine();

        return CreateAnswer(input);
    }
}

// Your code here.

public class TextAnswer : Answer {
	public string Text { get; set; }
}



// Task 5

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {

    }
}

public abstract class Answer
{
    public int Score { get; set; }
}

public abstract class Question
{
    public string Label { get; set; }

    protected abstract Answer CreateAnswer(string input);

    protected virtual void PrintQuestion()
    {
        Console.WriteLine(Label);
    }

    public Answer Ask()
    {
        PrintQuestion();

        string input = Console.ReadLine();

        return CreateAnswer(input);
    }
}

public class TextAnswer : Answer
{
    public string Text { get; set; }
}

// Your code here.
public class TextQuestion : Question {
	protected override Answer CreateAnswer(string input){
		return new TextAnswer{Text = input, Score = input.Length};
	}
}



// Task 6 

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {

    }
}

public abstract class Answer
{
    public int Score { get; set; }
}

public abstract class Question
{
    public string Label { get; set; }

    protected abstract Answer CreateAnswer(string input);

    protected virtual void PrintQuestion()
    {
        Console.WriteLine(Label);
    }

    public Answer Ask()
    {
        PrintQuestion();

        string input = Console.ReadLine();

        return CreateAnswer(input);
    }
}

public class TextAnswer : Answer
{
    public string Text { get; set; }
}

public class TextQuestion : Question
{
    protected override Answer CreateAnswer(string input)
    {
        return new TextAnswer { Text = input, Score = input.Length };
    }
}

// Your code here.
public class Survey {
	public string Title { get; set; }
	public List<Question> Questions {get; private set;}
	
	public Survey(string title){
		Title = title;
	}
	
	public void AddQuestion(Question question){
		Questions.Add(question);
	}
	
	
	public int GetScore(){
		int total = 0;
		foreach(Question question in Questions){
			Answer answer = question.Ask();
			total += answer.Score;
		}
		return total;
	}
}



// Task 7


using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
		Survey survey = new Survey("MySurvey");

		var question1 = new TextQuestion();
		question1.Label = "What is your name?";
		var question2 = new TextQuestion();
		question2.Label = "Where are you from?";

		survey.AddQuestion(question1);
		survey.AddQuestion(question2);
        
		int score = survey.GetScore();
		
		Console.WriteLine("Your score: {0}", score);
		
    }
}

public abstract class Answer
{
    public int Score { get; set; }
}

public abstract class Question
{
    public string Label { get; set; }

    protected abstract Answer CreateAnswer(string input);

    protected virtual void PrintQuestion()
    {
        Console.WriteLine(Label);
    }

    public Answer Ask()
    {
        PrintQuestion();

        string input = Console.ReadLine();

        return CreateAnswer(input);
    }
}

public class TextAnswer : Answer
{
    public string Text { get; set; }
}

public class TextQuestion : Question
{
    protected override Answer CreateAnswer(string input)
    {
        return new TextAnswer { Text = input, Score = input.Length };
    }
}

public class Survey
{
    public Survey(string title)
    {
        Title = title;
        Questions = new List<Question>();
    }

    public string Title { get; set; }

    public List<Question> Questions { get; private set; }

    public void AddQuestion(Question question)
    {
        Questions.Add(question);
    }

    public int GetScore()
    {
        int total = 0;
        foreach (Question question in Questions)
        {
            Answer answer = question.Ask();
            total = total + answer.Score;
        }

        return total;
    }
}