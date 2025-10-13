using System;
using System.Security.Cryptography;
using System.IO;

public class Entry
{
    
public string _Date;
public string _Comment;
public string _FullLine;
public string _Fprompt;
public void Dentry()


{
     
    
 Console.WriteLine("What is the date");
 _Date = Console.ReadLine();
 
  Prompt Cprompt= new Prompt();
  _Fprompt=Cprompt.promptChoice();

 Console.WriteLine("Comment: ");
_Comment= Console.ReadLine();

_FullLine = string.Concat(_Date,_Fprompt,_Comment);



}


}