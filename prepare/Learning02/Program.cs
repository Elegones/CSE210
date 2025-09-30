using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        School school1= new School();
        school.name="BYU-I";
        school.numStudents= 32000;
         school.numTeachers= 500;
        
        school1.ShowDetails();
    }
}