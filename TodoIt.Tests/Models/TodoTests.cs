using System;
using Xunit;
using TodoItApp.Models;

namespace TodoIt.Tests
{
    public class TodoTests
    {
        [Fact]
        public void TodoIdTest()
        {
            Todo todo = new Todo(1, "testDescription");
        }
    }
}
