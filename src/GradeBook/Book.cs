using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {

        // **** Constructors **** //
        public Book()
        {
            Grades = new List<double>();
        }

        public Book(string name)
        {
            Grades = new List<double>();
            Name = name;
            subject = "Science";

        }

        public Book(List<double> listOfGrades)
        {
            Grades = listOfGrades;
        }

        // **** Fields ****
        public List<double> Grades;
        private string name;

        // Simpler way of creating getter and setter for field
        // public string Name { get; set; }
        // Read-only :
        // public string Name { get; private set; }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    // value is implicit when calling set func
                    name = value;
                }
            }
        }

        // Can only be set within constructor or here
        // Cannot set value anywhere else
        readonly string subject;

        // Cannot change constant value, Must initialize with value
        // Const values should be placed in CAPS 
        // static member when using const, bc the value will be the same for EVERY object
        //const string SUBJECT = "Science";

        // **** Methods ****
        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                Grades.Add(grade);
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        // Overloading
        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;
                case 'D':
                    AddGrade(60);
                    break;
                case 'F':
                    AddGrade(0);
                    break;
            }
        }

        public double GetAvgGrade()
        {
            double avg = 0.0;
            foreach (double grade in Grades)
            {
                avg += grade;
            }
            avg /= Grades.Count;
            return avg;
        }

        public double GetMaxGrade()
        {
            double currentMax = double.MinValue;
            foreach (double grade in Grades)
            {
                currentMax = Math.Max(currentMax, grade);
            }
            return currentMax;
        }

        public double GetMinGrade()
        {
            double currentMin = double.MaxValue;
            foreach (double grade in Grades)
            {
                currentMin = Math.Min(currentMin, grade);
            }
            return currentMin;
        }

        public char GetAvgLetter()
        {
            switch (GetAvgGrade())
            {
                case var d when d >= 90:
                    return 'A';
                case var d when d >= 80:
                    return 'B';
                case var d when d >= 70:
                    return 'C';
                case var d when d >= 60:
                    return 'D';
                default:
                    return 'F';
            }
        }

        public Statistics GetStatistics()
        {
            Statistics stats = new Statistics();
            stats.Average = GetAvgGrade();
            stats.High = GetMaxGrade();
            stats.Low = GetMinGrade();
            stats.AvgLetter = GetAvgLetter();
            return stats;
        }



    }
}