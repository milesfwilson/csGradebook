using System;
using System.Collections.Generic;

namespace GradeBook
{
  public class Grades
  {

    List<Student> students = new List<Student>();

    public string AddGrade()
    {
      Console.WriteLine("Enter the name of the student... ");
      string studentName = Console.ReadLine();
      Console.WriteLine("Enter the grade of the assignment... ");
      string grade = Console.ReadLine();
      students.Add(new Student(studentName, double.Parse(grade)));
      Console.Clear();
      return $"Successfully added {studentName} with a grade of {grade}";
    }
    public double CalculateAverage()
    {
      double sum = 0;
      for (int i = 0; i < students.Count; i++)
      {
        sum += students[i].Grade;
      }
      return sum / students.Count;
    }

    public string GetRange()
    {
      var lowestGrade = students[0].Grade;
      var highestGrade = students[0].Grade;
      for (int i = 0; i < students.Count; i++)
      {
        if (lowestGrade < students[i].Grade)
        {
          lowestGrade = students[i].Grade;
        }
        if (highestGrade > students[i].Grade)
        {
          highestGrade = students[i].Grade;
        }
      }
      return $"The lowest grade is {lowestGrade} and the highest is {highestGrade}";
    }
  }
}