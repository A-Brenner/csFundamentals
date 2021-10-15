using System;
using Xunit;

namespace GradeBook.tests
{
    public class TypeTests
    {


        // String is a Reference type
        // But, it acts very much like a value type
        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string myString = "Hello World";

            MakeUpperCase(myString);

            Assert.Equal("Hello World", myString);
        }

        private void MakeUpperCase(string s)
        {
            s.ToUpper();
            // toUpper returns a COPY of the string in uppercase
            // Strings are immutable
            // Will not change the actual string, therefore it acts like a value type
        }


        [Fact]
        public void CanValueTypeBeReferenced()
        {
            int x = GetInt();
            SetInt(ref x);


            Assert.Equal(42, x);
        }

        private int SetInt(ref int x)
        {
            x = 42;
            return x;
        }

        private int GetInt()
        {
            return 3;
        }

        // PASS BY REFERENCE
        [Fact]
        public void CSharpCanPassByRef()
        {
            Book book1 = new Book();

            // Passing in the actual Reference
            GetBookSetName(ref book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetName(ref Book book, string newName)
        {
            // Not a Copy
            // book1 is now pointing to a new location (a new book with a new name)
            book = new Book(newName);
        }


        // PASS BY VALUE
        [Fact]
        public void CSharpIsPassByValue()
        {
            Book book1 = GetBook("Original Name");

            GetBookSetName(book1, "New Name");

            Assert.Equal("Original Name", book1.Name);
        }

        private void GetBookSetName(Book book, string newName)
        {
            book = new Book(newName);
            // book parameter is a COPY of book1
            // They both point to the same thing originally
            // When you change what it POINTS to, it only affects the local parameter
            // the "real" book1 is UNAFFECTED
        }


        [Fact]
        public void CanSetNameFromReference()
        {
            Book book1 = GetBook("Original Name");

            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(Book book, string newName)
        {
            book.Name = newName;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            Book book1 = GetBook("Book 1");
            Book book2 = GetBook("Book 2");

            Boolean sameBook = book1 == book2;
            Boolean sameBookName = book1.Name == book2.Name;
            bool x = true;

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.Equal(false, sameBook);
            Assert.Equal(false, sameBookName);
        }

        [Fact]
        public void TwoVariablesCanReferenceSameObject()
        {

            Book book1 = GetBook("Book 1");
            Book book2 = book1;


            Boolean sameBook = book1 == book2;
            Boolean sameBookName = book1.Name == book2.Name;


            Assert.Equal(sameBook, true);
            Assert.Equal(sameBookName, true);
            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));

        }

        // default is private
        private Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
