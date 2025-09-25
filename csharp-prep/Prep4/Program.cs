using System;

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


        } while (numList!=0);

        for (int i = 0; i < numberList.Count; i++) 
        {
            Console.WriteLine(numberList[i]);
        }

    }
}