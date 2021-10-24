using Xunit;
using System;
using ADHD_Atom_cli;

namespace ADHD_Atom_cli.Tests
{
    public class TaskShould
    {
        [Fact]
        public void Have_a_title()
        {
            var task = new Task("title");
            Assert.Equal("title", task.Title);
        }

        [Fact]
        public void Have_a_description()
        {
            var task = new Task("title", "description");
            Assert.Equal("description", task.Description);
        }

        [Fact]
        public void Have_a_status()
        {
            var task = new Task("title", "description", Task.TaskStatus.Completed);
            Assert.Equal(Task.TaskStatus.Completed, task.Status);
        }
    }
}
