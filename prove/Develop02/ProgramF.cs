using System;
using System.Security.Cryptography;
using System.IO; 
public class ProgramF

{
public string _saveF;
public string _loadF;

public string _fName;

public void OpenCreate(string _FullLine)
{
string filename = "Devolop2.txt";

using (StreamWriter outputFile = new StreamWriter(filename))
{
   
    outputFile.WriteLine(_FullLine);
   
    
}

}

public void LoadF()
{

string filename = "Devolop2.txt";
string[] lines = System.IO.File.ReadAllLines(filename);

foreach (string line in lines)
{
    string[] parts = line.Split(",");

    string firstName = parts[0];
    string lastName = parts[1];
}

}

}