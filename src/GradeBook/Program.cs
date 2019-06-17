using System;
using System.Collections.Generic;

namespace GradeBook
{
  class Program
  {
    static void Main(string[] args)
    {
      var book = new Book("Ifeanyi's Gradebook");
      book.AddGrade(12.5);
      book.AddGrade(3.5);
      book.AddGrade(91.5);

      var stats = book.GetStatistics();

      Console.WriteLine($"The average grade is {stats.Average:N2}");
      Console.WriteLine($"The highest grade is {stats.High:N2}");
      Console.WriteLine($"The lowest grade is {stats.Low:N2}");
 
    }
  }
}
