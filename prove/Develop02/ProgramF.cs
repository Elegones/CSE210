using System;
using System.Security.Cryptography;
using System.IO; 
public class ProgramF

{
public string _saveF;
public string _loadF;

public string _fName;
int i=0;
public void OpenCreate(string[] FileList,int idx)
{
string filename = "Devolop2.txt";

using (StreamWriter outputFile = new StreamWriter(filename))
{
    
     for (i=0; i <=idx ;i++)
            {
                
                outputFile.WriteLine(FileList[i]);
                
            }
   
   
    
}

}

public string[] LoadF()
{

string filename = "Devolop2.txt";
string[] lines = System.IO.File.ReadAllLines(filename);



return(lines);
}

}