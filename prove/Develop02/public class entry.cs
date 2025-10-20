using System;
using System.Security.Cryptography;
using System.IO;

public class Entry
{
    
public string _Date;
public string _Comment;
public string _FullLine;
public string _Fprompt;

//Used to set up  entry
public void Dentry()

{
     
    //gets date
 Console.WriteLine("What is the date: ");
 _Date = Console.ReadLine();
 //sets prompt
  Prompt Cprompt= new Prompt();
 _Fprompt=Cprompt.promptChoice();
 Console.WriteLine(_Fprompt); 
//Gets comment
 Console.WriteLine("Comment: ");
_Comment= Console.ReadLine();
//puts them together
_FullLine = string.Concat($"Date:{_Date}, {_Fprompt}: {_Comment}");



}


}