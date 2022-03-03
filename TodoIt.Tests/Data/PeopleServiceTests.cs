using System;
using System.Collections.Generic;
using System.Text;
using TodoItApp.Data;
using TodoItApp.Models;
using Xunit;

namespace TodoIt.Tests.Data
{
    public class PeopleServiceTests
    {
        [Fact]
        public void SizeArrayTest()
        {
            PersonSequencer.Reset();
            PeopleService personService = new PeopleService();
            Assert.Equal(0, personService.Size());

            personService.CreatePerson("firstNameOne", "lastNameOne");
            personService.CreatePerson("firstNametwo", "lastNameTwo");
            personService.CreatePerson("firstNameThree", "lastNameThree");
            Assert.NotEqual(0, personService.Size());
            Assert.Equal(3, personService.Size());
        }
        
        [Fact]
        public void FindAllTest()
        {
            PersonSequencer.Reset();
            
            PeopleService personService = new PeopleService();
            personService.Clear();
            int expected = 0;
            int notExpected = 0;
            Assert.Equal(expected, personService.FindAll().Length);
            
            personService.CreatePerson("firstNameOne", "lastNameOne");
            personService.CreatePerson("firstNametwo", "lastNameTwo");
            personService.CreatePerson("firstNameThree", "lastNameThree");
            personService.CreatePerson("firstNameFour", "lastNameFour");
            Assert.NotEqual(notExpected, personService.FindAll().Length);
            Assert.Equal(personService.Size(), personService.FindAll().Length);
        }

        [Fact]
        public void FindByIdTest()
        {
            PersonSequencer.Reset();

            PeopleService personService = new PeopleService();
            personService.Clear();

            personService.CreatePerson("firstNameOne", "lastNameOne");
            personService.CreatePerson("firstNametwo", "lastNameTwo");
            personService.CreatePerson("firstNameThree", "lastNameThree");
            personService.CreatePerson("firstNameFour", "lastNameFour");

            Person result = personService.FindById(2);

            Assert.NotEqual(0, result.PersonId);
            Assert.Equal(2, result.PersonId);
        }

        [Fact]
        public void RemoveById()
        {
            PersonSequencer.Reset();

            PeopleService personService = new PeopleService();
            personService.Clear();

            personService.CreatePerson("firstNameOne", "lastNameOne");
            personService.CreatePerson("firstNametwo", "lastNameTwo");
            personService.CreatePerson("firstNameThree", "lastNameThree");
            personService.CreatePerson("firstNameFour", "lastNameFour");

            Assert.False(personService.RemovePersonById(200));
            Assert.True(personService.RemovePersonById(2));
        }


        [Fact]
        public void ClearTest()
        {
            PersonSequencer.Reset();

            PeopleService personService = new PeopleService();
            personService.Clear();

            Person result = personService.CreatePerson("firstNameOne", "lastNameOne");
            personService.CreatePerson("firstNametwo", "lastNameTwo");
            personService.CreatePerson("firstNameThree", "lastNameThree");
            personService.CreatePerson("firstNameFour", "lastNameFour");

            Assert.NotEqual(0, personService.Size());
            Assert.Equal("firstNameOne", result.FirstName);
            Assert.Equal("lastNameOne", result.LastName);
            personService.Clear();
            Assert.NotNull(personService);
            Assert.Equal(0, personService.FindAll().Length);
        }

    }
}
