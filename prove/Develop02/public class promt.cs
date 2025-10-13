using System;
using System.Security.Cryptography;
using System.IO; 
public class Prompt

{


public string _prompt;
public int _choice=1;


public string promptChoice()
{

Random randomGenerator = new Random();
 _choice = randomGenerator.Next(1, 5);

if ( _choice == 1)
{
    _prompt = " What was your day like?";
    
}
else if (_choice==2)
{
    _prompt="Is there anything you need to do today?";

}
else if (_choice==3)
{
    _prompt=";What was the thing your looking forward to the most";

}
else if (_choice==4)
{
    _prompt="If there was something you could change today what would it be?";

}
else
{
    _prompt="If there was something you could do today what would it be?";

}
  
Console.WriteLine(_prompt); 
return _prompt;
}

}