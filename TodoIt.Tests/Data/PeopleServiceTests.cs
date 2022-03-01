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

            Assert.Equal(0, personService.FindAll().Length);
            
            personService.CreatePerson("firstNameOne", "lastNameOne");
            personService.CreatePerson("firstNametwo", "lastNameTwo");
            personService.CreatePerson("firstNameThree", "lastNameThree");
            personService.CreatePerson("firstNameFour", "lastNameFour");
            Assert.NotEqual(0, personService.FindAll().Length);
            Assert.Equal(4, personService.FindAll().Length);
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
        public void ClearTest()
        {
            PersonSequencer.Reset();

            PeopleService personService = new PeopleService();
            personService.Clear();

            personService.CreatePerson("firstNameOne", "lastNameOne");
            personService.CreatePerson("firstNametwo", "lastNameTwo");
            personService.CreatePerson("firstNameThree", "lastNameThree");
            personService.CreatePerson("firstNameFour", "lastNameFour");

            Assert.NotEqual(0, personService.Size());
            personService.Clear();
            Assert.NotNull(personService);
            Assert.Equal(0, personService.FindAll().Length);
        }

    }
}
