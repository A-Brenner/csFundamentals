using System;
using Xunit;

namespace GradeBook.tests
{
    public class BookTests
    {
        [Fact]


        public void BookCalculatesGradeStats()
        {
            //arrange
            var book = new Book();
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
        }
    }
}
