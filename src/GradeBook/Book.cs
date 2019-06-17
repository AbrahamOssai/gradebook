using System;
using System.Collections.Generic;

namespace GradeBook
{
  public class Book 
  {
    List<double> grades;
    string name;

    public Book(string name)
    {
      grades = new List<double>();
      this.name = name;
    }

    public void AddGrade(double grade)
    {
      grades.Add(grade);
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