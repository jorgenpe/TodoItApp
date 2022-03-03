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
            Person person = new Person(1, "testFirstName", "testLastname");
            string firstName = null;
            //Act and Assert
            Assert.Throws<NullReferenceException>(() => person.FirstName = firstName );
            

        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]

        public void TestFirstNameThrowsException(string firstName)
        {
            //Arrange
            Person person = new Person(1, "testFirstName", "testLastname");
            //Act and Assert
            Assert.Throws<ArgumentNullException>(() => person.FirstName = firstName);
            

        }
    }
}