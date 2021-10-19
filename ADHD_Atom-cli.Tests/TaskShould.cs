
using Xunit;

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

    }
}
