using System;
using Xunit;

namespace GradeBook.tests
{
    public class BookTests
    {

        [Fact]
        public void GetsCorrectAverageLetter()
        {
            Book book = new Book();
            book.AddGrade(75.82);
            book.AddGrade(99.99);
            book.AddGrade(62.87);
            book.AddGrade(84.22);
            book.AddGrade(89.73);

            double avg = book.GetAvgGrade();
            char avgLetter = book.GetAvgLetter();

            Assert.Equal(82.5, avg, 1);
            Assert.Equal('B', avgLetter);
        }

        [Fact]
        public void BookCalculatesGradeStats()
        {
            //arrange
            Book book = new Book();
            book.AddGrade(69.91);
            book.AddGrade(76.27);
            book.AddGrade(99.99);
            book.AddGrade(87.47);
            //act
            Statistics result = book.GetStatistics();

            //assert
            Assert.Equal(99.99, result.High, 2);
            Assert.Equal(69.9, result.Low, 1);
            Assert.Equal(83.4, result.Average, 1);
            Assert.Equal('B', result.AvgLetter);
        }
    }
}
