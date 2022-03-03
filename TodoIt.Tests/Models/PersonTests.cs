using System;
using Xunit;
using TodoItApp.Models;

namespace TodoIt.Tests
{
    public class PersonTests
    {
        [Fact]
        public void PersonIdTest()
        {
            //Arrange
            Person person = new Person(1);
            int testValue = 0;
            Assert.NotEqual(testValue, person.PersonId);
            Assert.Equal(1, person.PersonId);
        }

        [Fact]
        public void PersonFirstNameTest()
        {
            Person person = new Person(1);
            Person personTwo = new Person(1);
            person.FirstName = "Test";
            string result = "Test";
            Assert.NotNull(person.FirstName);
            Assert.Equal(result, person.FirstName);
            Assert.NotEqual("", person.FirstName);
        }

        [Fact]
        public void PersonLastNameTest()
        {
            Person person = new Person(1);
            person.LastName = "Test";
            string result = "Test";
            Assert.NotNull(person.LastName);
            Assert.Equal(result, person.LastName);
            Assert.NotEqual("", person.LastName);
        }


        [Fact]
        
        public void TestFirstNameThrowsNullReferenceException()
        {
            //Arrange
            string expected = "The first name can't be empty or null!";
            Person person = new Person(1, "testFirstName", "testLastname");
            string firstName = null;
            //Act and Assert
            var result = Assert.Throws<ArgumentException>(() => person.FirstName = firstName );
            Assert.Equal(expected, result.Message);

        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]

        public void TestFirstNameThrowsException(string firstName)
        {
            //Arrange
            string expected = "The first name can't be empty or null!";
            Person person = new Person(1, "testFirstName", "testLastname");
            //Act and Assert
            var result = Assert.Throws<ArgumentException>(() => person.FirstName = firstName);
            Assert.Equal(expected, result.Message);

        }
        [Fact]

        public void TestLastNameThrowsNullReferenceException()
        {
            string expected = "The last name can't be empty or null!";
            //Arrange
            Person person = new Person(1, "testFirstName", "testLastname");
            string lastName = null;
            //Act and Assert
            var result = Assert.Throws<ArgumentException>(() => person.LastName = lastName);
            Assert.Equal(expected, result.Message);

        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]

        public void TestLastNameThrowsException(string lastName)
        {
            //Arrange
            string expected = "The last name can't be empty or null!";
            Person person = new Person(1, "testFirstName", "testLastname");
            //Act and Assert
            var result = Assert.Throws<ArgumentException>(() => person.LastName = lastName);
            Assert.Equal(expected, result.Message);
        }

        [Fact]

        public void TestPersonConstructorThrowsNullReferenceException()
        {
            string expected = "The first name can't be empty or null!";
            //Act and Assert
            var result = Assert.Throws<ArgumentException>(() => new Person(1, null, null));

            Assert.Equal(expected, result.Message);

        }

        [Theory]
        [InlineData("", "")]
        [InlineData(" "," ")]

        public void TestTwoPersonConstructorThrowsNullReferenceException(string firsName, string lastName)
        {
            string expected = "The first name can't be empty or null!";
            //Act and Assert
            var result = Assert.Throws<ArgumentException>(() => new Person(1, firsName, lastName));
            Assert.Equal(expected, result.Message);
        }


        [Fact]

        public void TestPersonConstructorLastNameThrowsNullReferenceException()
        {
            string expected = "The last name can't be empty or null!";
            //Act and Assert
            var result = Assert.Throws<ArgumentException>(() => new Person(1, "Test", null));

            Assert.Equal(expected, result.Message);

        }

        [Theory]
        [InlineData("Test ", "")]
        [InlineData("Test ", " ")]

        public void TestTwoPersonConstructorLastNameThrowsNullReferenceException(string firsName, string lastName)
        {
            string expected = "The last name can't be empty or null!";
            //Act and Assert
            var result = Assert.Throws<ArgumentException>(() => new Person(1, firsName, lastName));
            Assert.Equal(expected, result.Message);
        }        
    }
}