using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hi, what is you grade");
        string lGrade = Console.ReadLine();

        int nGrade = int.Parse(lGrade);

        string let = "N";

        if (nGrade > 90)
        {
            
            let = "A";
        }

        else if (nGrade > 80)
        {
            
            let = "B";
        }

        else if (nGrade > 70)
        {
         
            let = "C";
        }
           else if (nGrade > 60)
        {
          
            let = "D";
        }
        else
        {
          
            let = "F";
        }


        if (let == "A" || let == "B" || let == "C")
        {
            Console.WriteLine($"Good job you pass the class, your grade is a {let}");
        }
        else 
        {
        Console.WriteLine($"Better luck next time, you did not pass, your grade is a {let}");
        }

    }
}