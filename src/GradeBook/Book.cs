using System;
using System.Collections.Generic;

namespace GradeBook
{
  public class Book 
  {
    List<double> grades;

    public string Name;

    public Book(string name)
    {
      grades = new List<double>();
      Name = name;
    }

    public void AddGrade(double grade)
    {
      if(grade <= 100 && if grade >= 0)
      {
        grades.Add(grade);
      }
      else
      {
        Console.WriteLine("Invalid value");
      }
    }

    public Statistics GetStatistics()
    {
      var result = new Statistics();
      result.Average = 0.0; 
      result.High = double.MinValue;
      result.Low = double.MaxValue;
      
      foreach(var grade in grades)
      {
          // if(grade > highGrade)
          // {
          //     highGrade = grade;
          // }

          result.High = Math.Max(grade, result.High);
          result.Low = Math.Min(result.Low, grade);
          result.Average += grade;
      }

      result.Average /= grades.Count;

      return result;

    }
  }
}