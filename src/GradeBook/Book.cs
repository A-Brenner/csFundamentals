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
        }

        public Book(List<double> listOfGrades)
        {
            Grades = listOfGrades;
        }

        // **** Fields ****
        public List<double> Grades;
        public string Name;

        // **** Methods ****
        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                Grades.Add(grade);
            }
        }

        public double AvgGrade()
        {
            double avg = 0.0;
            foreach (double grade in Grades)
            {
                avg += grade;
            }
            avg /= Grades.Count;
            return avg;
        }

        public double MaxGrade()
        {
            double currentMax = double.MinValue;
            foreach (double grade in Grades)
            {
                currentMax = Math.Max(currentMax, grade);
            }
            return currentMax;
        }

        public double MinGrade()
        {
            double currentMin = double.MaxValue;
            foreach (double grade in Grades)
            {
                currentMin = Math.Min(currentMin, grade);
            }
            return currentMin;
        }

        public Statistics GetStatistics()
        {
            Statistics stats = new Statistics();
            stats.Average = AvgGrade();
            stats.High = MaxGrade();
            stats.Low = MinGrade();
            return stats;
        }

        public string GetName()
        {
            return Name;
        }


    }
}