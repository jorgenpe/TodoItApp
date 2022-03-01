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
            var expected = 1;
            Assert.Equal(expected,todo.TodoId);
            Assert.NotEqual(0,todo.TodoId);

        }

        [Fact]
        public void TodoDescriptionTest()
        {
            Todo todo = new Todo(1, "testDescription");
            var expected = "testDescription";
            Assert.Equal(expected, todo.Description);
            Assert.NotEqual("notTest", todo.Description);

        }


        [Fact]
        public void TodoDoneTest()
        {
            Todo todo = new Todo(1, "testDescription");
            Assert.False(todo.Done);
            todo.Done = true;
            Assert.True(todo.Done);

        }


        [Fact]
        public void TodoAssigneeTest()
        {
            Person assignee = new Person(1);
            Todo todo = new Todo(1, "testDescription");
            
            todo.Assignee = assignee;

            Assert.Equal(1,todo.Assignee.PersonId);
            Assert.NotEqual(0,todo.Assignee.PersonId );
        }
    }
}
