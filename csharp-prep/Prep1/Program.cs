using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello What is your first name?");
        string name = Console.ReadLine();
        Console.WriteLine("Hello What is your last name?");
        string lname = Console.ReadLine();
        Console.WriteLine($"your name is {lname}, {name} {lname}.");
    }
}