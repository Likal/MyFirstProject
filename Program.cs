﻿using System;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
      int age = Convert.ToInt32(Console.ReadLine());
      
        //Practicing entering a comment
      Console.WriteLine("You are {0} years old", age);
        }
    }
}
