using System;

namespace MyFirstProject
{
    class Program
    {
     static void Main(string[] args)
     {
       int mark = 100;

       if (mark >= 50) //if is if its true
       {
         Console.WriteLine("You passed.");
         if(mark == 100)
         {
           Console.WriteLine("Perfect!");
         }
       }
       else //Else is if its false.
       {
         Console.WriteLine("You failed.");
       }
     }
        
    }
}
