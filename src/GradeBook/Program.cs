using System;
using System.Collections.Generic;

namespace GradeBook
{




    class Program
    {
        static void Main(string[] args)
        {
            // var book = new Book("Andrew's GradeBook");
            // book.AddGrade(50);
            // book.AddGrade(75);
            // System.Console.WriteLine(book.GetName());

            // List<double> myList = new List<double>() { 50.85, 75.22, 90.99, 100.0 };
            //var book2 = new Book(myList);
            //Statistics stats = book2.GetStatistics();

            Book book3 = new Book("Book 3");
            string input = "";
            System.Console.WriteLine("Add grades, press 'q' to quit when finished");
            do
            {
                input = System.Console.ReadLine();
                try
                {
                    double grade = double.Parse(input);
                    book3.AddGrade(grade);
                }
                catch (ArgumentException e)
                {
                    System.Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    System.Console.WriteLine(e.Message);
                }
            } while (input != "q");



            Statistics stats = book3.GetStatistics();
            System.Console.WriteLine($"The average grade is: {stats.Average:N2}");
            System.Console.WriteLine($"The highest grade is: {stats.High:N2}");
            System.Console.WriteLine($"The lowest grade is: {stats.Low:N2}");
            System.Console.WriteLine($"The average letter grade is: {stats.AvgLetter}");



        }
    }
}

