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

        }
    }
}