using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {

        // **** Constructors **** //
        public Book()
        {
            grades = new List<double>();
        }

        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public Book(List<double> listOfGrades)
        {
            grades = listOfGrades;
        }

        // **** Fields ****
        private List<double> grades;
        private string name;

        // **** Methods ****
        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
        }

        public double AvgGrade()
        {
            double avg = 0.0;
            foreach (double grade in grades)
            {
                avg += grade;
            }
            avg /= grades.Count;
            return avg;
        }

        public double MaxGrade()
        {
            double currentMax = double.MinValue;
            foreach (double grade in grades)
            {
                currentMax = Math.Max(currentMax, grade);
            }
            return currentMax;
        }

        public double MinGrade()
        {
            double currentMin = double.MaxValue;
            foreach (double grade in grades)
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
            return name;
        }


    }
}