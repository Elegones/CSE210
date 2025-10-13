using System;
using System.Security.Cryptography;
using System.IO; 
class Program
{

    public string Ochoice;
    
    public string _FullLine;
    static void Main(string[] args)
    {
     Console.WriteLine("Menu: Option 1 Display Entry");
     Console.WriteLine("Menu: Option 2 Load Entry");
     Console.WriteLine("Menu: Option 3 save Entry");
     Console.WriteLine("Menu: Option 4 Add Entry");
     Console.WriteLine("Menu: Option 5  Exit");

     Console.WriteLine("Enter the opertation number you would like to do?");
     Ochoice = Console.Readline();
     While(Ochoice != "5");
     {
        if (Ochoice=="1")
        {

        }
        else if (Ochoice=="2")
        {

        }
         else if (Ochoice=="3")
        {
             Entry Centry= new Entry();
        Centry.Dentry();

        }
         else if (Ochoice=="4")
        {
            Entry Centry= new Entry();
            Centry.Dentry();
            _FullLine=Centry._FullLine;
            ProgramF Nfile = new ProgramF();
            Nfile.OpenCreate(_FullLine);
        }
         else  
        {
            Ochoice="5";

        }
     }
     

       

        Entry Centry= new Entry();
        Centry.Dentry();




    }
}