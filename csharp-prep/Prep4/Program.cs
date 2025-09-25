using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();
        Console.WriteLine("Enter any numbers you wish to add to the list, enter 0 when your finished");
        int numList = 1;
        do
        {
            string newNum = Console.ReadLine();
            numList = int.Parse(newNum);


            numberList.Add(numList);


        } while (numList != 0);

       
        int total = numberList.Sum();
        Console.WriteLine($"The sum is {total}");

        double ave = numberList.Average();
        Console.WriteLine($"the average is {ave}");

        int big = numberList.Max();
         Console.WriteLine($"the largest numebr entered is {big}");
       

    }
}