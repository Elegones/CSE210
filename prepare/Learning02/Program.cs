using System;

class Program
{
    static void Main(string[] args)
    {
   Jobs jobs1 = new Jobs();
   jobs1.Company="Microsoft"; 
   jobs1.JobTitle="Programer"; 
   jobs1.StartDate=1999; 
   jobs1.EndDate=2010; 

   

     Jobs jobs2 = new Jobs();
   jobs2.Company="Raytheon"; 
   jobs2.JobTitle="Programer"; 
   jobs2.StartDate=1999; 
   jobs2.EndDate=2010; 

   

    Resume MyResume = new Resume();
    MyResume.Name="Ethan Legones";
    MyResume.job.Add(jobs1);
    MyResume.job.Add(jobs2);

    MyResume.DisplayResume();

   
    




    }
}