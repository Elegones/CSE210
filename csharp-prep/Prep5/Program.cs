using System;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;

class Program
{
    static void Introduction()
    {
        Console.WriteLine("Welcome");

    }

    static void Name(out string User)
    {
        Console.WriteLine("what Is your Name");
        User = Console.ReadLine();

    }

    static void Number(out int numb)
    {
        Console.WriteLine("what Is your favorite number(integer)");
        string Lnumb = "N";
        Lnumb = Console.ReadLine();
        numb = int.Parse(Lnumb);

    }

    static void Birth(out int year)
    {
        Console.WriteLine("what Is your Birth year");
        string Bnumb = "B";
        Bnumb = Console.ReadLine();
        year = int.Parse(Bnumb);


    }

    static void Power(out int sq)
    {
        Console.WriteLine("what Is your number you wish to square");
        string snumb = "S";
        snumb = Console.ReadLine();
        int half = 0;
        half = int.Parse(snumb);
        sq = half * half;

    }


    static void Gestalt(string User, int numb, int year, int sq)
    {
        Console.WriteLine($"your name is {User}");
        Console.WriteLine($"your number is {numb}");
        Console.WriteLine($"your Birth year is {year}");
        Console.WriteLine($"your Squared number  is {sq}");

        int age = 0;
        age = 2025 - year;

        Console.WriteLine($"you will be {age} this year.");



    }

    static void Main(string[] args)
    {
        string User = "None";
        int numb = 0;
        int year = 1999;
        int sq = 0;

        Introduction();
        Name(out User);
        Number(out numb);
        Birth(out year);
        Power(out sq);

        Gestalt( User, numb, year, sq);

    }
}