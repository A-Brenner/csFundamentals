using System;
using System.Collections.Generic;

namespace GradeBook
{




    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Andrew's GradeBook");
            book.AddGrade(50);
            book.AddGrade(75);
            System.Console.WriteLine(book.GetName());

            List<double> myList = new List<double>() { 50.85, 75.22, 90.99, 100.0 };
            var book2 = new Book(myList);
            Statistics stats = book2.GetStatistics();
            System.Console.WriteLine($"The Average grade is: {stats.Average}");
            System.Console.WriteLine($"The highest grade is: {stats.High}");
            System.Console.WriteLine($"The lowest grade is: {stats.Low}");



        }
    }
}

