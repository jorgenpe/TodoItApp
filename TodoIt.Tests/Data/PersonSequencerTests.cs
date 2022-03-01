using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TodoItApp.Data;

namespace TodoIt.Tests.Data
{
    public class PersonSequencerTests
    {
        [Fact]
        public void PersonSequencerTest()
        {

            Assert.NotEqual(0, PersonSequencer.NextPersonId());
            PersonSequencer.Reset();
            Assert.Equal(1, PersonSequencer.NextPersonId());
        }
    }
}
