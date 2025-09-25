using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {


        int num = 0;

        int answer = 0;

        
        

        Random randomGenerator = new Random();
        num = randomGenerator.Next(1, 100);

        do
        {

            Console.WriteLine("what is the magic number");

            string Anum = Console.ReadLine();

            answer = int.Parse(Anum);

            if (answer > num)
            {
                Console.WriteLine("Answer is to High");

            }

            else if (answer < num)
            {
                Console.WriteLine("Answer is to Low");

            }

            else
            {

                Console.WriteLine($"Thats correct");
            }




        } while (answer != num);

        }
    
}