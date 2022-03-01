using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TodoItApp.Data;

namespace TodoIt.Tests.Data
{
    public class TodoSequencerTests
    {
        [Fact]
        public void TodoSequencerTest()
        {

            Assert.NotEqual(0, TodoSequencer.NextTodoId());
            TodoSequencer.Reset();
            Assert.Equal(1, TodoSequencer.NextTodoId());
            Assert.Equal(2, TodoSequencer.NextTodoId());
            Assert.Equal(3, TodoSequencer.NextTodoId());
        }
    }
}
