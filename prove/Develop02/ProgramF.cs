using System;
using System.Security.Cryptography;
using System.IO; 
public class ProgramF

{
public string _saveF;
public string _loadF;

public string _fName;
int i=0;

//Used to create/ open file to save/add to
public void OpenCreate(string[] FileList,int idx,string _FileChoice)
{
string filename = _FileChoice;

using (StreamWriter outputFile = new StreamWriter(filename))
{
    
     for (i=0; i <=idx ;i++)
            {
                
                outputFile.WriteLine(FileList[i]);
                
            }
   
   
    
}

}
//Used to load from a file/ display from a file
public string[] LoadF(string _FileChoice)
{

string filename = _FileChoice;
string[] lines = System.IO.File.ReadAllLines(filename);



return(lines);
}

}