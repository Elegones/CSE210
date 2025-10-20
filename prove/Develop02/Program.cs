using System;
using System.Security.Cryptography;
using System.IO; 
class Program
{
 
   
    


    static void Main(string[] args)
    {
      int Ochoice;
      string Wchoice;
     string _FullLine="";
     string _FileChoice="";
     string[] Test;
     string[] FileList;
     int idx=0;
     FileList= new string[100];
     
    //Menu
     Console.WriteLine("Menu: Option 1 Display Entry");
     Console.WriteLine("Menu: Option 2 Load Entry");
     Console.WriteLine("Menu: Option 3 save Entry");               
     Console.WriteLine("Menu: Option 4 Add Entry");
     Console.WriteLine("Menu: Option 5  Exit");

     Console.WriteLine("Enter the opertation number you would like to do ?");
     Ochoice=0;

     while (Ochoice != 5)
     {
       Wchoice = Console.ReadLine();
       Ochoice=int.Parse(Wchoice);
       int i=0;
       //Display choice
        if (Ochoice==1)
        {
            Console.WriteLine("What file would you like to display?");
            _FileChoice=Console.ReadLine();

            ProgramF Nfile = new ProgramF();
           Test= Nfile.LoadF(_FileChoice);
           
            i=0;
           foreach (string line in Test)
            {
                
                Console.WriteLine(Test[i]);
                i=i+1;
            }
            i=0;
        }

        //Load choice
        else if (Ochoice==2)
        {
               Console.WriteLine("What file would you like to load from?");
            _FileChoice=Console.ReadLine();

            ProgramF Nfile = new ProgramF();
           Test= Nfile.LoadF(_FileChoice);
           i=0;
              foreach (string line in Test)
            {
                
                FileList[idx] =Test[i];
                idx++;
                i++;
                
            }
          i=0;

        }

        //Save choice
         else if (Ochoice==3)
        {
              Console.WriteLine("What file would you like to save to?");
            _FileChoice=Console.ReadLine();

            ProgramF Nfile = new ProgramF();
            Nfile.OpenCreate(FileList,idx,_FileChoice);
        }

        //Add choice
         else if (Ochoice==4)
        {
              

            Entry Centry= new Entry();
            Centry.Dentry();
            _FullLine=Centry._FullLine;
          FileList[idx] =_FullLine;
            idx++;
        }
        //Sets it to 5 to end loop and exit program
         else  
        {
            Ochoice=5;

        }
     }
     

       

       




    }
}