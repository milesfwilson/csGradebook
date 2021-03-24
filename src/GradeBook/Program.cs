using System;
using System.Collections.Generic;

namespace GradeBook
{
  class Program
  {
    static void Main(string[] args)
    {
      Run();
    }

    static void Run()
    {
      Grades gradesController = new Grades();
      bool running = true;
      while (running)
      {
        Console.WriteLine(@"
          What would you like to do?
          (A) Add Grade
          (C) Calculate Average Grade
          (R) Get Range of Grades
          (Q) Quit
          ");
        string userInput = Console.ReadLine();
        switch (userInput)
        {
          case "A":
            Console.Clear();
            Console.WriteLine(gradesController.AddGrade());
            break;
          case "C":
            Console.Clear();
            Console.WriteLine(gradesController.CalculateAverage());
            break;
          case "R":
            Console.Clear();
            Console.WriteLine(gradesController.GetRange());
            break;
          case "Q":
            Console.Clear();
            running = false;
            break;
          default:
            Console.Clear();
            Console.WriteLine("Please enter a valid option");
            break;
        }
      }

    }
  }
}
