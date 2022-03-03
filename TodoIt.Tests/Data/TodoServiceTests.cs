using System;
using System.Collections.Generic;
using System.Text;
using TodoItApp.Data;
using TodoItApp.Models;
using Xunit;

namespace TodoIt.Tests.Data
{
    public class TodoServiceTests
    {
        [Fact]
        public void TodoServiceSizeArrayTest()
        {
            TodoSequencer.Reset();

            TodoService todoService = new TodoService();
            todoService.Clear();
            Assert.Equal(0, todoService.Size());

            todoService.CreateTodoItem("Test string one");
            todoService.CreateTodoItem("Test string two");
            todoService.CreateTodoItem("Test string three");
            todoService.CreateTodoItem("Test string four");

            Assert.NotEqual(3, todoService.Size());
            Assert.Equal(4, todoService.Size());
        }

        [Fact]
        public void TodoServiceFindAllTest()
        {
            TodoSequencer.Reset();

            TodoService todoService = new TodoService();
            todoService.Clear();
            int expected = 0;
            int notExpected = 0;
            Assert.Equal(expected, todoService.FindAll().Length);

            todoService.CreateTodoItem("Test string one");
            todoService.CreateTodoItem("Test string two");
            todoService.CreateTodoItem("Test string three");
            todoService.CreateTodoItem("Test string four");

            Assert.NotEqual(notExpected, todoService.FindAll().Length);
            Assert.Equal(todoService.Size(), todoService.FindAll().Length);

        }

        [Fact]
        public void TodoServiceFindByIdTest()
        {
            TodoSequencer.Reset();

            TodoService todoService = new TodoService();
            todoService.Clear();
         
            todoService.CreateTodoItem("Test string one");
            todoService.CreateTodoItem("Test string two");
            todoService.CreateTodoItem("Test string three");
            todoService.CreateTodoItem("Test string four");
            Todo result = todoService.FindById(2);

            Assert.NotNull(result);
            Assert.Equal(2, result.TodoId);
            result = todoService.FindById(200);
            Assert.Null(result);
        }
        [Fact]
        public void TodoServiceCreateTodoItemTest()
        {
            int expected = 0;
            TodoSequencer.Reset();
            PersonSequencer.Reset();
            TodoService todoService = new TodoService();
            Person person = new Person(PersonSequencer.NextPersonId());
            Person personTwo = new Person(PersonSequencer.NextPersonId());
            todoService.Clear();

            Todo resultOne = todoService.CreateTodoItem("Test string one", true, person);
            todoService.CreateTodoItem("Test string two", false, personTwo);
            todoService.CreateTodoItem("Test string three", true, personTwo);
            todoService.CreateTodoItem("Test string four", false, person);
            Assert.NotNull(resultOne.Assignee);
            Assert.True(resultOne.Done);
            Assert.Equal("Test string one", resultOne.Description);
            Assert.NotEqual(expected, todoService.Size());
        }
    }
}
